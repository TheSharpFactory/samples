namespace TheSharpFactory.Apps.Shared.Services
{
    public class CounterService
        : ICounterService
    {
        public int Count { get; set; } = 0;
        public bool CanDecrement
            => Count > 0;

        public bool CanIncrement
            => Count >= 0 && Count < 100;

        public void Increment(int count = 1)
            => Count += count;

        public void Decrement(int count = 1)
            => Count -= count;
    }
}
