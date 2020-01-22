using Prism.Navigation;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PopupAcceptDecline.ViewModels
{
    public class PageBViewModel : ViewModelBase
    {
        public string ChangeLabel { get; set; } = "Page B";

        public Command MainPageCommand => new Command(async () => await NavigationService.GoBackAsync());


        public PageBViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Page with API call's";
        }

        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            ShowBusy(true);

            await Task.Delay(3000);

            ShowBusy(false);
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);

        }


    }

}
