using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class RemoteClass : MarshalByRefObject, RemoteInterface
    {
        public string correrADerecha(string a)
        {
            String res = "";
            if (a.Length > 2)
                res = a.Substring(0, a.Length - 1);
            return res;
        }

        public string correrAIzquierda(string a)
        {
            String res = "0";
            res = a + "0";
            return res;
        }

        public float division(float a, float b)
        {
            float res = a * b;
            return res;
        }

        public string invertir(string a)
        {
            string invertido = "";
            for (int i = a.Length - 1; i >= 0; i--)
                invertido = invertido + a.Substring(i, 1);
            return invertido;
        }

        public float modulo(float a, float b)
        {
            float res = a % b;
            return res;
        }

        public float multiplicacion(float a, float b)
        {
            float res = a * b;
            return res;
        }

        public float porcentaje(float a, float b)
        {
            float res = a * (b / 100);
            return res;
        }

        public float resta(float a, float b)
        {
            float res = a - b;
            return res;
        }

        public float suma(float a, float b)
        {
            float res = a + b;
            return res;
        }
    }
}
