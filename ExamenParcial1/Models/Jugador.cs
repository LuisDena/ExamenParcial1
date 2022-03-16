using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//● El jugador deberá iniciar con un monto de dinero inicial ($300).
//● El jugador podrá apostar la cantidad de dinero que quiera en sus apuestas, siempre y cuando sean múltiplos de 10.
//● El jugador podrá elegir una de 3 formas diferentes de apostar:
//      o Apostar a un número específico (0-36), que multiplicará su apuesta por 10.
//      o Apostar a que el número es de color rojo o de color negro, que multiplicará su apuesta por 5.
//      o Apostar si el número será par o impar, que multiplicará su apuesta por 2.

namespace ExamenParcial1.Models
{
    internal class Jugador
    {
        private double _montoInicial = 300.00;
        private double _apuesta=0.0;

        public double montoInicial
        {
            get { return _montoInicial; }
        }
        public double apuesta
        {
            get { return _apuesta; }
        }
        public double? apostar(double apuesta) {
            this._apuesta = apuesta;
            if (_apuesta % 10 != 0 || _apuesta>_montoInicial)
            {
                Console.WriteLine("Valor invalido");
                return null;
            }
            else {
                return _apuesta;
            }
            
        }
        public double? apostarANumero(int numero,int numeroGirado) {
            if (numero < 0 || numero > 36)
            {
                Console.WriteLine("Valor invalido");
                return null;
            }
            else if (numero == numeroGirado)
            {
                _montoInicial =_montoInicial+( this.apuesta * 10);
                return _montoInicial;
            }
            else {
                return _montoInicial = _montoInicial-(this.apuesta);
            }
        }
        public double? apostarPorColor(String color,String colorCasilla) {
            if (color==(colorCasilla))
            {
                return this._montoInicial = montoInicial+(_apuesta * 5);

            } 
            else
            {
                return this._montoInicial = montoInicial - (_apuesta);
            }
        }
        public double? apostarParImpar(String tipo,String tipoCasilla) {
            if (tipo==tipoCasilla)
            {
                return this._montoInicial =montoInicial+(_apuesta * 2);
            }
            else
            {
                return this._montoInicial = montoInicial - (_apuesta);
            }
        }

    }
}
