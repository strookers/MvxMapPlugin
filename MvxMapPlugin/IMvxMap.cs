using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvxMapPlugin.Models;

namespace MvxMapPlugin
{
    public interface IMvxMap
    {
        void UpdateCameraPosition(LatLngNew pos);

        void MarkOnMap(string title, LatLngNew pos, string metaText);

        void MakePolyline(List<LatLngNew> locations);

        void Test(string test);
    }
}
