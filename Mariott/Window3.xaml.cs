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

namespace Mariott
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void returnonmain(object sender, RoutedEventArgs e)
        {
            Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            // Пауза музыки через глобальный сервис
            MusicService.PauseMusic();
        }

        // Обработчик для кнопки Resume (если нужно возобновить музыку)
        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            // Продолжение воспроизведения музыки через глобальный сервис
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
                // Показать уведомление об успешном бронировании
                MessageBox.Show("Вы успешно забронировали номер", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);

                // Закрыть текущее окно
                this.Close();

                // Открыть главное окно
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
        }
    }
}
