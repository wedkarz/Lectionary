using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using Lectionary.Core.ViewModels;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;

namespace Lectionary.iOS.Views
{
    [Register("FirstView")]
    public class FirstView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView {BackgroundColor = UIColor.White};

            base.ViewDidLoad();

            var firstNameInput = new UITextField(new RectangleF(0, 0, 320, 40)) {BackgroundColor = UIColor.Yellow};
            Add(firstNameInput);

            var lastNameInput = new UITextField(new RectangleF(0, 50, 320, 40)) {BackgroundColor = UIColor.Yellow};
            Add(lastNameInput);

            var fullNameLabel = new UILabel(new RectangleF(0, 100, 320, 40)) {BackgroundColor = UIColor.Red};
            Add(fullNameLabel);

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(firstNameInput).To(vm => vm.FirstName).TwoWay();
            set.Bind(lastNameInput).To(vm => vm.LastName).TwoWay();
            set.Bind(fullNameLabel).To(vm => vm.FullName).OneWay();
            set.Apply();
        }
    }
}