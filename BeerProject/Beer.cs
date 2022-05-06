using System;
using System.Runtime.Remoting.Messaging;

namespace BeerProject
{
    public class Beer : IAddable, IMixable, IComparable
    {
        private string _brewery;
        private string _beerName;
        private BeerType _beerType;
        private int _volume;
        private double _percent;

        public Beer()
        {
            
        }

        public Beer(string brewery, string beerName, BeerType beerType, int volume, double percent)
        {
            this._brewery = brewery;
            this._beerName = beerName;
            this._beerType = beerType;
            this._volume = volume;
            this._percent = percent;
        }

        public string brewery
        {
            get { return _brewery;}
            set { _brewery = value; }
        }
        public string beerName
        {
            get { return _beerName;}
            set { _beerName = value; }
        }
        public BeerType beerType
        {
            get { return _beerType;}
            set { _beerType = value; }
        }
        public int volume
        {
            get { return _volume;}
            set { _volume = value; }
        }
        public double percent
        {
            get { return _percent;}
            set { _percent = value; }
        }

        public double GetUnits()
        {
            return _volume * _percent / 150;
        }
        
        public Beer Add(Beer beer)
        {
            Beer bnewvolume = new Beer();
            bnewvolume.volume = this.volume + beer.volume;

            return bnewvolume;
        }

        public Beer Mix(Beer beer)
        {
            Beer bnew = new Beer();
            bnew.brewery = this.brewery + " " + beer.brewery;
            bnew.beerName = this.beerName + " " + beer.beerName;
            bnew.beerType = BeerType.MIX;
            bnew.volume = this.volume + beer.volume;
            bnew.percent = (this.volume * this.percent + beer.volume * beer.percent) / (this.volume + beer.volume);
            return bnew;
        }
        public override string ToString()
        {
            return string.Format("Navn:{0} Beername:{1} Beertype:{2} Volume:{3} Percentage:{4} Genstande {5}", _brewery, _beerName, _beerType, _volume, _percent, GetUnits());
        }

        public int CompareTo(Object obj)
        {
            Beer beer = (Beer) obj;
            double result = this.GetUnits() - beer.GetUnits();

            if (result > 0)
            {
                return 1;
            } else if (result < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}