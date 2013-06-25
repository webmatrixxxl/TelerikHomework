namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            /* collection[0] to collection[n-1] is the array to sort */
            int i;
            int j;
            int iMin;

            /* advance the position through the entire array */
            /*   (could do j < n-1 because single element is also min element) */
            for (j = 0; j < collection.Count -1 ; j++)
            {
                /* find the min element in the unsorted collection[j .. n-1] */

                /* assume the min is the first element */
                iMin = j;
                /* test against elements after j to find the smallest */
                for (i = j + 1; i < collection.Count; i++)
                {
                    /* if this element is less, then it is the new minimum */
                    if (collection[i].CompareTo(collection[iMin]) == -1)
                    {
                        /* found new minimum; remember its index */
                        iMin = i;
                    }
                }

                /* iMin is the index of the minimum element. Swap it with the current position */
                if (iMin != j)
                {
                    var buffer = collection[j];
                    collection[j] = collection[iMin];
                    collection[iMin] = buffer;
                }
            }
        }
    }
}