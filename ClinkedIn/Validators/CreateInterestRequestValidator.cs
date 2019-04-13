using ClinkedIn.Models;

namespace ClinkedIn.Validators
{
    public class CreateInterestRequestValidator
    {
        public bool InterestValidate(CreateInterestRequest interestRequest)
        {
            return string.IsNullOrEmpty(interestRequest.Name);
        }
    }
}