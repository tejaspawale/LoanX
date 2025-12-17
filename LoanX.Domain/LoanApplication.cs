using System.Runtime.InteropServices;

namespace LoanX.Domain
{
    public class LoanApplication
    {
        public string ApplicationId { get; private set; }
        public Customer Applicant { get; private set; }
        public decimal RequestedAmount { get; private set; }
        public int RequestedTenureMonths { get; private set; }
        public decimal? CollateralValue { get; private set; }
        public LoanStatus Status { get; private set; }
        public DateTime CreatedDate { get; private set; }

        public LoanApplication(
            string applicationId,
            Customer applicant,
            decimal requestedAmount,
            int requestedTenureMonths,
            decimal? collateralValue = null)
        {
            ApplicationId = applicationId;
            Applicant = applicant;
            RequestedAmount = requestedAmount;
            RequestedTenureMonths = requestedTenureMonths;
            CollateralValue = collateralValue;
            Status = LoanStatus.Draft;
            CreatedDate = DateTime.UtcNow;
        }

        public void Submit()
        {
            if (Status != LoanStatus.Draft)
                throw new InvalidOperationException("Only draft applications can be submitted.");

            Status = LoanStatus.Submitted;
        }

        public void MarkUnderReview()
        {
            if (Status != LoanStatus.Submitted)
                throw new InvalidOperationException("Application must be submitted first.");

            Status = LoanStatus.UnderReview;
        }

        public void Approve()
        {
            if (Status != LoanStatus.UnderReview)
                throw new InvalidOperationException("Application must be under review.");

            Status = LoanStatus.Approved;
        }

        public void Reject()
        {
            if (Status != LoanStatus.UnderReview)
                throw new InvalidOperationException("Application must be under review.");

            Status = LoanStatus.Rejected;
        }
    }
}