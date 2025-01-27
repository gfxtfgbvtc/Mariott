using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;  

namespace Mariott
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

           
            MediaElement mediaElement = FindName("MediaElement") as MediaElement;
            mediaElement?.Play();

        }

        private void returnonmain(object sender, RoutedEventArgs e)
        {
            Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void PhoneTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Обработка изменений текста в TextBox
        }

        
        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            
            MusicService.PauseMusic();
        }

        
        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
           
            MusicService.ResumeMusic();
        }
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PhoneTextBox.Text) || string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                
                MessageBox.Show("Вы успешно забронировали номер", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);

               
                this.Close();

               
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
        }
    }
}
