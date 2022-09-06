using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista
{
    internal class Employee
    {

        public int Id { get; private set; }
        public string Name { get;private  set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;

        }

        public void Aumento(double porcentagem)
        {

            
                Salary *= (1.00+(porcentagem / 100));
            

        }

        public override string ToString()
        {
            return Id
                   + ", "
                   + Name
                   + ", "
                   + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
