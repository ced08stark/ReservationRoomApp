namespace Catalogue.web.Models
{
    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RemenberMe { get; set; }
        public string ReturnUrl { get; set; }
    }
}
