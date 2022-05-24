using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WayPoint_1stTry.Models
{
    public class Hike :ObservableObject
    {
        private DateTime dateOfHike;
        private IList<Waypoint> listOfPoints;
        private string difficulty;

        public DateTime DateOfHike { get => dateOfHike; set {
                SetProperty(ref dateOfHike, value);
            } }
        public IList<Waypoint> ListOfPoints { get => listOfPoints; set {
                SetProperty(ref listOfPoints, value);
            } }
        public string Difficulty { get => difficulty; set {
                SetProperty(ref difficulty, value);
            } }
    }
}
