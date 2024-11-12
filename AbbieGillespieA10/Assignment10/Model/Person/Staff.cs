namespace Assignment10.Model.Person
{
    public class Staff : Person
    {
        public string Title;
        public string title
        {
            get => title;
            set => title = !string.IsNullOrEmpty(value) ? value : throw new ArgumentNullException(nameof(value));
        }

        private Staff()
        {

        }

        public Staff(string firstName, string lastName) : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        public Staff(string firstName, string lastName, int id) : this(firstName, lastName, id, null, string.Empty)
        {
        }

        public Staff(string firstName, string lastName, int id, Address.Address homeAddress) : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        public Staff(string firstName, string lastName, int id, Address.Address homeAddress, string title) : base(firstName, lastName, id, homeAddress)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }

        public override string Details
        {
            get
            {
                return $"{FirstName} {LastName} ({Id}/{title})\n{HomeAddress}";
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} : ID - {Id}; Title - {title}";
        }
    }
}
