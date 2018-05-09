using ConnectContacts.ViewModels;
using MvvmCross.ViewModels;

namespace ConnectContacts
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<WelcomeViewModel>();
        }
    }
}
