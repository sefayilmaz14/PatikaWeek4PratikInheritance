using PatikaWeek4PratikInheritance;

class Program
{
    static void Main(string[] args)
    {
        Teacher teacher1 = new Teacher();
        teacher1.Name = "Ogün";
        teacher1.Surname = "Şanlısoy";
        teacher1.Salary = 51.369;
        teacher1.Display();
        teacher1.SalaryDisplay();


        Student student1 = new Student();
        student1.Name = "Fahri";
        student1.Surname = "Korutürk";
        student1.StudentNumber = 1659;
        student1.Display();
        student1.StudentNumberDisplay();

    }
}