using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TonerManager
{
    public class Toner : IEquatable<Toner>
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

        public TonerManager.Color color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public string bareCode
        {
            get
            {
                return bareCode;
            }
            set
            {
                bareCode = value;
            }
        }

        public override string ToString()
        {
            return string.Format(@"{0},{1}", name, color.ToString());
        }

        public bool Equals(Toner otherToner)
        {
            if (this.name == otherToner.name & this.color == otherToner.color)
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
