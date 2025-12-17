namespace LoanX.Domain
{
    public abstract class LoanProduct
    {
        public string ProductId { get; protected set; }
        public string Name { get; protected set; }
        public decimal AnnualInterestRate { get; protected set; }
        public decimal MaxAmount { get; protected set; }
        public int MinCreditScore { get; protected set; }
        public int MaxTenureMonths { get; protected set; }

        protected LoanProduct(
            string productId,
            string name,
            decimal interestRate,
            decimal maxAmount,
            int minCreditScore,
            int maxTenureMonths)
        {
            ProductId = productId;
            Name = name;
            AnnualInterestRate = interestRate;
            MaxAmount = maxAmount;
            MinCreditScore = minCreditScore;
            MaxTenureMonths = maxTenureMonths;
        }

        public virtual bool ValidateApplication(LoanApplication application)
        {
            if (application.RequestedAmount > MaxAmount)
                return false;

            if (application.RequestedTenureMonths > MaxTenureMonths)
                return false;

            if (application.Applicant.CreditScore < MinCreditScore)
                return false;

            return true;
        }
    }
}
