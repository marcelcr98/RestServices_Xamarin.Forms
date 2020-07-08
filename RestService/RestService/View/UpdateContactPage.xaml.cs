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
    public partial class UpdateContactPage : ContentPage
    {
        public UpdateContactPage(Contact contact)
        {
            InitializeComponent();
            this.BindingContext = new UpdateContactVM(contact);
        }
    }
}