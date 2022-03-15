using ExamenParcial1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenParcial1
{
    internal class ControlJuego
    {
        Ruleta ruleta;
        private List<int> numeros;
        Jugador jugador;

        public ControlJuego()
        {
            this.ruleta = new Ruleta();
            this.numeros = new List<int>();
            this.jugador = new Jugador();
        }

        public void showMenuPrincipal()
        {
            int opcionSeleccionada = 0;
            do
            {
                Console.WriteLine("Bienvenido a la Ruleta");
                Console.WriteLine("1.- Apostar");
                Console.WriteLine("2.- Ver historial");
                Console.WriteLine("3.- Retirarse");
            } while (!validaMenu(3, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {
                case 1:
                    showMenuApuesta();
                    break;
                case 2:
                    showMenuHistorial();
                    break;
                case 3:
                    retirarse();
                    break;
            }
        }

        private void retirarse()
        {
            throw new NotImplementedException();
        }

        private void showMenuHistorial()
        {
            int opcionSeleccionada = 0;
            do
            {
                Console.WriteLine("Bienvenido al menu de historial");
                Console.WriteLine("1.- Balance");
                Console.WriteLine("2.- Cantidad Giros");
                Console.WriteLine("3.- Numero mas frecuente");
                Console.WriteLine("4.- Numero menos frecuente");
                Console.WriteLine("5.- Cantidad Rojos");
                Console.WriteLine("6.- Cantidad Negros");
                Console.WriteLine("7.- Cantidad Pares");
                Console.WriteLine("8.- Cantidad Impares");
                Console.WriteLine("8.- Cantidad Impares");
                Console.WriteLine("9.- Regresar");

            } while (!validaMenu(9, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {
                case 1:
                    Console.WriteLine($"Su balance es: {jugador.montoInicial}");
                    showMenuHistorial();
                    break;
                case 2:
                    Console.WriteLine($"La ruleta he girado un total de: {numeros.Count}");
                    showMenuHistorial();
                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                case 8:

                    break;
                case 9:
                    showMenuPrincipal();
                    break;

            }
        }

        private void showMenuApuesta()
        {
            int opcionSeleccionada = 0;

            do
            {
                Console.WriteLine("Bienvenido al menu de Apuesta");
                Console.WriteLine("1.- Dinero para la apuesta");
                Console.WriteLine("2.- Apostar Numero");
                Console.WriteLine("3.- Apostar Color");
                Console.WriteLine("4.- Apostar Par/Impar");
                Console.WriteLine("5.- Regresar");
            } while (!validaMenu(5, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {
                case 1:
                    Console.WriteLine("Ingrese la cantidad de dinero a apostar: ");
                    jugador.apostar(double.Parse(Console.ReadLine()));
                    Console.WriteLine($"Usted ha apostado: {jugador.apuesta} ahora cuenta con: {jugador.montoInicial}");
                    ruleta.girarRuleta();
                    numeros.Add(ruleta._numeroObtenido);
                    showMenuApuesta();
                    break;
                case 2:
                    ruleta.imprimirCasillas();
                    Console.WriteLine("Ingrese al que numero quiere apostarle");
                    jugador.apostarANumero(int.Parse(Console.ReadLine()),ruleta._numeroObtenido);
                    Console.WriteLine($"Se obtuvo la casilla:{ruleta._numeroObtenido},Color: ");
                    Console.WriteLine($"Ahora tiene: {jugador.montoInicial}");
                    showMenuApuesta();
                    break;
                case 3:
                    ruleta.imprimirCasillas();

                    Console.WriteLine("A que color quiere apostar 'Rojo' o 'Negro'");
                    jugador.apostarPorColor(Console.ReadLine(),ruleta.esNegroRojo());
                    Console.WriteLine($"Se obtuvo la casilla:{ruleta._numeroObtenido},Color: {}");
                    Console.WriteLine($"Ahora tiene: {jugador.montoInicial}");
                    showMenuApuesta();

                    break;
                case 4:
                    ruleta.imprimirCasillas();

                    Console.WriteLine("Ingrese a que le quiere apostar 'Par' o 'Impar'");
                    jugador.apostarParImpar(Console.ReadLine(), ruleta.esParImpar());
                    Console.WriteLine($"Se obtuvo la casilla:{ruleta._numeroObtenido}");
                    Console.WriteLine($"Ahora tiene: {jugador.montoInicial}");
                    showMenuApuesta();

                    break;
                case 5:
                    showMenuPrincipal();
                    break;
            }
        }
        public bool validaMenu(int opciones, ref int opcionSeleccionada)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n <= opciones)
                {
                    opcionSeleccionada = n;
                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opcion Invalida.");
                    return false;
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("El valor ingresado no es valido, debes ingresar un numero.");
                return false;
            }
        }
    }

}
