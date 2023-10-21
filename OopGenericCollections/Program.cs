namespace OopGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(101, "Sami", "Male", 80000);
            Employee emp2 = new Employee(102, "Sivan", "Male", 50000);
            Employee emp3 = new Employee(103, "Christoffer", "Male", 100000);
            Employee emp4 = new Employee(104, "Megan", "Female", 70000);
            Employee emp5 = new Employee(105, "Kendall", "Female", 40000);

            string emp1Announce = emp1.announce();
            string emp2Announce = emp2.announce();
            string emp3Announce = emp3.announce();
            string emp4Announce = emp4.announce();
            string emp5Announce = emp5.announce();

            Stack <Employee> Employeestack = new Stack<Employee> ();
            Employeestack.Push(emp1); 
            Employeestack.Push(emp2);
            Employeestack.Push(emp3);
            Employeestack.Push(emp4);
            Employeestack.Push(emp5);



            foreach (Employee emp in Employeestack) 
            { 
             Console.WriteLine(emp.announce());
             Console.WriteLine($"Items left in the stack: {Employeestack.Count}");
            }

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Employees removed from the stack"); // De jobbiga sättet att 
            Employee empONE = Employeestack.Pop();
            Console.WriteLine(empONE.announce());
            Console.WriteLine($"Items left in the stack: {Employeestack.Count}");
            Employee empTWO = Employeestack.Pop();
            Console.WriteLine(empTWO.announce());
            Console.WriteLine($"Items left in the stack: {Employeestack.Count}");
            Employee empThree = Employeestack.Pop();
            Console.WriteLine(empThree.announce());
            Console.WriteLine($"Items left in the stack: {Employeestack.Count}");
            Employee empFour = Employeestack.Pop();
            Console.WriteLine(empFour.announce());
            Console.WriteLine($"Items left in the stack: {Employeestack.Count}");
            Employee empFive = Employeestack.Pop();
            Console.WriteLine(empFour.announce());
            Console.WriteLine($"Items left in the stack: {Employeestack.Count}");

            // För det enklare och snyggare sättet att använda POP - metoden. Se nedan.
            // OBS bra att tänka på! koden uppe dvs "Employee empONE = Employeestack.pop(); och alla andra raderas.
            // annars kommer det komma ivägen för while loopen nedan för alla Items tas bort.

            //while (Employeestack.Count > 0)
            //{
            //    Employee emp = Employeestack.Pop();
            //    Console.WriteLine(emp.announce());
            //    Console.WriteLine($"Items left in the stack: {Employeestack.Count}");
            //}
           

            Console.WriteLine("---------------------------------------");

            Employeestack.Push(emp1);
            Employeestack.Push(emp2);
            Employeestack.Push(emp3);
            Employeestack.Push(emp4);
            Employeestack.Push(emp5);

            // hade jag använt while loop för pop metoden hade jag kunnat skriva ut 2 olika anställda i consolen
            //istället för 2 samma, men det var de som va kravet för outputen i consolen enligt uppgiften.

            int ItemBeforePeek = Employeestack.Count();
            Console.WriteLine($"Item before Peek: {Employeestack.Count}");

            int ItemAfterPeek = Employeestack.Count(); 

            Employee emp1Peek = Employeestack.Peek();
            Console.WriteLine(emp1Peek.announce());
            Console.WriteLine($"Item after Peek: {Employeestack.Count}");
            Employee emp2Peek = Employeestack.Peek();
            Console.WriteLine(emp2Peek.announce());
            Console.WriteLine($"Item after Peek: {Employeestack.Count}");

            bool ContainsEmp3 = Employeestack.Contains(emp3);
            Console.WriteLine($"Employee 3 in the stack: {ContainsEmp3}");

            Console.WriteLine("---------------------------------------");

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(emp1);
            employeeList.Add(emp2);
            employeeList.Add(emp3);
            employeeList.Add(emp4);
            employeeList.Add(emp5);

            string employeeCheck = emp2.announce();

            if (employeeCheck.Contains(emp2Announce))
            {
               Console.WriteLine("Employee2 exists in the list");
            }

            else 
            {
                Console.WriteLine("Employee2 does not exists in the list");
            }

            Employee firstMaleEmployee = employeeList.Find(emp => emp.Gender == "Male");
            Console.WriteLine($"First Male Employee: {firstMaleEmployee.announce()} ");


            List<Employee> maleEmployees = employeeList.FindAll(emp => emp.Gender == "Male");
            Console.WriteLine("Male Employees:");
            foreach (var emp in maleEmployees)
            {
                Console.WriteLine($"{emp.announce()}");
            }
        }
    }
}