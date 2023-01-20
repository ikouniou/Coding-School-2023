using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib {
    public class Professor : Person {

        public string? Rank { get; set; }
        public List<Course> Courses{ get; set; }

        public Professor() {
            Courses= new List<Course>();
        }


        public void Teach(Course course, DateTime dateTime) {

        }

        public void SetGrade(Guid studentID, Guid courseID, int grade) {

        }

        public void GetName() {

        }
    }
}
