using Cirrious.MvvmCross.ViewModels;

namespace Lectionary.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		private string _firstName;
        public string FirstName
		{ 
			get { return _firstName; }
            set { _firstName = value; RaisePropertyChanged(() => FirstName); RaisePropertyChanged(() => FullName); }
		}


        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; RaisePropertyChanged(() => LastName); RaisePropertyChanged(() => FullName); }
        }

        public string FullName
        {
            get { return string.Format("{0} {1}", _firstName, _lastName); }
        }


        private const string _pageTitle = "Taka �mieszna strona!";
        public string PageTitle
        {
            get { return _pageTitle; }
        }

        private const string _applicationTitle = "Super Lekcjonarz";
        public string ApplicationTitle
        {
            get { return _applicationTitle; }
        }

        
    }
}
