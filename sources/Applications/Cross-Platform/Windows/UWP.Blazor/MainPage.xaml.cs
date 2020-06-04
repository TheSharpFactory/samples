namespace TheSharpFactory.Apps.Cross.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            LoadApplication(new SharedUI.BlazorApp());
        }
    }
}
