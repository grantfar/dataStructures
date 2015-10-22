using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfSortingList
{
    public class SortingList<T> where T : IComparable
    {
        private List<T> theList;
        public SortingList()
        {
            theList = new List<T>();
        }

        public void add(T toAdd)
        {
            if(theList.Count == 0)
            {
                theList.Add(toAdd);
            }
            int lowIndex = 0;
            int highIndex = theList.Count - 1;
            int compare;
            while(highIndex - lowIndex > 1)
            {
                compare = (highIndex + lowIndex)/2;
                if(theList[compare].CompareTo(toAdd) == 0)
                {
                    highIndex = compare;
                    lowIndex = compare;
                }
                else if(theList[compare].CompareTo(toAdd) < 0)
                {
                    lowIndex = compare;
                }
                else
                {
                    highIndex = compare;
                }
            }
            if()
        }
    }
}
