namespace TheSharpFactory.Apps.Shared.ViewModels.Conventional
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; } = "";

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
