using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Mariott
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string musicFilePath = System.IO.Path.Combine(projectDirectory, "Videos", "music.mp3");
            MusicService.PlayMusic(musicFilePath);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            MusicService.StopMusic();
            base.OnExit(e);
        }

    }
}
