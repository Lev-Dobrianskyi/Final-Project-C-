using NAudio.Wave;

namespace MusicAppServer.MusicPlayer;

public class MusicPlayer : IDisposable
{
    public WaveOutEvent? outputDevice {  get; private set; }
    public AudioFileReader? audioFile { get; private set; }

    public void Load(string filePath)
    {
        DisposePlayer();

        if (!File.Exists(filePath))
            throw new FileNotFoundException("Song file not found.", filePath);

        audioFile = new AudioFileReader(filePath);

        outputDevice = new WaveOutEvent();
        outputDevice.Init(audioFile);
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
            return audioFile?.Volume ?? 0;
        }
        set
        {
            if (audioFile != null)
                audioFile.Volume = value;
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