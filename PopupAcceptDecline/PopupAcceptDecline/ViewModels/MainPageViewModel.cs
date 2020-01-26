using Prism.Navigation;
using Prism.Services.Dialogs;
using Xamarin.Forms;

namespace PopupAcceptDecline.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        //private readonly IDialogService _dialogService;


        public string ReturnMessage { get; set; }

        public Command ShowPopupCommand => new Command(ShowPopup);



        public MainPageViewModel(INavigationService navigationService, IDialogService dialogService)
            : base(navigationService, dialogService)
        {

            Title = "Main Page";
        }


        public override void OnNavigatedTo(INavigationParameters parameters)
        {
        }


        private void ShowPopup()
        {
            var result = DisplayAlert("message from Main View Model");

            ReturnMessage = result;

        }


    }
}
