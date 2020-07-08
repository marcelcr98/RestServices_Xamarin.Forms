using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RestService.ViewModel
{
	public class UpdateContactVM : ObservableBaseObject
	{

		private ContactsRestService contactsRestService;

		private Contact contact;

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

		public ICommand UpdateContactCommand
		{
			get;
			set;
		}


		public UpdateContactVM(Contact contact)
		{
			Init(contact);
		}

		void Init(Contact contact)
		{
			contactsRestService = new ContactsRestService();
			UpdateContactCommand = new Command(() => updateContact());
			this.contact = contact;
		}

		async Task updateContact()
		{
			await contactsRestService.UpdateContacts(Contact);
		}

	}
}