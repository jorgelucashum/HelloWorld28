using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld28.Entities;
using HelloWorld28.Entities.Enums;

namespace HelloWorld28
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do departamento: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Digite o nome do funcionário: ");
            string workerName = Console.ReadLine();

            Console.WriteLine("Digite o nível dele: (Junior/Pleno/Senior)");
            WorkerLevel level;
            Enum.TryParse(Console.ReadLine(), out level); // Convertendo o tipo 'string' pro tipo 'enum'.

            Console.WriteLine("Digite o seu salário base: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("Há quantos contratos para trabalhar? ");
            int contract = int.Parse(Console.ReadLine());

            for(int i = 1; i <= contract; i++)
            {
                Console.WriteLine("#" + i + " Digite os dados do contrato:");
                Console.WriteLine("Data: ");
                
                Console.WriteLine("Valor por hora: ");
                Console.WriteLine("Duração: (Horas)");


            }

        }
    }
}
