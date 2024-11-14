namespace Assignment10.Model.Person
{
    /// <summary>
    /// Creates a new Staff object.
    /// </summary>
    /// Inherits from the Person class.
    public class Staff : Person
    {
        private string Title;

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <exception>ArgumentNullException</exception>
        public string title
        {
            get => Title;
            set => Title = !string.IsNullOrEmpty(value) ? value : throw new ArgumentNullException(nameof(value));
        }

        private Staff()
        {

        }

        /// <summary>
        /// Initializes a new instance of the staff class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        public Staff(string firstName, string lastName) : this(firstName, lastName, 0, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the staff class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="id">The identifier.</param>
        public Staff(string firstName, string lastName, int id) : this(firstName, lastName, id, null, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the staff class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="homeAddress">The home address.</param>
        public Staff(string firstName, string lastName, int id, Address.Address homeAddress) : this(firstName, lastName, id, homeAddress, string.Empty)
        {
        }

        /// <summary>
        /// Initializes a new instance of the staff class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="homeAddress">The home address.</param>
        /// <param name="title">The title.</param>
        /// <exception cref="System.ArgumentNullException">title</exception>
        public Staff(string firstName, string lastName, int id, Address.Address homeAddress, string title) : base(firstName, lastName, id, homeAddress)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Gets the details and puts them in a string.
        /// </summary>
        public override string Details
        {
            get
            {
                return $"{FirstName} {LastName} ({Id}/{title})\n{HomeAddress}";
            }
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A string that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{FirstName} {LastName} : ID - {Id}; Title - {title}";
        }
    }
}
