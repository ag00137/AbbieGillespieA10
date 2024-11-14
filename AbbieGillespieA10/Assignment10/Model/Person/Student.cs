namespace Assignment10.Model.Person
{
    /// <summary>
    /// Creates a student object.
    /// </summary>
    /// Inherits from the Person class.
    public class Student : Person
    {
        private const string Undeclared = "Undeclared";

        /// <summary>
        /// The major of the student.
        /// </summary>
        public string Major;

        /// <summary>
        /// Gets or sets the major.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">major</exception>
        public string major
        {
            get => Major;
            set => Major = value == null ? throw new ArgumentNullException(nameof(major)) : (string.IsNullOrEmpty(value) ? Undeclared : value);
        }

        /// <summary>
        /// The minor of the student.
        /// </summary>
        public string Minor;

        /// <summary>
        /// Gets or sets the minor.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">minor</exception>
        public string minor
        {
            get => Minor;
            set => Minor = value == null ? throw new ArgumentNullException(nameof(minor)) : (string.IsNullOrEmpty(value) ? Undeclared : value);
        }

        /// <summary>
        /// Prevents a default instance of the Student class from being created.
        /// </summary>
        private Student()
        {

        }

        /// <summary>
        /// Initializes a new instance of the Student class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        public Student(string firstName, string lastName) : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Student class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="id">The identifier.</param>
        public Student(string firstName, string lastName, int id) : this(firstName, lastName, id, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Student class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="homeAddress">The home address.</param>
        public Student(string firstName, string lastName, int id, Address.Address homeAddress) : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Student class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="homeAddress">The home address.</param>
        /// <param name="major">The major.</param>
        /// <exception cref="System.ArgumentNullException">major</exception>
        public Student(string firstName, string lastName, int id, Address.Address homeAddress, string major) : base(firstName, lastName, id, homeAddress)
        {
            Major = major ?? throw new ArgumentNullException(nameof(major));
            Minor = Undeclared;
        }

        /// <summary>
        /// Gets the details and turns them into a string.
        /// </summary>
        public override string Details
        {
            get
            {
                return $"{FirstName} {LastName} ({Id})\n{HomeAddress}\nMajor: {Major}" + (Minor != "Undeclared" ? $", Minor: {Minor}" : string.Empty);
            }
        }
    }
}
