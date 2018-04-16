using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Droid.Platform;
using MvvmCross.Forms.Platform;

namespace ConnectContacts.Droid
{
    public class Setup : MvxFormsAndroidSetup
    {
        public Setup(Context applicationContext)
            : base(applicationContext)
        {
        }


        protected override IMvxApplication CreateApp()
        {
            return new CoreApp();
        }

        protected override MvxFormsApplication CreateFormsApplication()
        {
            return new App();
        }
    }
}