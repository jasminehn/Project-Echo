using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProjectEcho
{
    /**
     *
     *
     *
     * Author(s): E. MacDonald, J. Nelson
     */

    public class GrammarAPI
    {
        public static String pog = "";
        public static String reportOutput = "";

        private static int errorCount = 0; //keeps track of how many grammar errors are found
        private string wordsFound = "FOUND: ";
        private string wordsMissing = "MISSING: ";

        public static int spellingErrorCount = 0;
        public static int grammarErrorCount = 0;
        public static int styleErrorCount = 0;

        public static List<string> glossaryWordList = new List<string>();

        public static async Task CallAPI(String filePath)
        {
            GrammarAPI api = new GrammarAPI();
            var firstDocSegment = "";
            var secondDocSegment = " ";
            var thirdDocSegment = " ";
            string mytext = OpenWordprocessingDocumentReadonly(filePath);
            api.glossaryCheck(mytext);
            Console.WriteLine("****" + mytext);
            var words = mytext.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
            int len = mytext.Length;
            int subLen;

            if (len > 20000)
            {
                subLen = len - 20000;
                firstDocSegment = mytext.Substring(0, 10000);
                secondDocSegment = mytext.Substring(10000, 10000);
                thirdDocSegment = mytext.Substring(20000, subLen);
                Console.WriteLine("first " + firstDocSegment);
                Console.WriteLine(" second " + secondDocSegment);
                Console.WriteLine(" third " + thirdDocSegment);
            }
            else if (len > 10000)
            {
                subLen = len - 10000;
                firstDocSegment = mytext.Substring(0, 10000);
                secondDocSegment = mytext.Substring(10000, subLen);
                Console.WriteLine("first " + firstDocSegment + " second" + secondDocSegment);
            }
            else
            {
                firstDocSegment = mytext;
                Console.WriteLine("first " + firstDocSegment);
            }

            try
            {
                await GrammarCheck(firstDocSegment).ConfigureAwait(false);
                if (mytext.Length > 10000)
                {
                    await GrammarCheck(secondDocSegment).ConfigureAwait(false);
                    if (mytext.Length > 20000)
                    {
                        Console.WriteLine("*** over 20,000 characters");

                        await GrammarCheck(thirdDocSegment).ConfigureAwait(false);
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }
        }

        public static async Task returnReport(string path)
        {
            reportOutput = ""; //reset report output each time it's called
            errorCount = 0; //reset error count
            spellingErrorCount = 0;
            grammarErrorCount = 0;
            styleErrorCount = 0;

            await CallAPI(path);
        }

        public static async Task GrammarCheck(string text)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://grammarbot.p.rapidapi.com/check"),
                Headers = {
                    { "x-rapidapi-host", "grammarbot.p.rapidapi.com" },
                    { "x-rapidapi-key", "e844609f92msha17811bf70a2da7p1ba5b1jsndb8101bcd3e5" },
                },

                //the text variable is the string that was converted from the docx file
                Content = new FormUrlEncodedContent(new Dictionary<string, string> {
                    { "text", text },
                    { "language", "en-US" },
                }),
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var v = JsonConvert.DeserializeObject<dynamic>(body);
                bool item = v.software.premium;
                bool warn = v.warnings.incompleteResults;
                string grammarReport = " ";
                List<string> reportList = new List<string>();
                foreach (var i in v.matches)
                {
                    errorCount++;
                    string errorID = i.rule.category.id;

                    grammarReport = "                      Error #" + errorCount + "\r\n\r\nSENTENCE: " + i.sentence + "\r\n\r\nISSUE: " + i.message + "\r\n\r\nLOCATION: " + i.offset.ToString() + " characters \r\n\r\nSUGGESTION(S): " + i.replacements + "\r\n" + "_____________________________" + "\r\n\r\n";
                    Console.WriteLine("ERROR #" + errorCount + "   error type:" + errorID);

                    if (errorID == "TYPOS")
                    {
                        spellingErrorCount++;
                    }
                    else if (new[] { "GRAMMAR", "CASING", "PUNCTUATION" }.Contains(errorID))
                    {
                        grammarErrorCount++;
                    }
                    else
                    {
                        styleErrorCount = styleErrorCount + 1;
                    }

                    Console.WriteLine("spelling error count: " + spellingErrorCount);
                    Console.WriteLine("grammar error count: " + grammarErrorCount);
                    Console.WriteLine("style error count: " + styleErrorCount);
                    reportList.Add(grammarReport);
                }

                for (int i = 0; i < reportList.Count; i++)
                {
                    reportList[i] = reportList[i].Replace("[", "");
                    reportList[i] = reportList[i].Replace("]", "");
                    reportList[i] = reportList[i].Replace("{", "");
                    reportList[i] = reportList[i].Replace("}", "");
                }

                //Console.WriteLine(string.Join(" ", reportList));
                reportOutput += string.Join(" ", reportList);
                // string s = getReport(body);
            }
        }

        //Converts docx files to string
        public static string OpenWordprocessingDocumentReadonly(string filepath)
        {
            // Uses the filepath to open a Word Document
            using (WordprocessingDocument wordDocument =
                WordprocessingDocument.Open(filepath, false))
            {
                Body docInfo = wordDocument.MainDocumentPart.Document.Body;

                string docString = docInfo.InnerText.ToString();

                //return docInfo.InnerText.ToString();
                return docString;
            }

            //return "1"; //unreachable code
        }

        //This method will clean up the JSON file so that the report is user friendly
        public static string getReport(string text)
        {
            // string docText = "words.. words.. match: spell check";
            string s = "words..... offset: 20";
            int i = s.IndexOf("offset");
            //Console.WriteLine("the index is " + i);
            string n = s.Substring(i, 10);
            // Console.WriteLine("new string*** " + n);

            string cutString = text.Split(new string[] { "matches" }, StringSplitOptions.None).Last();
            //string offSetVals = " ";

            return cutString;
        }

        public bool glossaryCheck(string documentString)
        {
            string[] glossary = {"academic language","active nature of young children's learning","aligned",
                   "artifacts","assessment","personal assets","cultural assets","community assets",
                   "central focus","commentary","engaging children in learning","evaluation criteria",
                    "evidence","interdisciplinary","learning environment","learning experience",
                    "learning objectives", "multimodal nature of young children's learning",
                    "patterns of learning", "planned supports","prior academic learning and prerequisite skills",
                    "rapport","respect","rubrics","variety of learners","whole child"};
            List<string> missingWords = new List<string>();
            string word = "";
            bool wordExists = true;

            for (int i = 0; i < glossary.Length; i++)
            {
                if (documentString.Contains(glossary[i]))
                {
                    //Console.WriteLine("Found word");

                    wordsFound = wordsFound + (" " + glossary[i]) + "\n";
                }
                else
                {
                    word = glossary[i];
                    missingWords.Add(word);
                    wordExists = false;

                    wordsMissing = wordsMissing + (" " + glossary[i]) + "\n";

                    glossaryWordList.Add(glossary[i]);
                }
            }
            if (!wordExists)
            {
                foreach (var i in missingWords)
                {
                    //Console.WriteLine(i);
                }
            }

            return wordExists;
        }
    }

    public class Warnings
    {
        public bool incompleteResults
        {
            get; set;
        }
    }

    public class Software
    {
        public string software
        {
            get; set;
        }

        public string name
        {
            get; set;
        }

        public string version
        {
            get; set;
        }

        public string apiVersion
        {
            get; set;
        }

        public bool premium
        {
            get; set;
        }

        public string premiumHint
        {
            get; set;
        }

        public string status
        {
            get; set;
        }
    }

    /*    public class Matches
        {
            public string matches
            {
                get; set;
            }

            public string message
            {
                get; set;
            }

            public string shortMessage
            {
                get; set;
            }

            public string replacements
            {
                get; set;
            }

            public int offset
            {
                get; set;
            }

            public int length
            {
                get; set;
            }

            public string sentence
            {
                get; set;
            }*/
}