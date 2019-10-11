using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JukeBox_Stack
{
    class CDNode
    {
        private string name;
        private string artist;
        private int tracks;
        private int duration;
        private CDNode previous;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Artist
        {
            get
            {
                return artist;
            }
            set
            {
                artist = value;
            }
        }

        public int getTracks()
        {
            return tracks;
        }

        public void setTracks(int trackNum)
        {
            tracks = trackNum;
            
        }

        public int getDuration()
        {
            return duration;
        }

        public void setDuration(int length)
        {
            duration = length;
        }

        public CDNode Prev
        {
            get
            {
                return previous;
            }
            set
            {
                previous = value;
            }
        }
    }
}
