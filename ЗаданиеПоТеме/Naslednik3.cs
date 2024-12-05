using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗаданиеПоТеме
{
    public class Naslednik3 : Song
    {
        private int releaseYear;

        public Naslednik3(string title, string artist, double duration, int releaseYear, string prosmotrs)
        {
            this.title = title;
            this.artist = artist;
            this.duration = duration;
            this.genre = "K-Pop";
            this.releaseYear = releaseYear;
            this.prosmotrs = prosmotrs;
        }

        public Naslednik3(string title, string artist)
        {
            this.title = title;
            this.artist = artist;
            this.genre = "K-Pop";
        }

        public override void Play()
        {
            Console.WriteLine($"Играет к-поп песня: {title} исполнителя {artist}");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"К-поп песня: {title}, Исполнитель: {artist}, Жанр: {genre}, " +
                              $"Продолжительность: {duration} минут, Год выпуска: {releaseYear},Просмотры клипа на YouTube: {prosmotrs}");
        }
    }
}
