using MvvmCross.Forms.Views.Attributes;
using Xamarin.Forms.Xaml;

namespace ConnectContacts.Views
{
    [MvxContentPagePresentation()]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomeView
    {
        public WelcomeView()
        {
            InitializeComponent();
        }
    }
}