using System;
using System.Collections.Generic;
using System.Linq;


namespace Data_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize information source
            Network.Connect web = new Network.Connect();

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            List<String> data_formats = new List<string> { "CSV", "Excel", "ZIP", "RAR", "JSON", "XML" };

            while (true)
            {
                //Data entry
                System.Console.Write("Search: ");
                String query = Console.ReadLine();

                //Retrieve data
                Database_Listing response = web.Search(query);

                //Print out returned databases
                int position = 1;
                foreach (dynamic database in response.result.results)
                {
                    System.Console.WriteLine(position.ToString() + ": " + database.name);
                    position++;
                }
                System.Console.Write("Select database: ");
                
                string selection_string = Console.ReadLine();

                //Interpret selection as corresponding integer
                int selection;
                if (Int32.TryParse(selection_string, out selection))
                {
                    string resource_name = response.result.results[selection].name;

                    if (selection < response.result.results.Count())
                    {
                        foreach (Resources resource in response.result.results[selection].resources)
                        {

                            if (data_formats.Any(resource.format.Contains))
                            {
                                System.Console.WriteLine("Downloading " + resource.format + ": " + resource.name);

                                Uri resource_uri = new Uri(resource.url);
                                string filename = System.IO.Path.GetFileName(resource_uri.LocalPath);

                                web.Download(resource.url, path + "\\" + resource_name + "\\" + filename);
                            }
                            else
                            {
                                System.Console.WriteLine(resource.format);
                            }
                        }
                    }
                }

                
            }
        }
    }
}
