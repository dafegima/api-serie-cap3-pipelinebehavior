namespace Domain.Entities
{
	public class Customer
	{
        public Customer(string identification, string firstName, string lastName, string email, DateTime birthDate, string address, string city, string country)
        {
            Identification = identification;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDate = birthDate;
            Address = address;
            City = city;
            Country = country;
        }

        public string Identification { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }
    }
}