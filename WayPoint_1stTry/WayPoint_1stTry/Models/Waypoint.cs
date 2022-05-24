using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WayPoint_1stTry.Models
{
    public class Waypoint: ObservableObject
    {
        private string pointCode;
        private int x;
        private int y;
        private int height;
        private string category;

        public string PointCode { get => pointCode; set { SetProperty(ref pointCode, value); } }
        public int X { get => x; set { SetProperty(ref x, value); } }
        public int Y { get => y; set { SetProperty(ref y, value); } }
        public int Height { get => height; set { SetProperty(ref height, value); } }
        public string Category { get => category; set { SetProperty(ref category, value); } }
    }
}
