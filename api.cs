using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;
using Microsoft.Office.Interop.Word;
using API_Connect;
using System.Net.Http;
using System.Net.Http.Headers;
using RestSharp;

namespace Example
{
    public class API_Connection
    {
        private object openFileDialog;

        public static void Main(String[] args)
        {
         
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.prowritingaid.com");
            client.DefaultRequestHeaders
                  .Accept
                  .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            API_Connection connect = new API_Connection();
            connect.checkStyle("He is a goud freind");

        }

        public static String getFilePath(String filepath)
        {
            return filepath;
        }

        public void checkStyle(String filePath)
        {

         


            // string text = File.ReadAllText(filePath);
            string text = filePath;
            try
            {


                var api = new TextAsyncApi()
                      .SetLicenseCode("602291EB-F47B-4B09-A0B5-F7969EB7880E");
                var request = new TextAnalysisRequest(
                   text,
                    new List<string> { "grammar" },
                    TextAnalysisRequest.StyleEnum.General,
                    TextAnalysisRequest.LanguageEnum.En);
                //var api2 = new ContextualThesaurusAsyncApi();
             
                var response = api.Post(request);
                Debug.WriteLine(response);
               
               
            }
            catch(Exception e2)
            {
                Debug.Print(e2.Message);
                Debug.Print("Exception when calling TextApi.TextPost: " + e2.Message);
            }

           
        }



    }

}
