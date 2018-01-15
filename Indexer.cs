using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation.Weights
{
	public class Indexer
    {
        public readonly double [] array;
        int start;
        public int Start
        {
            get { return start; }
            set
            {
                if (value < 0) throw new ArgumentException();
                if (value >= array.Length) throw new ArgumentException();
                start = value;
            }
        }

        int length;
        public int Length
        {
            get { return length; }
            set
            {
                if (value < 0) throw new ArgumentException();
                if (value >= length) throw new ArgumentException();
                length = value;
            }
        }



        public Indexer(double [] array, int start, int length)
        {
            this.array = array.Skip(start).Take(length).ToArray();
            //this.array = array;
            Start = start;
            Length = length;
        }

        public double this[int index]
        {
            get
            {
                if ((index < 0) || (index >= Length)) throw new ArgumentException();
                return array[index];
            }
            set
            {
                if ((index < 0) || (index >= Length)) throw new ArgumentException();
                array[index] = value;
            }
        }
    }
}
