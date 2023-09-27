using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    public class Calculadora

    {
        private List<string> listahistorico;
        private string data;

        public Calculadora(string data)
        {
            listahistorico = new List<string>();
            this.data = data;
        }
        public int soma(int num1, int num2)
        {
            int resultado = num1 + num2;
            listahistorico.Insert(0, "Resultado: " + resultado + " - data:" + data);
            return resultado;
        }

        public int subtracao(int num1, int num2)
        {
            int resultado = num1 - num2;
            listahistorico.Insert(0, "Resultado: " + resultado + " - data:" + data);
            return resultado;
        }

        public int multiplicacao(int num1, int num2)
        {
            int resultado = num1 * num2;
            listahistorico.Insert(0, "Resultado: " + resultado + " - data:" + data);
            return resultado;
        }

        public int divisao(int num1, int num2)
        {
            int resultado = num1 / num2;
            listahistorico.Insert(0, "Resultado: " + resultado + " - data:" + data);
            return resultado;
        }

        public List<string> historico()
        {
            
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }
    }
}
