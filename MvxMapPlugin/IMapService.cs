using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvxMapPlugin
{
    public interface IMapService
    {
        bool UpdateCameraPosition();

        bool MarkOnMap();

        bool MakePolyline();
    }
}
