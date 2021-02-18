// Разработчик является человеком
public class Developer : Person {

    //Годы опыта
    private int experienceYears;

    public void SetExperienceYears(int experienceYears) {
        if (experienceYears > 0) {
            this.experienceYears = experienceYears;
        }
        throw new System.Exception();
    }

    public int GetExperienceYears() {
        return experienceYears;
    }
    public override string GetName() {
        return "Разработчик " + name;
    }
}