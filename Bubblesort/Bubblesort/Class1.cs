using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubblesort
{
    class csort
    {
        static Random random = new Random();

        /// <summary>
        /// generate n random ints between min and max 
        /// </summary>
        internal static int[] generate_ints(int n, int min, int max)
        {
            int[] z = new int[n];
            for (int i = 0; i < n; i++) z[i]= random.Next(min, max);
            return z;
        }

        /// <summary>
        /// sort a ascending
        /// </summary>
        /// <algo>
        /// compare 2 consecutive values and swap if the 1st > 2nd
        /// -x in the innerloop: 
        ///     each time the  innerloop has been executed it can be
        ///     done with one item less the next time
        /// </algo>
        internal static int[] bubblesort(int[] a)
        {
            for (int x = 1; x < a.Length ; x++)
            {
                for (int i = 0; i < a.Length - x; i++)
                {
                    if (a[i] > a[i + 1]) swap(a, i, i + 1);
                }
            }
            return a;
        }

        /// <summary>
        /// swap a[i] and a[j]
        /// </summary>
        private static void swap(int[] a, int i, int j)
        {
            int y = a[i];
            a[i] = a[j];
            a[j] = y;
        }
    }
}
