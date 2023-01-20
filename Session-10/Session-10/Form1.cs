using UniversityLib;

namespace Session_10 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            University university = new University() {
                Name = "University of Portsmouth"
            };


            Student student = new Student() {
                Name = "Fotis",
                Age = 44
            };

            university.Students.Add(student);


            Serializer serializer = new Serializer();
            serializer.SerializeToFile(university, "test.json");


            university = serializer.Deserialize<University>("test.json");
        }
    }
}