namespace CarServiceCenter.Model
{
    public class Manager : EntityBase
    {
        public Manager(string name, string surname, int salaryPerMonth)
        {
            Name = name;
            Surname = surname;
            SalaryPerMonth = salaryPerMonth;

            Engineers = new List<Engineer>();
            Transactions = new List<Transaction>();
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int SalaryPerMonth { get; set; }

        public List<Engineer> Engineers { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
