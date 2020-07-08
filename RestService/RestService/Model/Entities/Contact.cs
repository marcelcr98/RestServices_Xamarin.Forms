
using System;
namespace RestService
{
	public class Contact : ObservableBaseObject
	{

		private string id;

		public string ID
		{
			get { return id.Trim(); }
			set { id = value.Trim(); OnPropertyChanged(); }
		}


		private string fullName;

		public string FullName
		{
			get { return fullName; }
			set { fullName = value; OnPropertyChanged(); }
		}

		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; OnPropertyChanged(); }
		}


		private string phoneNumber;

		public string PhoneNumber
		{
			get { return phoneNumber; }
			set { phoneNumber = value; OnPropertyChanged(); }
		}

	}
}