using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen3aParcial
{
    class Jugador
    {
        private string _equipo;
        private string _nombre;
        private int _edad;
        private int _numero;

        public Jugador(string equipo,string nombre, int edad, int numero)
        {
            _equipo = equipo;
            _nombre = nombre;
            _edad = edad;
            _numero = numero;
        }
        public string equipo
        {
            get { return _equipo; }
        }
        public string nombre
        {
            get { return _nombre; }
        }
        public int edad
        {
            get { return _edad; }
        }
        public int numero
        {
            get { return _numero; }
        }

        public override string ToString()
        {
            return "Equipo:" + equipo+ " Nombre:" +nombre + " edad:" + edad + " numero:" + numero;
        }
        
    }
}
