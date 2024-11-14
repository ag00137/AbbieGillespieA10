using Assignment10.Model.Address;
using Assignment10.Model.Person;

namespace Assignment10.View
{
    /// <summary>
    /// The main form code behind.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes the component and calls the demo method.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            Demo();
        }

        private void Demo()
        {
            var address1 = new Address("123 Salem St", "Carrollton", "GA", 30117);
            var address2 = new Address("234 Main St", "Carrollton", "GA", 30117);

            var teacher = new Teacher("John", "Doe", 1, address1, "Computer Science");
            var student = new Student("Jane", "Doe", 2, address2, "Computer Science");
            var staff = new Staff("Bob", "Doe", 3, address2, "Principal");

            var everyone = new List<Person> { teacher, student, staff };

            outputTextBox.Clear();

            foreach (var person in everyone)
            {
                outputTextBox.AppendText(person.Details + Environment.NewLine);
            }
        }
    }
}