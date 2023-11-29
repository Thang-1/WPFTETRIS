using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace WPFTETRIS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            KeyDown += AnyKeyPressed; //MainWindow에 Keydown 이벤트 핸들러 
        }

        private void AnyKeyPressed(object sender, KeyEventArgs e)
        {
            //MoveToMenuPage
            MenuPage menuPage = new MenuPage();
            menuPage.Title = "Menu";
            this.Content = menuPage;
        }
    }
}
