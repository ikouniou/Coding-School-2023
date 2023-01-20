using UniversityLib;

namespace Session_10 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            PopulateUniversity();
            SetControlProperties();

        }
        public void PopulateUniversity() {

            University university = new University() {
                Name = "Aristotle University of Thessaloniki"
            };

            Course course1 = new Course() {
                Code = "12222",
                Subject = "Algorithms"
            };

            Course course2 = new Course() {
                Code = "15656",
                Subject = "Digital Design"
            };

            Student student1 = new Student() {
                Name = "Ioanna Kouniou",
                Age = 23,
                RegistrationNumber = 13135
            };

            student1.Courses.Add(course1);

            Student student2 = new Student() {
                Name = "Thanasis Papadopoulos",
                Age = 25,
                RegistrationNumber = 14781
            };

            Grade grade1 = new Grade() {
                StudentID = student1.ID,
                CourseID = course1.ID,
                GradeCourse = 10
            };

            Grade grade2 = new Grade() {
                StudentID = student2.ID,
                CourseID = course2.ID,
                GradeCourse = 7
            };

            Schedule schedule1 = new Schedule() {
                CourseID = course1.ID,
                ProfessorID = Guid.NewGuid(),
                Callendar = DateTime.Now
            };

            Schedule schedule2 = new Schedule() {
                CourseID = course2.ID,
                ProfessorID = Guid.NewGuid(),
                Callendar = DateTime.Now
            };

            student2.Courses.Add(course2);

            university.Students.Add(student1);
            university.Students.Add(student2);

            university.Courses.Add(course1);
            university.Courses.Add(course2);

            university.Grades.Add(grade1);
            university.Grades.Add(grade2);

            university.ScheduledCourse.Add(schedule1);
            university.ScheduledCourse.Add(schedule2);


            bsStudents.DataSource = university.Students;
            bsCourses.DataSource = university.Courses;
            bsGrades.DataSource = university.Grades;
            bsScheduledCourse.DataSource = university.ScheduledCourse;



            //Serializer serializer = new Serializer();
            //serializer.SerializeToFile(university, "test.json");


            //university = serializer.Deserialize<University>("test.json");
        }

        private void SetControlProperties() {
            dgvStudents.AutoGenerateColumns = false;
            dgvCourses.AutoGenerateColumns = false;
            dgvGrades.AutoGenerateColumns = false;
            dgvScheduledCourse.AutoGenerateColumns = false;

            dgvStudents.DataSource = bsStudents;
            dgvCourses.DataSource = bsCourses;
            dgvGrades.DataSource = bsGrades;
            dgvScheduledCourse.DataSource = bsScheduledCourse;


        }

        private void label2_Click(object sender, EventArgs e) {

        }
    }
}