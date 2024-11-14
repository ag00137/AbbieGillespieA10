namespace Assignment10.Model.Address
{
    /// <summary>
    /// Creates a new address object.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or sets the street.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the zip.
        /// </summary>
        public int Zip { get; set; }

        /// <summary>
        /// Initializes a new instance of the Address class.
        /// </summary>
        public Address() : this(string.Empty, string.Empty, string.Empty, 0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Address class.
        /// </summary>
        /// <param name="street">The street.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zip">The zip.</param>
        /// <exception cref="System.ArgumentNullException">
        /// street or city or state
        /// </exception>
        public Address(string street, string city, string state, int zip)
        {
            Street = street ?? throw new ArgumentNullException(nameof(street));
            City = city ?? throw new ArgumentNullException(nameof(city));
            State = state ?? throw new ArgumentNullException(nameof(state));
            Zip = zip;
        }

        /// <summary>
        /// Converts details to a string.
        /// </summary>
        /// <returns>
        /// A string that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return State + Environment.NewLine + City + ", " + State + Environment.NewLine + Zip + Environment.NewLine;
        }
    }
}
