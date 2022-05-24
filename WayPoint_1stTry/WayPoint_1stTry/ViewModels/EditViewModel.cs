using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WayPoint_1stTry.Models;

namespace WayPoint_1stTry.ViewModels
{
    public class EditViewModel
    {
        public Waypoint MyWaypoint { get; set; }
        public ObservableCollection<string> Categories { get; set; }
        public void Setup(Waypoint point)
        {
            MyWaypoint = point;
            Categories.Add("medium");
            Categories.Add("hard");
            Categories.Add("easy");
        }
        public EditViewModel()
        {
            Categories = new ObservableCollection<string>();
        }
    }
}
