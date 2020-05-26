namespace TravisSampleLibrary
{
    public class HardCodeAuthorize
    {
        private string _username { get; set; }
        private string _password { get; set; }

        public HardCodeAuthorize()
        {
            _username = "user";
            _password = "pass";
        }

        public bool Auth(string username, string password)
        {
            return true; // uncomment for bug
            //return (username == _username) && (password == _password);
        }
    }
}