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
            Console.Write("Digite o nome do departamento: ");
            string deptName = Console.ReadLine();

            Console.Write("Digite o nome do funcionário: ");
            string workerName = Console.ReadLine();

            Console.Write("Digite o nível dele: (Junior/Pleno/Senior)");
            WorkerLevel level;
            Enum.TryParse(Console.ReadLine(), out level); // Convertendo o tipo 'string' pro tipo 'enum'.

            Console.Write("Digite o seu salário base: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Departament dept = new Departament(deptName); // Instaciando um objeto do tipo 'Departament'.
            Worker worker = new Worker(workerName, level, baseSalary, dept); // Instaciando um objeto do tipo 'Worker'.


            Console.Write("Há quantos contratos para este trabalhador? ");
            int contract = int.Parse(Console.ReadLine());

            for(int i = 1; i <= contract; i++)
            {
                Console.WriteLine("\n#" + i + " Digite os dados do contrato:");
                Console.Write("Data(dd/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duração: (Horas)");
                int hours = int.Parse(Console.ReadLine());

                HourContract hourContract = new HourContract(date, valuePerHour, hours); // Instaciando um objeto do tipo 'HourContract'
                worker.addContract(hourContract);

            }

            Console.Write("\nDigite o mês e o ano para realizar o calculo (MM/YYYY): ");
            string MonthAndYear = Console.ReadLine();
            int month = int.Parse(MonthAndYear.Substring(0, 2)); // O '.Substring' recorta o string a partir da posição '0', '2' posições.
            int year = int.Parse(MonthAndYear.Substring(3)); // O '.Substring' recorta o string a partir da posição '3', até o final porque não foi colocado o último parâmetro.

            Console.WriteLine("\nNome do departamento: " + worker.Departament.Name); // Acessando a classe 'Departament' através do objeto 'worker'.
            Console.WriteLine(worker + "\nTotal recebido em " + MonthAndYear + ": " +  worker.Income(year, month).ToString("F2"));
        }
    }
}
