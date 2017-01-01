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
        void UpdateCameraPosition();

        void MarkOnMap();

        void MakePolyline(List<LatLngNew> locations);
    }
}
