using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLib {
    public class Institute {

        public Guid ID { get; set; }
        public string Name { get; set; }
        public int YearsInService { get; set; }

        public Institute() {
            ID= Guid.NewGuid();
        }

        public void GetName() {

        }

        public void SetName(string name) {

        }
    }
}
