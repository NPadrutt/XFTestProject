using ConnectContacts.ViewModels;
using MvvmCross.Core.ViewModels;

namespace ConnectContacts
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            RegisterNavigationServiceAppStart<WelcomeViewModel>();
        }
    }
}
