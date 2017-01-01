using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvxMapPlugin.Models
{
    public class LatLngNew
    {
        public double lat { get; set; }

        public double lng { get; set; }

        public LatLngNew(double lat, double lng)
        {
            this.lat = lat;
            this.lng = lng;
        }
    }
}
