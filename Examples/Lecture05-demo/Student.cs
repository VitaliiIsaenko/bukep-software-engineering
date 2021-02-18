public class Student
{
    private string name;
    private bool isMale;

    public string GetName()
    {
        if (isMale)
        {
            return "мистер " + name;
        }
        else
        {
            return "миссис " + name;
        }
    }

    public void SetName(string name) {
        this.name = name;
    }

}