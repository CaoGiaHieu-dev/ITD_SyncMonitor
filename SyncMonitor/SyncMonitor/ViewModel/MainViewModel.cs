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
        public ICommand update { get; set; }
        public ICommand delete { get; set; }
        private ObservableCollection<bang2> list;
        public ObservableCollection<bang2> list_b2 { get => list; set { list = value; OnPropertyChanged(); } }

        public string _name_lane;
        public string name_lane { get => _name_lane; set { _name_lane = value; OnPropertyChanged(); } }

        public string _ip_lane;
        public string ip_lane { get => _ip_lane; set { _ip_lane = value; OnPropertyChanged(); } }

        public string _lanecode_lend;
        public string lanecode_lend { get => _lanecode_lend; set { _lanecode_lend = value; OnPropertyChanged(); } }

        public string _matram;
        public string matram { get => _matram; set { _matram = value; OnPropertyChanged(); } }
        public void cleartext()
        {
            name_lane = "";
            ip_lane = "";
            lanecode_lend = "";
        }
        public void showlist()
        {
            list_b2 = new ObservableCollection<bang2>();
            list_b2.Clear();
            var o = DataProvider.Ins.DB.LS_Lane;
            foreach (var i in o)
            {
                bang2 b = new bang2();
                b.name = i.Name;
                b.IpAddress = i.LaneCode;
                b.LanetoServerState = i.IpAcdress;
                b.SevertoLaneState = i.LastTimeOnline.ToString();
                list_b2.Add(b);
            }
        }
        public MainViewModel()
        {
            DateTime d = DateTime.Now;
            showlist();
            add = new RelayCommand<object>((p) => {
                return true;
            }, (p) => {
                var ad = new LS_Lane() { LaneCode = lanecode_lend, Name = name_lane, StationCode = matram, IpAcdress = ip_lane, LastTimeOnline = d, IsUsed = true };
                DataProvider.Ins.DB.LS_Lane.Add(ad);
                DataProvider.Ins.DB.SaveChanges();
                cleartext();
                showlist();
            });

            update = new RelayCommand<object>((p) => {
                return true;
            }, (p) => {
                var up = DataProvider.Ins.DB.LS_Lane.Where(x => x.LaneCode == lanecode_lend).SingleOrDefault();
                up.Name = name_lane;
                up.StationCode = matram;
                up.IpAcdress = ip_lane;
                up.LastTimeOnline = d;
                up.IsUsed = true;
                DataProvider.Ins.DB.SaveChanges();
                cleartext();
                showlist();
            });

            delete = new RelayCommand<object>((p) => {
                return true;
            }, (p) => {
                var xoa = DataProvider.Ins.DB.LS_Lane.Where(x => x.LaneCode == lanecode_lend).SingleOrDefault();
                DataProvider.Ins.DB.LS_Lane.Remove(xoa);
                DataProvider.Ins.DB.SaveChanges();
                cleartext();
                showlist();
            });
        }
    }
}
