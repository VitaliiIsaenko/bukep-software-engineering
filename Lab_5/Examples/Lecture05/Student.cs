public class Student
{
    private int age;
    public string Name { get; set; }

    public int getAge()
    {
        return age;
    }

    public void setAge(int age)
    {
        this.age = age;
    }

    public static void Run() {
        this
    }
}
public class CsvReader
{
    string[][] countriesInfo = CsvReader.Read("Isaenko.csv");
}