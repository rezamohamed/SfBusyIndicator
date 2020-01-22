using Prism.Navigation;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PopupAcceptDecline.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        //public Command ShowPopupCommand => new Command(ShowPopup);
        public Command ShowBusyCommand => new Command(async () =>
        {
            ShowBusy(true);

            await Task.Delay(3000);

            ShowBusy(false);
        });

        public Command NavigatePageBCommand => new Command(async () => await NavigationService.NavigateAsync("PageB"));


        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }


        public override void OnNavigatedTo(INavigationParameters parameters)
        {

            //ShowBusy(true);

            //await Task.Delay(3000);

            //ShowBusy(false);
        }


        //private void ShowPopup(object obj)
        //{
        //    var returnbool = DisplayAlert("Testing", "Testing accept decline", "Accept", "Decline");

        //    ChangeLabel = returnbool.ToString();
        //}
    }
}
