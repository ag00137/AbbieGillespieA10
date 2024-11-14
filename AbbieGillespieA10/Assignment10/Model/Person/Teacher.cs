namespace Assignment10.Model.Person
{
    /// <summary>
    /// Creates a teacher object.
    /// </summary>
    /// Inherits from the Person class
    public class Teacher : Person
    {
        private string Department;

        /// <summary>
        /// Gets or sets the department.
        /// </summary>
        public string department
        {
            get => Department;
            set => Department = !string.IsNullOrEmpty(value) ? value : "Unknown";
        }

        /// <summary>
        /// Prevents a default instance of the Teacher class from being created.
        /// </summary>
        private Teacher()
        {

        }

        /// <summary>
        /// Initializes a new instance of the Teacher class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        public Teacher(string firstName, string lastName) : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Teacher class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="id">The identifier.</param>
        public Teacher(string firstName, string lastName, int id) : this(firstName, lastName, id, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Teacher class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="homeAddress">The home address.</param>
        public Teacher(string firstName, string lastName, int id, Address.Address homeAddress) : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Teacher class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="homeAddress">The home address.</param>
        /// <param name="department">The department.</param>
        /// <exception cref="System.ArgumentNullException">department</exception>
        public Teacher(string firstName, string lastName, int id, Address.Address homeAddress, string department) : base(firstName, lastName, id, homeAddress)
        {
            Department = department ?? throw new ArgumentNullException(nameof(department));
        }

        /// <summary>
        /// Gets the details and turns them into a string.
        /// </summary>
        public override string Details
        {
            get
            {
                return $"{FirstName} {LastName} ({Id})\n{HomeAddress}\nDepartment: {Department}";
            }
        }
    }
}
