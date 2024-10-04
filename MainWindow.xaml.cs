using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
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

namespace GitTaak1
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

        private void HoverImage(object sender, MouseEventArgs e)
        {
            if (e.RoutedEvent == MouseEnterEvent) 
            {
                mainGrid.Background = new SolidColorBrush(Colors.Red); 
            }
            else
            {
                mainGrid.Background = new SolidColorBrush(Colors.LightGray);
            }
        }

        private void SelectedImage(object sender, MouseEventArgs e)
        {
            Image img = sender as Image;
            switch (img.Name)
            {
                case "imgRood":
                    txtCode.Text = "#FF0000";
                    txtInformatie.Text = "Rood is de kleur van warmte";
                    break;
                case "imgGroen":
                    txtCode.Text = "#008000";
                    txtInformatie.Text = "Groen is de kleur van genezing";
                    break;
                case "imgGeel":
                    txtCode.Text = "#FFFF00";
                    txtInformatie.Text = "Geel is de kleur van levenslust";
                    break;
                case "imgBlauw":
                    txtCode.Text = "#0000FF";
                    txtInformatie.Text = "Blauw is de kleur van intelligentie";
                    break;
            }
        }
    }
}
