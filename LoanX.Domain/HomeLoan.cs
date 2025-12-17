namespace LoanX.Domain
{
    public class HomeLoan : LoanProduct
    {
        public HomeLoan()
            : base(
                productId: "HL",
                name: "Home Loan",
                interestRate: 8.2m,
                maxAmount: 10000000m,
                minCreditScore: 700,
                maxTenureMonths: 360)
        {
        }

        public override bool ValidateApplication(LoanApplication application)
        {
            if (!base.ValidateApplication(application))
                return false;

            if (application.CollateralValue == null)
                return false;

            return application.CollateralValue >= application.RequestedAmount * 1.2m;
        }
    }
}
