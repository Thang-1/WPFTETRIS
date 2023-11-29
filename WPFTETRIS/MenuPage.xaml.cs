using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace WPFTETRIS
{
    /// <summary>
    /// MenuPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();            
        }

        private void btn1_click(object sender, RoutedEventArgs e) //1인용
        {
            //player.NavigationService.Navigate(new Uri("/singlePlay.xaml", UriKind.Relative));
            player.Navigate(new SinglePlay());
        }

        private void btn2_click(object sender, RoutedEventArgs e) //2인용
        {
            //player.NavigationService.Navigate(new Uri("/MutiPlay.xaml", UriKind.Relative));
            player.Navigate(new MutiPlay());
        }

        private void btn3_click(object sender, RoutedEventArgs e) //AI
        {
            //player.NavigationService.Navigate(new Uri("/AI.xaml", UriKind.Relative));
            player.Navigate(new AI());
        }
    }
}
