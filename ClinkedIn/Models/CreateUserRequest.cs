namespace ClinkedIn.Models
{
    public class CreateUserRequest
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string NickName { get; set; }
        public string Type { get; set; }
    }
}
