using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen3aParcial
{
    class Equipo
    {
        private string _nombre;
        private int _numero;
        public Equipo(string nombre, int numero)
        {
            _nombre = nombre;
            _numero = numero;
        }
        public string nombre
        {
            get { return _nombre; }
        }
        public int numero
        {
            get { return _numero; }
        }
        public override string ToString()
        {
            return nombre + numero;
        }
    }
}
