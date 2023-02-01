namespace Day8.ServiceLifeTime
{
    public class ScopedService : IScopedService
    {
        public string Message { get; set; }
        public ScopedService()
        {
            Message = Guid.NewGuid().ToString();
        }
    }
}
