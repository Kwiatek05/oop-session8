namespace Session7;

public class Program
{
    public static void Main()
    {
        MusicPlayer musicPlayer = new();
        Playlist playlistElectronic = new();
        Playlist playlistClassicRock = new();
        Song songElectronic = new("Dead Stars", "Covenant", "EBM", 336);
        Song songElectronic2 = new("I Stand Alone", "Covenant", "EBM", 430);
        Song songClassicRock = new("Dust in the wind", "Kansas", "Classic Rock", 600);

        playlistElectronic.Name = "Elelctronic PLaylist";
        playlistClassicRock.Name = "Classic Rock playlist";
        playlistElectronic.Songs.Add (songElectronic);
        playlistElectronic.Songs.Add (songElectronic2);
        playlistClassicRock.Songs.Add(songClassicRock);


        musicPlayer.Play(playlistElectronic);
        musicPlayer.Play(playlistElectronic);
        musicPlayer.Play(playlistClassicRock);
    }
}