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

namespace Mariott
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window1 window1 = new Window1();
			MainWindow mainWindow = new MainWindow();
			Close();
            window1.Show();

        }

        private void Image_MouseLeftButtonDown2(object sender, MouseButtonEventArgs e)
        {
            Window2 window2 = new Window2();
            MainWindow mainWindow = new MainWindow();
            Close();
            window2.Show();

        }
        private void Image_MouseLeftButtonDow3(object sender, MouseButtonEventArgs e)
        {
            Window3 window3 = new Window3();
            MainWindow mainWindow = new MainWindow();
            Close();
            window3.Show();

        }
        private void Image_MouseLeftButtonDown4(object sender, MouseButtonEventArgs e)
        {
            Window4 window4 = new Window4();
            MainWindow mainWindow = new MainWindow();
            Close();
            window4.Show();

        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            MusicService.PauseMusic();
        }

       
        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            MusicService.ResumeMusic();
        }
    }
}
