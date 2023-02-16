using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Date.SelectedDate = DateTime.Now;

            ShowName();

            Work WorkUsing = new Work();
            List<List<Zametka>> allzametki = WorkUsing.Read();
        }

        private void CreateName(object sender, RoutedEventArgs e)
        {
            Zametka Z = new Zametka();
            Z.Name = Name.Text;
            Z.Opis = Opis.Text;
            Z.Data = (DateTime)Date.SelectedDate;

            List<Zametka> zametki = new List<Zametka>();
            zametki.Add(Z);
            Work WorkUsing = new Work();
            WorkUsing.Create(zametki);
        }

        public void ShowName()
        {
            int d = 2;

            Work WorkUsing = new Work();
            List<List<Zametka>> allzametki = WorkUsing.Read();

            List<string> ZamDay = new List<string>();

            foreach (List<Zametka> item in allzametki)
            {
                int n = d - 2;
                if (Date.SelectedDate == item[d].Data)
                {
                    ZamDay.Add(item[n].Name);
                }
            }

            Lis.ItemsSource = ZamDay;
        }
    }
}
