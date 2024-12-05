using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗаданиеПоТеме
{
    public class PopSong : Song
    {
        private int releaseYear;

        public PopSong(string title, string artist, double duration, int releaseYear,string prosmotrs)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
            this.genre = "Pop";
            this.releaseYear = releaseYear;
            this.prosmotrs= prosmotrs;
        }

        public PopSong(string title, string artist)
        {
            this.title = title;
            this.artist = artist;
            this.genre = "Pop";
        }

        public override void Play()
        {
            Console.WriteLine($"Играет поп-песня: {title} исполнителя {artist}");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Поп-песня: {title}, Исполнитель: {artist}, Жанр: {genre}, " +
                              $"Продолжительность: {duration} минут, Год выпуска: {releaseYear},Просмотри клипа на YouTube: {prosmotrs}");
        }
    }

}
