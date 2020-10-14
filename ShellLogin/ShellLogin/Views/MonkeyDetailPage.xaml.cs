using Xamarin.Forms;
using ShellLogin. ViewModels;

namespace ShellLogin. Views
{
    public partial class MonkeyDetailPage : ContentPage
    {
        public MonkeyDetailPage()
        {
            InitializeComponent();
            BindingContext = new MonkeyDetailViewModel();
        }
    }
}
