using System;

public class Student : Person{
    public int RegistrationNumber { get; set; }
    public Course[] Courses { get; set; }

    public Student() {

    }

    public Student(Guid id) : base(id) {

    }

    public Student(Guid id, string name) : base(id, name) {

    }

    public Student(Guid id, string name, int age) : base(id, name, age) {

    }

    public Student(Guid id, string name, int age, int registrationNumber) : base(id, name, age) {
        RegistrationNumber = registrationNumber;
    }

    public Student(Guid id, string name, int age, int registrationNumber, Course[] courses) : base(id, name, age) {
        RegistrationNumber = registrationNumber;
        Courses = new Course[20];
        Courses = courses;
    }

    public void Attend(Course course, DateTime dateTime) {

    }

    public void WriteExam(Course course, DateTime dateTime) {

    }


}
