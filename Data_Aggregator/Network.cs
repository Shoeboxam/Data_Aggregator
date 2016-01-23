using System;
using System.Net;
using System.IO;

using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Network
{
    class Connect
    {
        WebClient client = new WebClient();

        public String Download(string url)
        {
            string path = @"C:\Users\mike_000\Desktop\index.json";
            client.DownloadFile(url, path);

            return new StreamReader(path).ReadToEnd();
        }

        public Data_Aggregator.Database_Listing Search(string term)
        {
            string url = @"http://catalog.data.gov/api/3/action/package_search?q='" + term + "'";
            string text = client.DownloadString(url);
            return JsonConvert.DeserializeObject<Data_Aggregator.Database_Listing>(text);
        }
    }
}
