﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    public class Pila
    {
        private string[] _arreglo;
        private int _tope;
        private int _max;


        public Pila(int elemntos)
        {
            _arreglo = new string[elemntos];
            _tope = 0;
            _max = _arreglo.Length - 1;

        }

        private bool EstaLleno()
        {
            if (_tope > _max)
            {
                return true;


            }
            else
        }
                return false;

            }

        }

}
}
