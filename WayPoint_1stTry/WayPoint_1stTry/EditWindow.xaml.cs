using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WayPoint_1stTry.Models;
using WayPoint_1stTry.ViewModels;

namespace WayPoint_1stTry
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public EditWindow(Waypoint point)
        {
            InitializeComponent();
            EditViewModel vm = new EditViewModel();
            vm.Setup(point);
            this.DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool first = pointbox.Text.Any(x=>!char.IsUpper(x));
            bool second= pointbox.Text.Any(x => !char.IsDigit(x));
             if ( second)
            {
                MessageBox.Show("The code is wrong format, please fix it");
            }
            //else if(first)
            //{
            //    MessageBox.Show("The code is wrong format, please fix it");
            //}
             else
            {
                foreach (var item in stackpanel.Children)
                {
                    if (item is TextBox t)
                    {
                        t.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                    }
                }
                this.DialogResult = true;
            }
        }
    }
}
