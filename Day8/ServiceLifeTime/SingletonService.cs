namespace Day8.ServiceLifeTime
{
    public class SingletonService : ISingletonService
    {
        public string Message { get; set; }
        public SingletonService()
        {
            Message = Guid.NewGuid().ToString();
        }
    }
}
