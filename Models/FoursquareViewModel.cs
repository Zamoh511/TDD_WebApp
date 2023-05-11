using Foursquare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TDD_WebApp.Models
{
    public class FoursquareViewModel
    {
    }

    public  class FoursquareLocationVM
    {
        
        public double Lat { get; set; }
        public double Lng { get; set; }
        public double Accuracy { get; set; }
        public double Heading { get; set; }
        public double Speed { get; set; }
        public long Timestamp { get; set; }
        public LocationSource Source { get; set; }

        
    }
}