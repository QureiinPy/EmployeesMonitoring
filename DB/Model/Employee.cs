namespace DB.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public Employee(string name, string surname, string position)
        {
            Name = name;
            Surname = surname;
            Position = position;
        }

        public override string ToString()
        {
            return $"{Name} {Surname} ({Position})";
        }
    }
}
