using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WayPoint_1stTry.Models;

namespace WayPoint_1stTry.ViewModels
{
    
    public class MainViewModel: ObservableRecipient
    {
        private Random gen = new Random();

        public ObservableCollection<Waypoint> FirstList { get; set; }
        public ObservableCollection<Waypoint> SecondsList { get; set; }
        public ObservableCollection<Hike> Hikes { get; set; }
        public ObservableCollection<Hike> ThirdList { get; set; }
        public Waypoint SelectedPoint1 { get => selectedPoint1; set { SetProperty(ref selectedPoint1, value); Add.NotifyCanExecuteChanged();Edit.NotifyCanExecuteChanged(); } }
        public Waypoint SelectedPoint2 { get => selectedPoint2; set { SetProperty(ref selectedPoint2, value); Delete.NotifyCanExecuteChanged();  } }

        private Waypoint selectedPoint1;
        private Waypoint selectedPoint2;
        private Hike selectedHike;
        public RelayCommand Add { get; set; }
        public RelayCommand Edit { get; set; }
        public RelayCommand Delete { get; set; }
        public RelayCommand Save { get; set; }
        public Hike SelectedHike { get => selectedHike; set { SetProperty(ref selectedHike, value); } }

        int hardCounter;

        public MainViewModel()
        {
            FirstList = new ObservableCollection<Waypoint>();
            SecondsList = new ObservableCollection<Waypoint>();
            Hikes = new ObservableCollection<Hike>();
            Read("waypoint.txt");

            Add = new RelayCommand(() =>
              {
                  if (selectedPoint1.Category == "hard")
                  {
                      hardCounter = 3;
                  }
                  else
                  {
                      hardCounter--;
                  }
                  SecondsList.Add(selectedPoint1);
                  Save.NotifyCanExecuteChanged();
              }, () =>
                  (selectedPoint1 != null && Category(selectedPoint1) == true));

            Edit = new RelayCommand(() =>
              {
                  if (selectedPoint1 == null)
                  {
                      FirstList.Add(new Waypoint());
                      EditWindow win = new EditWindow(FirstList[FirstList.Count - 1]);
                      win.ShowDialog();
                  }

                  else
                  {
                      EditWindow win = new EditWindow(selectedPoint1);
                      win.ShowDialog();
                  }
              });
            Delete = new RelayCommand(() =>
              {
                  SecondsList.Remove(selectedPoint2);
                  Save.NotifyCanExecuteChanged();
              }, () => selectedPoint2 != null);

            Save = new RelayCommand(() =>
              {
                  // SaveData(selectedPoint2,);
                  string[] difficulties = { "hard", "medium", "easy" };

                  Hikes.Add(new Hike
                  {
                      DateOfHike = RandmDate(),
                      ListOfPoints = SecondsList,
                      Difficulty = difficulties[gen.Next(0,3)]
                  }); ;
               //   SecondsList.Clear();

              }, () => SecondsList.Count != 0);
        }

        private void Read(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {
                string row = reader.ReadLine();
                string[] items = row.Split(',');
                FirstList.Add(new Waypoint()
                {
                    PointCode=items[0],
                    X=int.Parse(items[1]),
                    Y=int.Parse(items[2]),
                    Height=int.Parse(items[3]),
                    Category=items[4]
                });
            }
        }

       

        private DateTime RandmDate()
        {
            DateTime start=new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

        public bool Category(Waypoint point)
        {
            if(point.Category=="hard" && hardCounter>0)
            {
                return false;
            }
            return true;
        }


    }
    

}
