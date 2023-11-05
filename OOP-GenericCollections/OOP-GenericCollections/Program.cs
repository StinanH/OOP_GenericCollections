//Stina Hedman
//NET23 

using System.Collections;

namespace OOP_GenericCollections
{ 

    public class Employee
    {
        public int ID { get; set;}
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public double Salary { get; set; }

        public Employee (int id, string name, Gender gender, double salary)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        public string PrintInfo()
        {
            return $"ID: {this.ID}, {this.Name}, {this.Gender}, Salary: {this.Salary}";
        }
    }
    internal class Program
    {
        static void PrintStackCount(Stack<Employee> stack)
        {
            Console.WriteLine($"{stack.Count} employees left in stack.");
        }

        static void Main(string[] args)
        {
         
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(new Employee(1, "Stina Hedman", Gender.Female , 10000 ));
            stack.Push(new Employee(2, "Jonnie Larsson", Gender.Male, 12000)) ;
            stack.Push(new Employee(3, "Anna Aaronsson", Gender.Female, 13000));
            stack.Push(new Employee(4, "Josef Nissan", Gender.Male , 14000));
            stack.Push(new Employee(5, "Danny Soergaard", Gender.Male, 15900)) ;

            List<Employee> list = new List<Employee>();

            foreach (Employee emp in stack)
            {
                PrintStackCount(stack);
                Console.WriteLine(emp.PrintInfo());
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Retrieve using Pop method:");

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop().PrintInfo());
                Console.WriteLine($"{stack.Count} employees left in stack.");
            }

            stack.Push(new Employee(1, "Stina Hedman", Gender.Female, 10000));
            stack.Push(new Employee(2, "Jonnie Larsson", Gender.Male, 12000));
            stack.Push(new Employee(3, "Anna Aaronsson", Gender.Female, 13000));
            stack.Push(new Employee(4, "Josef Nissan", Gender.Male, 14000));
            stack.Push(new Employee(5, "Danny Soergaard", Gender.Male, 15900));

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Retrieve using Peek method:");
            Console.WriteLine(stack.Peek().PrintInfo());
            Console.WriteLine($"{stack.Count} employees left in stack.");
            Console.WriteLine(stack.Peek().PrintInfo());
            Console.WriteLine($"{stack.Count} employees left in stack.");
             

            if (stack.Count > 3)
            {
                if (stack.ElementAt(3) != null)
                {
                    Console.WriteLine("there is an object in the third position of the stack.");
                }
            }
            Console.WriteLine("------------------------------------------");
            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(new Employee(1, "Stina Hedman", Gender.Female, 10000));
            employeeList.Add(new Employee(2, "Jonnie Larsson", Gender.Male, 12000));
            employeeList.Add(new Employee(3, "Anna Aaronsson", Gender.Female, 13000));
            employeeList.Add(new Employee(4, "Josef Nissan", Gender.Male, 14000));
            employeeList.Add(new Employee(5, "Danny Soergaard", Gender.Male, 15900));

            if (employeeList.Contains(employeeList.Find(x => x.Name == "Stina Hedman")))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else { Console.WriteLine("Employee2 object does not exist in the list"); }

            Employee same =  (employeeList.Find(x => x.Gender == Gender.Male));
            if (same != null)
            {
                Console.WriteLine(same.PrintInfo());

            }
            else
            {
                Console.WriteLine("THERE ARE NO MALES");
            }

            List<Employee> newList = employeeList.FindAll(x => x.Gender == Gender.Male);
            foreach (Employee emp in newList) 
            {
                Console.WriteLine(emp.PrintInfo()); 
            }
        }
    }
}