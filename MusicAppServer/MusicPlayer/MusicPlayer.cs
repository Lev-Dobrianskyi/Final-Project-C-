using NAudio.Wave;
using System;
using System.IO;

namespace MusicAppServer.MusicPlayer;

public class MusicPlayer : IDisposable
{
    public WaveOutEvent? outputDevice { get; private set; }

    public WaveStream? audioFile { get; set; }


    public void Load(string filePath)
    {
        DisposePlayer();

        if (!File.Exists(filePath))
            throw new FileNotFoundException("Song file not found.", filePath);

        audioFile = new AudioFileReader(filePath);

        outputDevice = new WaveOutEvent();
        outputDevice.Init(audioFile);
    }
    public void Load(Stream audioStream)
    {
        DisposePlayer();

        var memoryStream = new MemoryStream();
        audioStream.CopyTo(memoryStream);
        memoryStream.Position = 0;

        audioFile = new Mp3FileReader(memoryStream);

        outputDevice = new WaveOutEvent();
        outputDevice.Init(audioFile);
    }

    public void ResetAudioFile()
    {
        audioFile?.Dispose();
        audioFile = null;
    }

    public void Play()
    {
        outputDevice?.Play();
    }

    public void Pause()
    {
        outputDevice?.Pause();
    }

    public void Stop()
    {
        if (outputDevice == null || audioFile == null)
            return;

        outputDevice.Stop();
        audioFile.CurrentTime = TimeSpan.Zero;
    }

    public void Seek(double seconds)
    {
        if (audioFile == null)
            return;

        audioFile.CurrentTime = TimeSpan.FromSeconds(seconds);
    }

    public int GetCurrentTimeOfMusic()
    {
        if (audioFile == null)
            return 0;
        TimeSpan currentTime = audioFile.CurrentTime;
        return (int)currentTime.TotalSeconds;
    }

    public int GetAllTimeOfMusic()
    {
        if (audioFile == null)
            return 0;
        TimeSpan totalTime = audioFile.TotalTime;
        return (int)totalTime.TotalSeconds;
    }

    public double CurrentTime
    {
        get
        {
            if (audioFile == null)
                return 0;

            return audioFile.CurrentTime.TotalSeconds;
        }
    }

    public double Duration
    {
        get
        {
            if (audioFile == null)
                return 0;

            return audioFile.TotalTime.TotalSeconds;
        }
    }

    public float Volume
    {
        get
        {
            if (audioFile is AudioFileReader localFile)
            {
                return localFile.Volume;
            }
            return outputDevice?.Volume ?? 1f;
        }
        set
        {
            if (audioFile is AudioFileReader localFile)
            {
                localFile.Volume = value;
            }
            else if (outputDevice != null)
            {
                outputDevice.Volume = value;
            }
        }
    }

    private void DisposePlayer()
    {
        outputDevice?.Dispose();
        audioFile?.Dispose();

        outputDevice = null;
        audioFile = null;
    }

    public void Dispose()
    {
        DisposePlayer();
    }
}