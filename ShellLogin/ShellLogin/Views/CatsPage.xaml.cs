using System.Linq;
using System;
using Xamarin.Forms;
using ShellLogin.Data;
using ShellLogin.Models;
using Xamarin.Forms.Xaml;

namespace ShellLogin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    //[QueryProperty("Name", "name")]
    public partial class CatsPage : ContentPage
    {
        public string Name
        {
            set
            {
                BindingContext = CatData.Cats.FirstOrDefault(m => m.Name == Uri.UnescapeDataString(value));
            }
        }

        public CatsPage()
        {
           InitializeComponent();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string catName = (e.CurrentSelection.FirstOrDefault() as Animal).Name;
            // This works because route names are unique in this application.
            await Shell.Current.GoToAsync($"catdetails?name={catName}");
            // The full route is shown below.
            // await Shell.Current.GoToAsync($"//animals/domestic/cats/catdetails?name={catName}");
        }
    }
}
