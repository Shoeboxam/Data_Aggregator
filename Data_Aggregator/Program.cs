﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

namespace Data_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize information source
            Network.Connect web = new Network.Connect();

            while (true)
            {
                //Data entry
                System.Console.WriteLine("Search: ");
                String query = Console.ReadLine();

                //Retrieve data
                Database_Listing response = web.Search(query);

                foreach (dynamic database in response.result.results)
                {
                    System.Console.WriteLine(database.name);
                }
                System.Console.WriteLine("\n");
            }
        }
    }
}
