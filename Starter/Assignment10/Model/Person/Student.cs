namespace Assignment10.Model.Person
{
    public class Student : Person
    {
        private const string Undeclared = "Undeclared";

        public string Major;
        public string major
        {
            get => Major;
            set => Major = !string.IsNullOrEmpty(value) ? value : Undeclared;
        }

        public string Minor;
        public string minor
        {
            get => Minor;
            set => Minor = value == null ? throw new ArgumentNullException(nameof(minor)) : (string.IsNullOrEmpty(value) ? Undeclared : value);
        }

        private Student()
        {

        }

        public Student(string firstName, string lastName) : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        public Student(string firstName, string lastName, int id) : this(firstName, lastName, id, null, string.Empty)
        {
        }

        public Student(string firstName, string lastName, int id, Address.Address homeAddress) : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        public Student(string firstName, string lastName, int id, Address.Address homeAddress, string major) : base(firstName, lastName, id, homeAddress)
        {
            Major = major ?? throw new ArgumentNullException(nameof(major));
            Minor = Undeclared;
        }


        public override string Details
        {
            get
            {
                return $"{FirstName} {LastName} ({Id})\n{HomeAddress}\nMajor: {Major}" + (Minor != "Undeclared" ? $", Minor: {Minor}" : string.Empty);
            }
        }
    }
}
