using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;


namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        public RonVSKanyeAPI()
        {
        }

        public static void KanyeQuote()
        {
            var client = new HttpClient();

            //kanye API Url
            var kanyeURL = "https://api.kanye.rest";

            //JSON repsonse stored in a variable
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            //Parses object
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"\"{kanyeQuote}\"\n");
        }

        public static void RonQuote()
        {
            var client = new HttpClient();

            //Ron Swanson API URL
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            //JSON repsonse stored in a variable
            var ronResponse = client.GetStringAsync(ronURL).Result;

            //Parses object
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine(ronQuote);
        }
    }
}
