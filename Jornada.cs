using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen3aParcial
{
    class Jornada
    {
        private int _numero;
        private string _estado;
        private string _contrincantes;
        private string _marcador;
        public Jornada(int numero, string estado, string contrincantes, string marcador)
        {
            _numero = numero;
            _estado = estado;
            _contrincantes = contrincantes;
            _marcador = marcador;
        }
        public int numero
        {
            get { return _numero; }
        }
        public string estado
        {
            get { return _estado; }
        }
        public string contrincantes
        {
            get { return _contrincantes; }
        }
        public string marcador
        {
            get { return _marcador; }
        }
        public override string ToString()
        {
            return "Jornada: " + numero + " Estado:" + estado + " Equipos: " + contrincantes + " Marcador:" + marcador;
        }
    }
}
