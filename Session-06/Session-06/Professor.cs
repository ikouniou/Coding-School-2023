using System;

public class Professor : Person {
    
    public string? Rank { get; set; }
    public Course[] Courses { get; set; }

    public Professor() {

    }

    public Professor(Guid id) : base(id){

    }

    public Professor(Guid id, string name) : base(id, name) {

    }

    public Professor(Guid id, string name, int age) : base(id, name, age) {

    }

    public Professor(Guid id, string name, int age, string rank) : base(id, name, age) {
        Rank = rank;
    }

    public Professor(Guid id, string name, int age, string rank, Course[] courses) : base(id, name, age) {
        Rank = rank;
        Courses = new Course[20];
        Courses = courses;
    }

    public void Teach(Course course, DateTime dateTime) {

    }

    public void SetGrade(Guid studentID, Guid courseID, int grade) {

    }

    public void GetName() {

    }
}
