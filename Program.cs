using GTFS;
using GTFS.Entities;
using System;

namespace BeastTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var feed = new GTFS.GTFSFeed();
            feed.Agencies.Add(new Agency());

            Console.WriteLine(feed.Agencies.Count);
        }
    }
}
