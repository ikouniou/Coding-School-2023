using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University {
    public class Person {

        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public Person() {

        }

        public Person(Guid id) {
            ID = id;
        }


        public void GetName() {

        }

        public void SetName(string name) {

        }
    }
}
