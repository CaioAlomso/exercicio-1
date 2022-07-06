using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ntl, p1,p2, total, media;
            Console.WriteLine("Escreva o nome do aluno");
            Console.ReadLine();



            Console.WriteLine("Digite a Nota do Trabalho");
            ntl = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a Nota da Pimeira Prova");
            p1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a Nota da Segunda Prova");
            p2 = Convert.ToDouble(Console.ReadLine());

            total = ntl + p1 + p2;
            media = total / 3;

            if (media >= 8.5)
            {
                Console.WriteLine("média final = " + media);
                Console.WriteLine("Conceito A");
            }
            else if (media >= 7)
            {
                Console.WriteLine("média final = " + media);
                Console.WriteLine("Conceito B");
            }
            else if (media >= 6)
            {
                Console.WriteLine("média final = " + media);
                Console.WriteLine("Conceito C");
            }
            else if (media >= 0.1)
            {
                Console.WriteLine("média final = " + media);
                Console.WriteLine("Conceito D");
            }
            else if (media >= 0.0)
            {
                Console.WriteLine("média final = " + media);
                Console.WriteLine("Conceito E");
            }
            Console.ReadKey();
        }
    }
}
