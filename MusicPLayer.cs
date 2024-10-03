namespace Session7;

public class MusicPlayer
{
    public void Play(Playlist playlist)
    {
        Song song = playlist.Songs[playlist.CurrentSongIndex++];
        Console.WriteLine($"{playlist.Name} is playing: {song.Artist} - {song.Title}: {song.Duration}");
    }

    public void Play(Song song)
    {
        Console.WriteLine("Song is playing");
    }
}