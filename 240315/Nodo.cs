using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240315
{
    class Nodo
    {
        private int _dato;

        public int Dato
        {
            get { return _dato; }
            set { _dato = value; }
        }
        private Nodo _siguiente;

        public Nodo Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public Nodo(int dato)
        {
            _dato = dato;
        }

        public override string ToString()
        {
            return _dato.ToString();
        }
    }
}
