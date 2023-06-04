using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3_
{
    public class Employee
    {
        private string _fio;
        private double _salary;
        private int _department;
        static int id = 1;

        public Employee(string fio, int salary, int department)
        {
            _fio = fio;
            _salary = salary;
            _department = department;
        }

        public int Id
        {
            get => id++;
        }
        public int IdEmployee()
        {
            id = 1;
            return id;
        }

        public string Fio
        {
            get => _fio;
            set => _fio = value;
        }

        public int Department
        {
            get => _department;
            set => _department = value;
        }

        public double Salary
        {
            get => _salary;
            set => _salary = value;
        }

        public Employee()
        {

        }
    }
}
