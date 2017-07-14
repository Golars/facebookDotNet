namespace Facebook.Entity
{
    public class User
    {
        public User(string id, string name, string email = "", string cover = "")
        {
            Id = id;
            Name = name;
            Email = email;
            Cover = cover;
        }

        public string Id { get; }

        public string Name { get; }

        public string Email { get; }

        public string Cover { get; }
    }
}