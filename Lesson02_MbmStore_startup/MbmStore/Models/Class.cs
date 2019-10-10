using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Track
    {
        public string Composer
        {
            get; set;
        }

        public string Title
        {
            get; set;
        }

        public TimeSpan Length
        {
            get; set;
        }
    }
}
