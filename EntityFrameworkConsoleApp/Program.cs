using EntityFramework.Data;
using EntityFramework.Data.Entities;

public class program
{
    public static void Main()
    {

        //CRUDManager obj = new CRUDManager();

        //Console.WriteLine("Adding a new Employee");
        //obj.Insert(new Employee { Name = "Utkarsh", Address = "Gurgaon" });
        //obj.Insert(new Employee { Name = "Abhimanyu", Address = "Delhi" });
        //PrintAllEmployees();

        //Console.WriteLine("Updating Employee with EmployeeId 2");
        //obj.Update(2, new Employee { Name = "Modified Employee", Address = "Modified Address" });
        //PrintAllEmployees();

        //Console.WriteLine("Retrieving Employee details for EmployeeId 2");
        //var employee = obj.GetEmplpoyeeById(2);
        //Console.WriteLine($"Employee Name of employee ID 2 is {employee.Name}");

        //Console.WriteLine("Deleting Employee details for EmployeeId 2");
        //obj.Delete(2);
        //PrintAllEmployees();

        //Console.ReadLine();

        SaveEmployeeAndEducation();

        //SaveClassRoomAndTeacher();

    }

    private static void PrintAllEmployees()
    {
        Console.WriteLine("Printing all Employees");
        CRUDManager obj = new CRUDManager();
        foreach (Employee employee in obj.GetAllEmployees())
        {
            Console.WriteLine($"Employee Name is {employee.Name} and address is {employee.Address}");
        }
    }

    private static void SaveEmployeeAndEducation()
    {
        CrudEducationDetails obj = new CrudEducationDetails();

        //var employee = new Employee { Name = "Abhimanyu", Address = "Delhi" };
        //List<EmployeeEducation> educationList = new List<EmployeeEducation>();
        //educationList.Add(new EmployeeEducation
        //{
        //    CourseName = "BCA",
        //    UniversityName = "Manipal",
        //    MarksPercentage = 80,
        //    PassingYear = 2020,
        //    Employee= employee
        //});
        //educationList.Add(new EmployeeEducation
        //{
        //    CourseName = "MCA",
        //    UniversityName = "Manipal",
        //    MarksPercentage = 75,
        //    PassingYear = 2022,
        //    Employee = employee
        //});

        //obj.InsertEducation(educationList);

        //List<EmployeeEducation> educationList = new List<EmployeeEducation>();
        //educationList.Add(new EmployeeEducation { CourseName = "BBA", UniversityName = "Manipal", MarksPercentage = 80, PassingYear = 2020 });
        //educationList.Add(new EmployeeEducation { CourseName = "MBA", UniversityName = "Manipal", MarksPercentage = 75, PassingYear = 2022 });

        //obj.InsertEmployeeAndEducation(new Employee { Name = "Aditya", Address = "Hyderabad" }, educationList);

        //List<EmployeeEducation> educationList = new List<EmployeeEducation>();
        //educationList.Add(new EmployeeEducation { CourseName = "BCA", UniversityName = "Manipal", MarksPercentage = 80, PassingYear = 2020 });
        //educationList.Add(new EmployeeEducation { CourseName = "Mtech", UniversityName = "Manipal", MarksPercentage = 75, PassingYear = 2022 });

        //obj.InsertEducationofExistingEmployee(1, educationList);

        obj.PrintEmployeeAndEducation(2);


        Console.WriteLine("Done !!!");
        Console.ReadLine();
    }

    private static void SaveClassRoomAndTeacher()
    {
        CRUDClassRoomAndTeacher obj = new CRUDClassRoomAndTeacher();
        
        //obj.InsertTeacher(new Teacher { Name = "Utkarsh" });
        //obj.InsertClassRoom(new ClassRoom { Name = "Computer Science" });

        obj.InsertClassRoomAndTeacher(new ClassRoom { Name = "Computer Science" }, new Teacher { Name = "Utkarsh" });


        Console.WriteLine("Done !!!");
        Console.ReadLine();
    }
}