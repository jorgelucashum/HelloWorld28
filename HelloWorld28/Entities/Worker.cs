using System;
using System.Collections.Generic;
using HelloWorld28.Entities;
using HelloWorld28.Entities.Enums;


namespace HelloWorld28.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; } // Composição entre a classe 'Worker' e 'Departament'.
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // Lista criada porque um trabalhador pode ter vários contratos. // Lista já instanciada para não ser nula.

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if (contract.Date.Year == year & contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }

        public override string ToString()
        {
            return $"Nome: {Name}, Nível: {Level}, Departamento: {Departament}";
        }
    }
}
