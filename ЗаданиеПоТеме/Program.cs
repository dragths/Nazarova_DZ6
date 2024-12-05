using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗаданиеПоТеме
{
    internal class Program
    {
        static void task1()
        {
            /*Тема "Популярная музыка"*/
            PopSong popSong = new PopSong("Blinding Lights", "The Weeknd", 3.20, 2020, "880 млн просмотров");
            RockSong rockSong = new RockSong("I was made for lovin' you", "KISS", 72.35, " Alive! ");
            Naslednik3 kpopSong = new Naslednik3("Dynamite", "BTS", 3.44, 2020, "1,8 млрд просмотров");

            Playlist playlist = new Playlist();
            playlist.AddSong(popSong);
            playlist.AddSong(rockSong);
            playlist.AddSong(kpopSong);

            playlist.PlayAll();

            popSong.DisplayInfo();
            rockSong.DisplayInfo();
            kpopSong.DisplayInfo();
        }

        public static void Main(string[] args)
        {
            task1();
        }
    }
}
