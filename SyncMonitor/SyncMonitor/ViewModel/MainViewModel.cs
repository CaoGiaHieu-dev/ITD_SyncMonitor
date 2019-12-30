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
        private ObservableCollection<bang2> list;
        public ObservableCollection<bang2> list_b2 { get => list; set { list = value; OnPropertyChanged(); } }
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

        }
    }
}
