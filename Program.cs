using GTFS;
using GTFS.Entities;
using Snappy.OpenStreetMaps;
using Snappy.ValueObjects;
using System;
using System.Collections.Generic;

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

            var coords = new List<Coord>()
            {
                new Coord(-33.9078, 18.401886),
                new Coord(-33.907749, 18.404173)
            };
            var snapper = new OsmSnapper(Snappy.Enums.OverpassApi.KumiSystems);
            var snappedSections = snapper.SnapDat(coords);
            Console.WriteLine("Snapped Sections: " + snappedSections.Count);
            Console.ReadLine();
        }
    }
}
