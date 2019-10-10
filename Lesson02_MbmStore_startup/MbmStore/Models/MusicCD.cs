using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        // IEnumerable<MusicCD> musicCDs = new List<MusicCD>();

        protected List<Tracks> tracks = new List<Tracks>();
        public List<Tracks> Tracks
        {
            get
            {
                return tracks;
            }
        }

        public string Artist
        {
            get; set;
        }
        public string Label { get; set; }
        public short Released { get; set; }

        public string Publisher { get; set; }

        public MusicCD(int productID ,string title, string artist, short released, decimal price , string publisher) : base(productID ,title, price)

        {
            Artist = artist;
            Price = price;
            Title = title;
            Released = released;
            Publisher = publisher;

        }

        public void AddTrack(Tracks track)
        {
            tracks.Add(track);
        }
        public TimeSpan Getplaying()
        {
            TimeSpan sum = new TimeSpan(0, 0, 00);
            foreach (Tracks track in tracks)
            {
                sum += track.Lenght;
            }
            return sum;
        }




    }
}
