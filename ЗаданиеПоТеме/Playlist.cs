using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗаданиеПоТеме
{
    public class Playlist
    {
        private List<Song> songs;

        public Playlist()
        {
            songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public void PlayAll()
        {
            foreach (var song in songs)
            {
                song.Play();
            }
        }
    }

}
