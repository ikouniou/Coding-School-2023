using System;

public class University : Institute{

    public Student[] Students { get; set; }
    public Course[] Courses { get; set; }
    public Grade[] Grades { get; set; }
    public Schedule[] ScheduledCourse { get; set; }

    public University() {

    }

    public University(Guid id) : base(id) {

    }

    public University(Guid id, string name) : base(id, name){

    }

    public University(Guid id, string name, int yearsInService) : base(id, name, yearsInService) {

    }

    public University(Guid id, string name, int yearsInService, Student[] students) : base(id, name, yearsInService) {
        Students = new Student[30];
        Students = students;
    }

    public University(Guid id, string name, int yearsInService, Student[] students, Course[] courses) : base(id, name, yearsInService) {
        Students = new Student[30];
        Students = students;
        Courses = new Course[20];
        Courses = courses;
    }

    public University(Guid id, string name, int yearsInService, Student[] students, Course[] courses, Grade[] grades) : base(id, name, yearsInService) {
        Students = new Student[30];
        Students = students;
        Courses = new Course[20];
        Courses = courses;
        Grades = new Grade[50];
        Grades = grades;
    }

    public University(Guid id, string name, int yearsInService, Student[] students, Course[] courses, Grade[] grades, Schedule[] scheduledCourse) : base(id, name, yearsInService) {
        Students = new Student[30];
        Students = students;
        Courses = new Course[20];
        Courses = courses;
        Grades = new Grade[50];
        Grades = grades;
        ScheduledCourse = new Schedule[60];
        ScheduledCourse = scheduledCourse;
    }

    public void GetStudents() {

    }

    public void GetCourses() {

    }

    public void GetGrades() { 
    
    }

    public void SetSchedule(Guid courseID, Guid professorID, DateTime dateTime) {

    }
}
