using System.Collections;

namespace BeerProject
{
    public class SortingBeerBy : IComparer
    {
        private SortBy _sortBy;
        public SortingBeerBy(SortBy sortBy)
        {
            this._sortBy = sortBy;
        }
        
        public int Compare(object _beer1, object _beer2)
        {
            Beer beer1 = (Beer)_beer1;
            Beer beer2 = (Beer) _beer2;
            double sorting;
            switch (_sortBy)
            {
                case SortBy.UNIT:
                    sorting = beer1.GetUnits() - beer2.GetUnits();
                    if (sorting > 0)
                    {
                        return 1;
                    } else if (sorting < 0)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                    break;
                case SortBy.VOLUME:
                    sorting = beer1.volume - beer2.volume;
                    if (sorting > 0)
                    {
                        return 1;
                    } else if (sorting < 0)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                    break;
                case SortBy.PERCENT:
                    sorting = beer1.percent - beer2.volume;
                    if (sorting > 0)
                    {
                        return 1;
                    } else if (sorting < 0)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                    break;
                default:
                    sorting = beer1.GetUnits() - beer2.GetUnits();
                    if (sorting > 0)
                    {
                        return 1;
                    } else if (sorting < 0)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                    break;
            }

            return 0;
        }
    }
}