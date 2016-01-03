
using System;

namespace ArrayTestBed
{
    class CArray
    {
        //initializing the properties
        private readonly int[] _array;
        private readonly int _upper;
        private int _numElements;

        
        //constructor
        //initializing the variables inside the constructor
        public CArray(int size)
        {
            _array = new int[size];
            _upper = size - 1;
            _numElements = 0;
        }

        //insert elements into the array
        public void Insert(int item)
        {
            _array[_numElements] = item;
            _numElements++;
        }

        //display the array element.
        public void DisplayElements()
        {
            for (int i = 0; i <= _upper; i++)
            {
                Console.Write(_array[i] + " ");
            }
            Console.WriteLine();
        }

        //clear the array value
        public void Clear()
        {
            //traversing all the values of the array
            for (int i = 0; i < _upper; i++)
            {
                _array[i] = 0;   //initializing all the values to zero.
            }
            _numElements = 0;
        }

        //implementing the bubble sort
        public void BubbleSort()
        {
            //initializing a temporary variable
            int temp;

            //looping through the array
            for (int outer = _upper; outer >= 1; outer--)
            {
                for (int inner = 0; inner <= outer - 1; inner++)
                {
                    //compare two values and swapping it if first is greater then the next
                    if ((int) _array[inner] > _array[inner + 1])
                    {
                        temp = _array[inner];
                        _array[inner] = _array[inner + 1];
                        _array[inner + 1] = temp;
                    }
                }
                //Display the elements
                DisplayElements();
            }
        }
    }
}
