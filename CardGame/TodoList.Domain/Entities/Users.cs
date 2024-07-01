namespace CardGame.Domain.Entities
{
    public class Users : Entity
    {
        public string login { get; set; }
        public string email { get; set; }
        public string passwd { get; set; }
        public string status { get; set; }
        public int cash { get; set; }
        public DateTime dateRegistration { get; set; }

        public Users(string login, string email, string passwd, string status, int cash) : this(login, email, passwd, status)
        {
            this.cash = cash;
        }

        public Users(string login, string email, string passwd, string status) : this(login, email, passwd)
        {
            this.status = status;
        }

        public Users(string login, string email, string passwd)
        {
            this.login = login;
            this.email = email;
            this.passwd = passwd;
        }
    }
}
