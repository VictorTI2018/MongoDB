namespace Application.Request.User
{
    public class UserCreateOrUpdateRequest
    {
        public string Name { get; set; }

        public string Email { get; set; } 

        public string Password { get; set; }
    }
}
