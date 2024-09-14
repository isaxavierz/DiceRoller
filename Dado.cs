using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{   
    internal class Dado
    {
        private int qtdeDeLados;
        private int modificador;

        public Dado(int qtdeDeLados, int modificador) { 
            this.qtdeDeLados = qtdeDeLados;
            this.modificador = modificador;
        }
        public int rolarDados()
        {
            int numeroSorteado = new Random().Next(1, qtdeDeLados + 1 ) + modificador;

            return numeroSorteado;
        }
         
    }
}
