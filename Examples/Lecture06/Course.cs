using System;

public class Course {
    public string Name {get;}
    protected string location;
    private int studentsAmount;
    private University university;

    public Course(University university, string name, string location) {
        Name = name;
        this.university = university;
        this.location = location;
    }

    public virtual string GetLocation() {
        return $"{university.Address} {location}";
    }
}

    // private Student[] students = new Student[30];
    // public void AddStudent(Student student) {
    //     students[studentsAmount] = student;
    //     studentsAmount++;
    // }
// }