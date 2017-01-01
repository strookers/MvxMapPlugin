using System.Collections.Generic;
using MvvmCross.Core.ViewModels;
using MvxMapPlugin;
using MvxMapPlugin.Models;

namespace SampleMvxMapPlugin.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private readonly IMvxMap _mvxMap;

        public FirstViewModel(IMvxMap mvxMap)
        {
            _mvxMap = mvxMap;
            _mvxMap.Test("dette virker");
            //List<LatLngNew> list = new List<LatLngNew>();
            //list.Add(new LatLngNew(57.12804, 9.81766));
            //list.Add(new LatLngNew(56.95621, 9.8204));
            //list.Add(new LatLngNew(56.93898, 10.16098));
            //_mvxMap.MakePolyline(list);
        }

        //private string _hello = "Hello MvvmCross";
        //public string Hello
        //{ 
        //    get { return _hello; }
        //    set { SetProperty (ref _hello, value); }
        //}
        

    }
}
