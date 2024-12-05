using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗаданиеПоТеме
{
    using System;
    using System.Collections.Generic;

   
    public abstract class Song
    {
        protected string title;
        protected string artist;
        protected string genre;
        protected double duration;
        protected string prosmotrs;

        public abstract void Play();
        public abstract void DisplayInfo();

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        public string Genre
        {
            get { return genre; }
        }

        public double Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public string Prosmotrs
        {
            get { return prosmotrs; }
            set { prosmotrs = value; }
        }
    }
}

