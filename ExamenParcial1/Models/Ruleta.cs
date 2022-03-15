using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// El juego consistirá en simular el giro de una ruleta (números del 0 al 36):
// o Los números 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33 y 35
// están etiquetados de color negro.
// o Los números 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34 y 36
// están etiquetados de color rojo.
// o El número 0 no está etiquetado de ningún color.

namespace ExamenParcial1.Models
{
    internal class Ruleta
    {
        private int numeroObtenido;

        public int _numeroObtenido
        {
            get { return numeroObtenido; }
            set { numeroObtenido = value; }
        }


        private List<string> _ruleta;
        private List<int> _casillasRojas = new List<int> { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34 , 36 };
        private List<int> _casillasNegras = new List<int> { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };

        public Ruleta()
        {
            this._ruleta = new List<string>(36);
            inicializarRuleta();
        }

        //establece los colores
        public void inicializarRuleta()
        {
            _ruleta.Add("Verde");
            for (int i = 0; i <= 36; i++)
            {
                foreach (int item in this._casillasRojas)
                {
                    if (i == item)
                    {
                        _ruleta.Add("Rojo");
                    }
                }
                foreach (int item2 in this._casillasNegras)
                {
                    if (i == item2)
                    {
                        _ruleta.Add("Negro");
                    }
                }
            }
            imprimirCasillas();
        }

        public void imprimirCasillas()
        {
            Console.WriteLine("Lista de Casillas");
            int posicion = 0;
            foreach (String objeto in _ruleta)
            {
                Console.WriteLine("Casilla NO. " + posicion + " " + objeto.ToString());
                posicion++;
            }
        }

        public int girarRuleta()
        {
            Random random = new Random();
            int numeroRandom = random.Next(0,36);
            numeroObtenido = numeroRandom;
            return numeroRandom;
        }
        public string esParImpar() {
            if (numeroObtenido % 2 == 0)
            {
                return "Par";
            }
            else {
                return "Impar";
            }
        }
        public string esNegroRojo() {
            int posicion = 0;
            string color="";
            foreach (string item in _ruleta)
            {
                if (posicion == numeroObtenido)
                {
                    color = item.ToString();
                }
                else
                {
                    if (posicion<=36)
                    {
                        posicion++;
                    }
                }
                color = item.ToString();
            }
            return color;
        }
    }
}
