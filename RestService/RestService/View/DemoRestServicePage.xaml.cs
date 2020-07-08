using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RestService.ViewModel;

namespace RestService.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DemoRestServicePage : ContentPage
    {
		public DemoRestServicePage()
		{
			InitializeComponent();
			this.BindingContext = new MainPageViewModel();
		}

		void AddContact_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new AddContactPage());
		}

		void Contact_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			Navigation.PushAsync(new UpdateContactPage((Contact)e.Item));
		}
	}
}