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
    public class API
    {
        
        /*
        //example of how to call the API
        public static async Task Main(string[] args)
        {
            
            Console.WriteLine("YEET");
            string mytext = OpenWordprocessingDocumentReadonly(@"TestDoc.docx");
            Console.WriteLine("****" + mytext);
            

            try
            {
                await GrammarCheck(mytext).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }

            

        }*/

        public static async Task CallAPI()
        {
            Console.WriteLine("YEET");
            string mytext = OpenWordprocessingDocumentReadonly("C:\\Users\\365ye\\OneDrive\\Desktop\\TestDoc1.docx");
            Console.WriteLine("****" + mytext);

            
            try
            {
                await GrammarCheck(mytext).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }
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
                    Console.WriteLine(body);
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

                    return body.InnerText.ToString();
                }
                return "-1";
            }

            //This method will clean up the JSON file so that the report is user friendly
            public string GenerateNewReport()
            {

                return "1";
            }


        }

    
}
