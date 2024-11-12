namespace Assignment10.Model.Person
{
    public class Teacher : Person
    {
        public string Department { get; }
        public string department
        {
            get => department;
            set => department = !string.IsNullOrEmpty(value) ? value : "Unknown";
        }

        private Teacher()
        {

        }

        public Teacher(string firstName, string lastName) : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        public Teacher(string firstName, string lastName, int id) : this(firstName, lastName, id, null, string.Empty)
        {
        }

        public Teacher(string firstName, string lastName, int id, Address.Address homeAddress) : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        public Teacher(string firstName, string lastName, int id, Address.Address homeAddress, string department) : base(firstName, lastName, id, homeAddress)
        {
            Department = department ?? throw new ArgumentNullException(nameof(department));
        }

        public override string Details
        {
            get
            {
                return $"{FirstName} {LastName} ({Id})\n{HomeAddress}\nDepartment: {Department}";
            }
        }
    }
}
