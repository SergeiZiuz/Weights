using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation.Weights
{
    public class Indexer
    {
        double[] array;
        int start;
        int length;
        public int Length
        {
            get { return length; }
        }

        public Indexer(double[] array, int start, int length)
        {
            if (start < 0 || start >= array.Length) throw new ArgumentException();
            this.start = start;
            if (length < start || length > array.Length) throw new ArgumentException();
            this.length = length;
            this.array = array.Skip(start).Take(length).ToArray();
        }

        public double this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }

   
}
