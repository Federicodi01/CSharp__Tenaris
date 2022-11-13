using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Remoting_DDSOK
{
    public interface RemoteInterface
    {

        float suma(float a, float b);

        float resta(float a, float b);

        float multiplicacion(float a, float b);

        float division(float a, float b);

        float porcentaje(float a, float b);

        String correrADerecha(String a);

        String correrAIzquierda(String a);

        float modulo(float a,float b);

        String invertir(String a);
    }
}
