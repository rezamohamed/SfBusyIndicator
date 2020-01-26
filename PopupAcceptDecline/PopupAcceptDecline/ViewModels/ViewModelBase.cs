using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services.Dialogs;

namespace PopupAcceptDecline.ViewModels
{
    public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
    {
        protected INavigationService NavigationService { get; private set; }
        protected IDialogService DialogService { get; set; } 

        public string Title { get; set; }

        private  string returnResult { get; set; }


        public ViewModelBase(INavigationService navigationService, IDialogService dialogService)
        {
            NavigationService = navigationService;
            DialogService = dialogService;

        }

        protected string DisplayAlert(string message)
        {
            var param = new DialogParameters() { { "message", $"{message}" } };


            DialogService.ShowDialog("SampleDialogA", new DialogParameters { { "message", "Hello from Main" } }, ClosePopup);



            return returnResult;
        }

        private void ClosePopup(IDialogResult obj)
        { 
            returnResult = obj.Parameters.GetValue<string>("return");
        }




        public virtual void Initialize(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }
    }
}

 
