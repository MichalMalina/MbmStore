

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;

namespace MbmStore.Models
{
    public class Tracks : List<Track>
    {
        protected string title;
        protected string composer;
        protected TimeSpan lenght;
        public string Title { get { return title; } set { title = value; } }
        public string Composer { get { return composer; } set { composer = value; } }

        public TimeSpan Lenght { get { return lenght; } set { lenght = value; } }

        public Tracks(string title, string composer, TimeSpan lenght)
        {

            Title = title;
            Composer = composer;
            Lenght = lenght;
        }

    }
}

