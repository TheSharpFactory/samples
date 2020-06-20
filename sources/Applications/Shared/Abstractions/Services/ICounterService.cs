namespace TheSharpFactory.Apps.Shared.Services
{
    public interface ICounterService
    {
        int Count { get; set; }
        bool CanDecrement { get; }
        bool CanIncrement { get; }
        void Increment(int count = 1);
        void Decrement(int count = 1);
    }
}
