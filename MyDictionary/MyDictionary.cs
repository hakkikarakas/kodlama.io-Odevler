using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tk, Tv>
    {
        Tk[] _key;
        Tv[] _value;
        public MyDictionary()
        {
            _key = new Tk[0];
            _value = new Tv[0];
        }
        public void Add(Tk key, Tv value)
        {
            Tv[] tempArray = _value;
            Tk[] tempArray2 = _key;
            _value = new Tv[tempArray.Length + 1];
            _key = new Tk[tempArray2.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                _value[i] = tempArray[i];

            }
            for (int i = 0; i < tempArray2.Length; i++)
            {
                _key[i] = tempArray2[i];
            }
            _value[_value.Length - 1] = value;
            _key[_key.Length - 1] = key;

        }

        public Tk[] Keys
        {
            get { return _key; }
        }
        public Tv[] Values
        {
            get { return _value; }
        }
        public int Count
        {
            get { return _key.Length; }
        }
    }
}
