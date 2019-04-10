using ClinkedIn.Models;

namespace ClinkedIn.Validators
{
    public class CreateUserRequestValidator
    {
        public bool UserValidate(CreateUserRequest userRequest)
        {
            return string.IsNullOrEmpty(userRequest.Name)
                || string.IsNullOrEmpty(userRequest.Password)
                || string.IsNullOrEmpty(userRequest.Gender)
                || string.IsNullOrEmpty(userRequest.NickName)
                || string.IsNullOrEmpty(userRequest.Type);
        }
    }
}
