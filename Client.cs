namespace redis
{
    public class Client
    {
        public Guid Key { get; private set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public Client()
        {
            Key = Guid.NewGuid();
        }
    }
}
