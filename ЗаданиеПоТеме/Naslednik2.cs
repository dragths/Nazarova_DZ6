using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗаданиеПоТеме
{
    public class RockSong : Song
    {
        private string album;

        public RockSong(string title, string artist, double duration, string album)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
            this.genre = "Rock";
            this.album = album;
        }

        public RockSong(string title, string artist)
        {
            this.title = title;
            this.artist = artist;
            this.genre = "Rock";
        }

        public override void Play()
        {
            Console.WriteLine($"Играет рок-песня: {title} исполнителя {artist} из альбома {album}");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Рок-песня: {title}, Исполнитель: {artist}, Жанр: {genre}, " +
                              $"Продолжительность: {duration} минут, Альбом: {album}");
        }
    }
}
