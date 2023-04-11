using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta.ConsoleApp1
{
    internal class Movimentacao
    {
        public double Valor { get; set; }
        public string Tipo { get; set; }

        public Movimentacao(double valor, string tipo)
        {
            Valor = valor;
            Tipo = tipo;
        }
    }
}