using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RestService.ViewModel
{
	public class MainPageViewModel : ObservableBaseObject
	{

		private ContactsRestService contactsRestService;

		private List<Contact> contacts;

		public List<Contact> Contacts
		{
			get { return contacts; }
			set { contacts = value; OnPropertyChanged(); }
		}

		private bool isBusy;

		public bool IsBusy
		{
			get { return isBusy; }
			set { isBusy = value; OnPropertyChanged(); }
		}

		public ICommand GetContactsCommand
		{
			get;
			set;
		}

		public ICommand DeleteContactCommand
		{
			get;
			set;
		}

		public MainPageViewModel()
		{
			Init();
		}

		void Init()
		{
			contactsRestService = new ContactsRestService();
			GetContactsCommand = new Command(() => getContacts());
			DeleteContactCommand = new Command((obj) => deleteContact((Contact)obj));
		}

		async Task deleteContact(Contact contact)
		{
			await contactsRestService.DeleteContacts(contact);
		}

		async Task getContacts()
		{
			Contacts = await contactsRestService.GetContacts();
		}

	}
}