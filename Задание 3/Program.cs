using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Задание_3_;

Employee employee = new Employee();
List<Employee> employees = new List<Employee>()
{
    new("Репин Александр Дмитриевич", 30000, 2),
    new("Михайлков Игорь Николаевич", 65000, 1),
    new("Малов Андрей Николаевич", 28000, 3),
    new("Колесников Илья Рудольфович", 17000, 1),
    new("Мельников Матвей Дмитриевич", 40000, 2),
    new("Исаков Михаил Артемович", 56000, 1),
    new("Михайлков Дмитрий Александрович", 21000, 3),
    new("Кабанов Анатолий Георгиевич", 63000, 1),
    new("Филиппов Витольд Валерьевич", 94000, 3),
    new("Андреев Олег Николаевич", 20000, 2)
};
AllEmployess();
SumSalary();
MinSalary();
MaxSalary();
AverageSalary();
InfoEmployees();
SalaryIndex();
// a.
void AllEmployess()
{
    foreach (var emp in employees)
        Console.WriteLine(employee.Id + "\t" + "ФИО сотрудника: " + emp.Fio + " Отдел: " + emp.Department + " Зарплата: " + emp.Salary);
    employee.IdEmployee();
    Console.WriteLine();
}

// b.
void SumSalary()
{
    double sum = 0;
    foreach (var emp in employees)
        sum += emp.Salary;
    Console.WriteLine($"Сумма затрат на зарплаты в месяц: {sum}");
}
/// c/
void MinSalary()
{
    double min = 1600;
    foreach (var emp in employees)
    {
        if (emp.Salary <= min)
            min = emp.Salary;
    }
    Console.WriteLine($"Сотрудник с минимальной зарплатой: {min}");
}
/// d.
void MaxSalary()
{
    double max = 0;
    foreach (var emp in employees)
    {
        if (emp.Salary > max)
            max = emp.Salary;
    }
    Console.WriteLine($"Сотрудник с максимальной зарплатой: {max}");
}
/// e.
void AverageSalary()
{
    int count = 0;
    double sum = 0;
    foreach (var emp in employees)
    {
        count++;
        sum += emp.Salary;
    }
    Console.WriteLine($"Среднее значение зарплат: {sum / count}");
    Console.WriteLine();
}
/// f.
void InfoEmployees()
{
    foreach (var emp in employees)
        Console.WriteLine(employee.Id + "\t" + emp.Fio);
    employee.IdEmployee();
}

/// 1.
void SalaryIndex()
{
    Console.WriteLine("Введите величину аругмента: ");
    double procent = Convert.ToDouble(Console.ReadLine());
    foreach (var emp in employees)
    {
        emp.Salary += emp.Salary * (procent / 100);
        Console.WriteLine(employee.Id + "\t" + emp.Salary);
    }
}
/// 2.
void InfoDepartment()
{
    Console.WriteLine("Введите номер отдела: ");
    string number = Console.ReadLine();
    switch (number)
    {
        case "1":
            MinSalaryEmployee(1);
            MaxSalaryEmployee(1);
            AverageSalaryEmployee(1);
            SalaryIndexEmployee(1);
            InfoEmployeesEmployee(1);
            break;
        case "2":
            MinSalaryEmployee(2);
            MaxSalaryEmployee(2);
            AverageSalaryEmployee(2);
            SalaryIndexEmployee(2);
            InfoEmployeesEmployee(2);
            break;
        case "3":
            MinSalaryEmployee(3);
            MaxSalaryEmployee(3);
            AverageSalaryEmployee(3);
            SalaryIndexEmployee(3);
            InfoEmployeesEmployee(3);
            break;
    }
    void MinSalaryEmployee()
    {

    }
}