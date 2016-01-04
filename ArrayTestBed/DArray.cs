using System;

namespace ArrayTestBed
{
    class DArray
    {
        //initializing the properties
        private readonly int[] _array;
        private readonly int _upper;
        private int _numElements;


        //constructor
        //initializing the variables inside the constructor
        public DArray(int size)
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

        //implementing the selection sort
        public void SelectionSort()
        {
            //initializing a temporary variable
            int temp, min;

            //looping through the array
            for (int outer = 0; outer <= _upper; outer++)
            {
                //assigning the minimum value as outer
                min = outer;
                
                for (int inner = outer+1; inner <= _upper; inner++)
                {
                    if (_array[inner] < _array[min])
                    {
                        min = inner;
                    }
                    temp = _array[outer];
                    _array[outer] = _array[min];
                    _array[min] = temp;
                }
                //Display the elements
                DisplayElements();
            }
        }
    }
}
