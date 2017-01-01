using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvxMapPlugin.Models;

namespace MvxMapPlugin
{
    public abstract class BaseMvxMap : IMvxMap
    {
        protected abstract void NativeMakePolyline(List<LatLngNew> locations);

        public void UpdateCameraPosition(LatLngNew pos)
        {
            throw new NotImplementedException();
        }

        public void MarkOnMap(string title, LatLngNew pos, string metaText)
        {
            throw new NotImplementedException();
        }

        public void MakePolyline(List<LatLngNew> locations)
        {
            NativeMakePolyline(locations);
        }

        public void Test(string test)
        {
            throw new NotImplementedException();
        }
    }
}
