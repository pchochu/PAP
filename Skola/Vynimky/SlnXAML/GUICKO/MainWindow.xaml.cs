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
using System.Windows.Navigation;
using System.Windows.Shapes;
using xamlSkusam;

namespace GUICKO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        RezervacniSystem r = new RezervacniSystem();
        private void Pridaj_Click(object sender, RoutedEventArgs e)
        {
            if(meno.Text.Equals(""))
            {
                MessageBox.Show("Vypln meno");
            } else if (priezvisko.Text.Equals(""))
            {
                MessageBox.Show("Vypln priezvisko");
            }
            else if(calendar.SelectedDate.Value == null)
            {
                MessageBox.Show("Vypln datum");
            }
            {

                ListBoxItem item = new ListBoxItem();
                item.Content = String.Format("{0} {1} {2}", meno.Text, priezvisko.Text, calendar.SelectedDate);
                list.Items.Add(item);
                r.AddStudentDic(meno.Text.Trim(), priezvisko.Text.Trim());
                r.AddStudentList(meno.Text.Trim(), priezvisko.Text.Trim());

            }
        }

        private void vytlac_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
