using Prism.Mvvm;
using Prism.Navigation;
using Syncfusion.SfBusyIndicator.XForms;
using Syncfusion.XForms.PopupLayout;
using Xamarin.Forms;

namespace PopupAcceptDecline.ViewModels
{
    public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
    {
        protected INavigationService NavigationService { get; private set; }

        public string Title { get; set; }

        //this is used in the ShowBusy
        private SfPopupLayout _popupLayout;

        //this is used in the DisplayAlert
        //private static bool _displayAlertAcceptDecline;


        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;

            _popupLayout = new SfPopupLayout();
        }


        protected void ShowBusy(bool show)
        {
            if (show)
            {
                DataTemplate contentTemplateView = new DataTemplate(() =>
                {
                    StackLayout stack = new StackLayout();
                    SfBusyIndicator _busyIndicator = new SfBusyIndicator
                    {
                        ViewBoxHeight = 100,
                        ViewBoxWidth = 100,
                        IsBusy = true
                    };
                    stack.Children.Add(_busyIndicator);
                    return stack;
                });

                _popupLayout.PopupView.HeaderTitle = string.Empty;
                _popupLayout.PopupView.ContentTemplate = contentTemplateView;
                _popupLayout.PopupView.ShowHeader = false;
                _popupLayout.PopupView.PopupStyle.BorderColor = Color.Transparent;
                _popupLayout.PopupView.ShowFooter = false;
                _popupLayout.PopupView.ShowCloseButton = false;
                _popupLayout.PopupView.AutoSizeMode = AutoSizeMode.Height;
                _popupLayout.PopupView.BackgroundColor = Color.Transparent;
            }

            _popupLayout.IsOpen = show;

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


//protected bool DisplayAlert(string title, string text, string acceptButtonText, string declineButtonText = null)
//{
//    SfPopupLayout popupMessage = new SfPopupLayout
//    {
//        PopupView =
//        {
//            HeaderTitle = title,
//            AcceptButtonText = declineButtonText,
//            AcceptCommand = new Command(() => _displayAlertAcceptDecline = false),
//            DeclineButtonText = acceptButtonText,
//            DeclineCommand = new Command(() => _displayAlertAcceptDecline = true),
//            AppearanceMode = declineButtonText == null ? AppearanceMode.OneButton : AppearanceMode.TwoButton,
//            AutoSizeMode = AutoSizeMode.Height,
//            WidthRequest = 250,
//            ShowCloseButton = false,
//            ContentTemplate = new DataTemplate(() =>
//            {
//                Label label = new Label
//                {
//                    HorizontalTextAlignment = TextAlignment.Center,
//                    VerticalTextAlignment = TextAlignment.Center,
//                    Text = text,
//                    Padding = 25
//                };
//                return label;
//            })
//        }
//    };

//    popupMessage.Show();

//    return _displayAlertAcceptDecline;
//}

