using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Encapsulamento
{
    internal class Aluno
    {
        // Atributos
        private double nota1, nota2;
        
        // Media
        private double Media()
        {
            return (nota1 + nota2) / 2;
        }

        // Mensagem
        public void Mensagem()
        {
            Console.WriteLine("Informe a primeira nota:");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota:");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A media e {Media()}");
        }
    }
}
