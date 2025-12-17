namespace LoanX.Domain
{
    public class PersonalLoan : LoanProduct
    {
        public PersonalLoan()
            : base(
                productId: "PL",
                name: "Personal Loan",
                interestRate: 12.0m,
                maxAmount: 500000m,
                minCreditScore: 650,
                maxTenureMonths: 60)
        {
        }
    }
}
