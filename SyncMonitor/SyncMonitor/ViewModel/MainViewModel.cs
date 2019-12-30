using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Windows;
using SyncMonitor.Model;
namespace SyncMonitor.ViewModel
{
   public class MainViewModel: BaseViewModel
    {
        public ICommand add { get; set; }
        private ObservableCollection<bang2> list;
        public ObservableCollection<bang2> list_b2 { get => list; set { list = value; OnPropertyChanged(); } }

        public string _name_lane;
        public string name_lane { get => _name_lane; set { _name_lane = value;OnPropertyChanged(); } }

        public string _ip_lane;
        public string ip_lane { get => _name_lane; set { _ip_lane = value; OnPropertyChanged(); } }

        public string _lanecode_lend;
        public string lanecode_lend { get => _lanecode_lend; set { _lanecode_lend = value; OnPropertyChanged(); } }
        public MainViewModel()
        {
            list_b2 = new ObservableCollection<bang2>();
            var o = DataProvider.Ins.DB.LS_Lane;
            foreach(var i in o)
            {
                bang2 b = new bang2();
                b.name = i.Name;
                b.IpAddress = i.LaneCode;
                b.LanetoServerState = i.IpAcdress;
                b.SevertoLaneState = i.LastTimeOnline.ToString();
                list_b2.Add(b);
            }
            add = new RelayCommand<object>((p) => { return true; }, (p) =>
               {
                   //var add = new LS_Lane() { LaneCode=lanecode_lend,Name=name_lane,StationCode="1760"}


               });

        }
    }
}
