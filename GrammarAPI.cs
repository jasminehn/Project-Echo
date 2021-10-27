using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.Logging;
using System.Net.Http.Headers;
using System.Net.Http;
using RestSharp;
//using System.Reflection.Metadata;
using System.IO;
using System.IO.Compression;
using System.Xml;
using System.Diagnostics;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace ProjectEcho
{
    public class GrammarAPI
    {

        public static async Task CallAPI()
        {

            var first = "";
            var second = " ";
            string mytext = OpenWordprocessingDocumentReadonly("C:\\Users\\365ye\\OneDrive\\Desktop\\TestDoc1.docx");
            Console.WriteLine("****" + mytext);
            var words = mytext.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int len = mytext.Length;
            int subLen = len - 10000;
            Console.WriteLine("len " + len + " sublen " + subLen);

            if (len > 10000)
            {
                first = mytext.Substring(0, 10000);
                second = mytext.Substring(10000, subLen);

                Console.WriteLine("first " + first + " second" + second);
            }

            try
            {
                await GrammarCheck(mytext).ConfigureAwait(false);
                if (mytext.Length > 10000)
                {
                    await GrammarCheck(second).ConfigureAwait(false);
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }

            //  len 11542 sublen 1542


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
                string s = getReport(body);
                Console.WriteLine(s);
                //Console.WriteLine(body);
            }

        }
        //Converts docx files to string
        public static string OpenWordprocessingDocumentReadonly(string filepath)
        {

            // Uses the filepath to open a Word Document
            using (WordprocessingDocument wordDocument =
                WordprocessingDocument.Open(filepath, false))
            {

                Body body = wordDocument.MainDocumentPart.Document.Body;

                string s = body.InnerText.ToString();

                return body.InnerText.ToString();
            }

            //return "1";
        }

        //This method will clean up the JSON file so that the report is user friendly
        public static string getReport(string text)
        {

            // string docText = "words.. words.. match: spell check";
            string cutString = text.Split(new string[] { "matches" }, StringSplitOptions.None).Last();


            //  Console.WriteLine("Old string " + text);
            Console.WriteLine("New string " + cutString);
            return cutString;


        }

    }
}
