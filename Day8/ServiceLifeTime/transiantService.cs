namespace Day8.ServiceLifeTime
{
    public class transiantService : ItransiantService
    {
        public string Message { get; set; }
        public transiantService()
        {
            Message = Guid.NewGuid().ToString();
        }
    }
}
