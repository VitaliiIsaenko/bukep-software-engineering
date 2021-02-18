public class Person {
    protected string name;
    protected int age;

    public void SetName(string name) {
        this.name = name;
    }

    public virtual string GetName(){
        return name;
    }
}