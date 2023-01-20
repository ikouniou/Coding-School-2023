using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib {
    public class University : Institute {

        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduledCourse{ get; set; }

        public University() {

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
}
