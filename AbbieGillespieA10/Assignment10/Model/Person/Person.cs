namespace Assignment10.Model.Person
{
    /// <summary>
    /// Creates a person object.
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the home address.
        /// </summary>
        public Address.Address HomeAddress { get; set; }

        /// <summary>
        /// Initializes a new instance of the Person class.
        /// </summary>
        protected Person()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Person class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        public Person(string firstName, string lastName) : this(firstName, lastName, 0, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Person class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="id">The identifier.</param>
        public Person(string firstName, string lastName, int id) : this(firstName, lastName, id, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Person class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="homeAddress">The home address.</param>
        /// <exception cref="System.ArgumentNullException">
        /// firstName or lastName
        /// </exception>
        public Person(string firstName, string lastName, int id, Address.Address homeAddress)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            Id = id;
            HomeAddress = homeAddress;
        }

        /// <summary>
        /// Gets the details.
        /// </summary>
        public abstract string Details { get; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A string that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{FirstName} {LastName} : ID - {Id}";
        }
    }
}
