﻿
namespace HelloWorld28.Entities
{
    class Departament
    {
        public string Name { get; set; }

        public Departament()
        {
        }
        public Departament(string name)
        {
            Name = name;
        }

       /* public override string ToString()
        {
            return $"\nNome do departamento: {Name}";
        }
       */
    }
}
