using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Text.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using Json.Net;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using System.Data.Common;
using System.Collections;


namespace ProjectEcho
{
    public class GrammarAPI
    {
        public static String pog = "";
        public static String idk = "it dont work";

        public static async Task CallAPI(String filePath)
        {

            GrammarAPI api = new GrammarAPI();
            var first = "";
            var second = " ";
            var third = " ";
            string mytext = OpenWordprocessingDocumentReadonly(filePath);
            api.glossaryCheck(mytext);
            Console.WriteLine("****" + mytext);
            var words = mytext.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
            int len = mytext.Length;
            int subLen;

            if (len > 20000)
            {
                subLen = len - 20000;
                first = mytext.Substring(0, 10000);
                second = mytext.Substring(10000, 10000);
                third = mytext.Substring(20000, subLen);
                Console.WriteLine("first " + first);
                Console.WriteLine(" second " + second);
                Console.WriteLine(" third " + third);
            }
            else if (len > 10000)
            {
                subLen = len - 10000;
                first = mytext.Substring(0, 10000);
                second = mytext.Substring(10000, subLen);
                Console.WriteLine("first " + first + " second" + second);
            }

            try
            {
                await GrammarCheck(first).ConfigureAwait(false);
                if (mytext.Length > 10000)
                {
                    await GrammarCheck(second).ConfigureAwait(false);
                    if (mytext.Length > 20000)
                    {
                        Console.WriteLine("*** over 20,000 characters");

                        await GrammarCheck(third).ConfigureAwait(false);

                    }
                }

            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }

        }


        public static String ReturnReport(String path)
        {

            CallAPI(path);

            return pog;
        }

        //takes a path and returns the output of the grammar api; used for calling the API in other classes
        public static string yeet(string path)
        {
            CallAPI(path);

            return idk;
        }

        
        public static async Task GrammarCheck(string text)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://grammarbot.p.rapidapi.com/check"),
                Headers =
    {
        { "x-rapidapi-host", "grammarbot.p.rapidapi.com" },
        { "x-rapidapi-key", "e844609f92msha17811bf70a2da7p1ba5b1jsndb8101bcd3e5" },
    },
                Content = new FormUrlEncodedContent(new Dictionary<string, string>
    {
        { "text", text }, //the text variable is the string that was converted from the docx file
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
                    grammarReport = "Sentence: " + i.sentence + "\n Message: " + i.message + " Offset: " + i.offset.ToString() + "\n Replacements: " + i.replacements + "\n";
                    reportList.Add(grammarReport);
                }
                
                for (int i = 0; i < reportList.Count; i++)
                {
                    reportList[i] = reportList[i].Replace("[", "");
                    reportList[i] = reportList[i].Replace("]", "");
                    reportList[i] = reportList[i].Replace("{", "");
                    reportList[i] = reportList[i].Replace("}", "");

                }
                
                Console.WriteLine(string.Join(" ", reportList));
                //idk = string.Join(" ", reportList); //only gets the last report bc it's overwritten each time GrammarCheck is called :(
                
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
            string offSetVals = " ";


            // Console.WriteLine("Old string " + text);
            // Console.WriteLine("New string " + cutString);
            return cutString;

        }

        /*
        public static List<string> ReturnReport(List<string> report)
        {

            return report;
        }
        */

        public bool glossaryCheck(string documentString)
        {

            string[] glossary = {"academic language","active nature of young children's learning:","aligned",
                   "artifacts:","assessment","personal assets","cultural assets","community assets",
                   "central focus","commentary","engaging children in learning","evaluation criteria",
                    "evidence","interdisciplinary","learning environment","learning experience",
                    "learning objectives", "multimodal nature of young children's learning",
                    "patterns of learning", "planned supports","prior academic learning and prerequisite skills",
                    "rapport","respect","rubrics","variety of learners","whole child"};
            List<string> missingWrods = new List<string>();
            string word = "";
            bool wordExists = true;


            for (int i = 0; i < glossary.Length; i++)
            {
                if (documentString.Contains(glossary[i]))
                {

                    Console.WriteLine("Found word");
                }
                else
                {
                    word = glossary[i];
                    missingWrods.Add(word);
                    wordExists = false;


                }

            }
            if (!wordExists)
            {
                foreach (var i in missingWrods)
                {
                    Console.WriteLine(i);
                }

            }
            
            return wordExists;

        }


    }
    public class Warnings
    {
        public bool incompleteResults { get; set; }
    }

    public class Software
    {

        public string software { get; set; }
        public string name { get; set; }
        public string version { get; set; }
        public string apiVersion { get; set; }
        public bool premium { get; set; }
        public string premiumHint { get; set; }
        public string status { get; set; }


    }

    public class Matches
    {
        public string matches { get; set; }
        public string message { get; set; }
        public string shortMessage { get; set; }
        public string replacements { get; set; }
        public int offset { get; set; }
        public int length { get; set; }
        public string sentence { get; set; }

    }

}
