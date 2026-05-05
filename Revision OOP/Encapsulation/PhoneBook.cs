using System;
using System.Collections.Generic;
using System.Text;

namespace Revision_OOP.Encapsulation
{
    internal struct PhoneBook
    {
        #region Attributes
        string[] names;
        ulong[] numbers;
        int size;
        #endregion

        // Getter
        public long GetNumber(string name)
        {
            if (names is not null && numbers is not null )
            {
                for (int i = 0; i < size; i++)
                {
                    if (name == names[i])
                    {
                        return (long)numbers[i];
                    }
                } 
            }
            return -1;
        }

        // Setter
        public void SetNumber(string name, ulong value)
        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (name == names[i])
                    {
                        numbers[i] = value; // Update
                        return; // Will Exist from the all Method
                        // break Will exist from the just for loop
                    }
                }
            }
        }


        #region Properties

        public int Size { get; }


        public long this[string name]
        {
            get
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (name == names[i])
                        {
                            return (long) numbers[i];
                        }
                    }
                }
                return -1;
            }
            set
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (name == names[i])
                        {
                            numbers[i] = (ulong)value; // Update
                            return; // Will Exist from the all Method
                                    // break Will exist from the just for loop
                        }
                    }
                }
            }
        }

        public string this[int index]
        {
            get
            {
                return $"Position : {index + 1} Name = {names[index]}, Number ={numbers[index]} ";
            }
        }


        #endregion

        #region constructor
        public PhoneBook(int size)
        {
            this.size = size;
            names = new string[size];
            numbers = new ulong[size];

        }
        #endregion



        #region Methods

        public void AddPerosn(uint position, string name, ulong number)
        {
            if (names is not null && numbers is not null && position < size)
            {
                names[position] = name;
                numbers[position] = number;
            }
        }
        #endregion

    }
}
