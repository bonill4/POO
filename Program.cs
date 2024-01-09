using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //primeraClase();
            segundaClase();
        }

        static void primeraClase()
        {
            Circulo miCirculo; //Creacion de objeto de tipo Circulo. Variable/objeto de tipo circulo


            miCirculo = new Circulo(); //Inicializamos de variable/objeto de tipo de circulo. 

            Console.WriteLine(miCirculo.CalculoArea(5));

            //Instacia de Clase
            Circulo miCirculo2 = new Circulo();

            Console.WriteLine(miCirculo2.CalculoArea(9));
        }

        static void segundaClase()
        {
            ConversorEuroDolar obj = new ConversorEuroDolar();

            obj.CambioValor(-1.45);
            Console.WriteLine(obj.Convierte(50)); 
        }
    }

    //Identificadores "public" deben comenzar con letra mayuscula. ejem: CalculoArea
    //Identificadores no  "public" deben empezar por letra minuscula. ejem: longitudRadio

    class Circulo
    {
        //Propiedades,Caracterisiticas de la Clase o Campo de la Clase
        private const double PI = 3.1416; //Con "private" encapsulamos el dato

        //Metodo de Clase o el Comportamiento de la Clase
        public double CalculoArea (int radio)
        {
            return PI * Math.Pow(radio,2);
        }
    }

    class ConversorEuroDolar
    {
        double euro = 1.253;

        //Metodo de Acceso 
        public void CambioValor(double valor)
        {
            if (valor < 0) euro = 1.253;
            else euro = valor;
        }

        public double Convierte(double cantidad)
        {
            return cantidad * euro;
        }
    }
}
