
using TheSharpFactory.Apps.Cross.SharedUI;

using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace TheSharpFactory.Apps.Cross.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
        : FormsApplicationPage
	{
		public MainWindow()
		{
			InitializeComponent();
            Forms.Init();
            LoadApplication(new BlazorApp());
		}
	}
}
