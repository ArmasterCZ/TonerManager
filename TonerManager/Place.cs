using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TonerManager 
{
    public class Place : IEquatable<Place>
    {
        public string name
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

        public int note
        {
            get
            {
                return note;
            }
            set
            {
                note = value;
            }
        }

        public override string ToString()
        {
            return string.Format(@"{0},{1}", name, note.ToString());
        }

        public bool Equals(Place otherPlace)
        {
            if (this.name == otherPlace.name & this.note == otherPlace.note)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
