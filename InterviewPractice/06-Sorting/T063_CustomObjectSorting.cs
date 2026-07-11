namespace InterviewPractice._06_Sorting;

/// <summary>
/// T063_CustomObjectSorting.cs
/// Умова: Створити клас Employee з полями Name (string) та Salary (int).
/// Реалізувати інтерфейс IComparable<Employee> для сортування за замовчуванням
/// (за спаданням зарплати). Також створити окремий клас
/// EmployeeNameComparer : IComparer<Employee> для сортування за алфавітом.
/// Вхід: Список співробітників.
/// Результат: Виведення в консоль спочатку списку,
/// відсортованого за грошима, а потім — за іменами.
/// </summary>
public class T063_CustomObjectSorting
{
    private const string TASK_NUMBER = "063";

    public static void Run(List<Employee> employees)
    {
        Console.WriteLine($"Task {TASK_NUMBER}: Custom Object Sorting");
        Console.WriteLine("Original list of employees:");
        PrintEmployees(employees);

        // сортування за ЗП (спадання)
        employees.Sort();
        Console.WriteLine("\nEmployees sorted by salary (descending):");
        PrintEmployees(employees);

        // сортування за алфавітом
        employees.Sort(new EmployeeNameComparer());
        Console.WriteLine("\nEmployees sorted by name (alphabetically):");
        PrintEmployees(employees);
    }
    
    public static void PrintEmployees(List<Employee> employees)
    {
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}

public class Employee : IComparable<Employee>
{
    public string Name { get; }
    public int Salary { get; }

    public Employee(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }

    public int CompareTo(Employee? other)
    {
        if (other == null) 
            return 1;
        
        return other.Salary.CompareTo(this.Salary);
    }

    public override string ToString()
    {
        return $"{Name}, ЗП: {Salary}";
    }
}

public class EmployeeNameComparer : IComparer<Employee>
{
    public int Compare(Employee? x, Employee? y)
    {
        if (x == null && y == null) 
            return 0;
        
        if (x == null) 
            return 1;
        
        if (y == null) 
            return -1;
        
        return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
    }
}