namespace LoanX.Domain
{
    public class Customer
    {
        public string CustomerId { get; private set; }
        public string FullName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string PanNumber { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        public int CreditScore { get; private set; }

        public Customer(
            string customerId,
            string fullName,
            DateTime dateOfBirth,
            string panNumber,
            string email,
            string phone,
            string address,
            int creditScore)
        {
            CustomerId = customerId;
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            PanNumber = panNumber;
            Email = email;
            Phone = phone;
            Address = address;
            CreditScore = creditScore;
        }

        public void UpdateContactDetails(string email, string phone, string address)
        {
            Email = email;
            Phone = phone;
            Address = address;
        }
    }
}
