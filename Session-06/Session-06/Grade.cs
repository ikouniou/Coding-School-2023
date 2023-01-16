using System;

public class Grade {

    public Guid ID { get; set; }
    public Guid StudentID { get; set; }
    public Guid CourseID { get; set; }
    public int GradeCourse { get; set; }

    public Grade() {

    }

    public Grade(Guid id) {
        ID = id;
    }

    public Grade(Guid id, Guid studentId) {
        ID = id;
        StudentID = studentId;
    }

    public Grade(Guid id, Guid studentId, Guid courseId) {
        ID = id;
        StudentID = studentId;
        CourseID = courseId;
    }

    public Grade(Guid id, Guid studentId, Guid courseId, int grade) {
        ID = id;
        StudentID = studentId;
        CourseID = courseId;
        GradeCourse = grade;
    }
}
