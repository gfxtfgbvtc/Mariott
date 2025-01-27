using System;
using System.Windows.Media;

public class MusicService
{
    private static MediaPlayer mediaPlayer;

    static MusicService()
    {
        mediaPlayer = new MediaPlayer();
        mediaPlayer.IsMuted = false;
        mediaPlayer.Volume = 0.2; // Уровень громкости
    }

    public static void PlayMusic(string musicFilePath)
    {
        if (mediaPlayer != null)
        {
            mediaPlayer.Open(new Uri(musicFilePath));
            mediaPlayer.Play();
        }
    }

    public static void PauseMusic()
    {
        if (mediaPlayer != null)
        {
            mediaPlayer.Pause();
        }
    }

    public static void ResumeMusic()
    {
        if (mediaPlayer != null)
        {
            mediaPlayer.Play();
        }
    }
    public static void StopMusic()
    {
        if (mediaPlayer != null)
        {
            mediaPlayer.Stop();
        }
    }

    public static void SetVolume(double volume)
    {
        mediaPlayer.Volume = volume;
    }
}
