using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RestService.ViewModel
{
	public class AddContactVM : ObservableBaseObject
	{

		private ContactsRestService contactsRestService;

		private Contact contact = new Contact();

		public Contact Contact
		{
			get { return contact; }
			set { contact = value; OnPropertyChanged(); }
		}

		private bool isBusy;

		public bool IsBusy
		{
			get { return isBusy; }
			set { isBusy = value; OnPropertyChanged(); }
		}

		public ICommand AddContactCommand
		{
			get;
			set;
		}


		public AddContactVM()
		{
			Init();
		}

		void Init()
		{
			contactsRestService = new ContactsRestService();
			AddContactCommand = new Command(() => addContacts());
		}

		async Task addContacts()
		{
			await contactsRestService.AddContacts(Contact);
		}

	}
}