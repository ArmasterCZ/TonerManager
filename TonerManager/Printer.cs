using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TonerManager
{
    //default storage of information about printer
    public class Printer : IComparable<Printer>
    {
        public Printer()
        {
                
        }

        public Printer(List<string> stringTonerList, List<string> stringPlaceList)
        {
            foreach (string stringToner in stringTonerList)
            {
                throw new System.NotImplementedException();
            }
            foreach (string stringPlace in stringPlaceList)
            {
                throw new System.NotImplementedException();
            }
        }

        public string type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public int numberOfPrinters
        {
            get
            {
                return numberOfPrinters;
            }
            set
            {
                numberOfPrinters = value;
            }
        }

        public string note
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

        public bool multicolor
        {
            get
            {
                return multicolor;
            }
            set
            {
                multicolor = value;
            }
        }

        private List<Place> placeList { get; set; } = new List<Place>();

        private List<Toner> tonerList { get; set; } = new List<Toner>();

        public void addToner(Toner toner)
        {
            tonerList.Add(toner);
        }

        public void removeToner(Toner toner)
        {
            Toner tonerFound = tonerList.FirstOrDefault(ton => ton == toner);
            if (tonerFound != null)
            {
                tonerList.Remove(tonerFound);
            }
        }

        public void addPlace(Place place)
        {
            placeList.Add(place);
        }

        public void removePlace(Place place)
        {
            Place placeFoun = placeList.FirstOrDefault(pla => pla == place);
            if (placeFoun != null)
            {
                placeList.Remove(placeFoun);
            }
        }

        public int CompareTo(Printer other)
        {

            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
