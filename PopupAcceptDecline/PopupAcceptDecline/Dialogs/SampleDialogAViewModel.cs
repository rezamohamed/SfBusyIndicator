using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using Xamarin.Forms;

namespace PopupAcceptDecline.Dialogs
{
    public class SampleDialogAViewModel : BindableBase, IDialogAware
    {

        public string Message { get; set; }

        public Command AcceptCommand => new Command(() => RequestClose(new DialogParameters { { "return", "accept" } }
));
        public Command DeclineCommand => new Command(() => RequestClose(new DialogParameters { { "return", "decline" } }));

        public Command CloseCommand => new Command(() => RequestClose(null));


        public bool CanCloseDialog()
        {
            return true;

        }

        public void OnDialogClosed()
        {
            //
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            Message = parameters.GetValue<string>("message");
        }

        public event Action<IDialogParameters> RequestClose;
    }
}
