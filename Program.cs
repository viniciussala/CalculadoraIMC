using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace CalculadoraIMC
{
    class program
    {
        static void Main(string[] args)
        {
            float altura, peso, imc;

            Console.WriteLine("CALCULADORA IMC");
            Console.WriteLine("=============================");
            Console.Write("Digite sua altura: ");
            altura  = float.Parse(Console.ReadLine());

            Console.Write("Digite seu peso em KG: ");
            peso = float.Parse(Console.ReadLine());

            imc = (peso / (altura * altura));

            Console.Clear();

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do Peso");
            }
            else if (imc <= 24.9)
            {
                Console.WriteLine("Peso ideal");
            }
            else if (imc >= 25)
            {
                Console.WriteLine("Pré Obeso");
            }
            else if (imc >= 30)
            {
                Console.WriteLine("Obeso de primeiro grau");
            }
            else if (imc >= 35)
            {
                Console.WriteLine("Obesidade de segundo grau");
            }
            else if (imc >= 40)
            {
                Console.WriteLine("Obesidade de terceiro grau");
            }

            Console.WriteLine("Sua altura é: " + altura);
            Console.WriteLine("Seu peso é: " + peso);
            Console.WriteLine("Seu imc: " + imc);




        }   
    }
}

    