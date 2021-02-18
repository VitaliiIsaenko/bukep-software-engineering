public class RemoteCourse  : Course {
    public RemoteCourse(University university, string name, string location) : base(university, name, location)
    {
    }

    public override string GetLocation()
    {
        return location;
    }
}