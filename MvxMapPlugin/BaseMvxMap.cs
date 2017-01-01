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

        public void MakePolyline(List<LatLngNew> locations)
        {
            NativeMakePolyline(locations);
        }

        public void MarkOnMap()
        {
            throw new NotImplementedException();
        }

        public void UpdateCameraPosition()
        {
            throw new NotImplementedException();
        }
    }
}
