using Syncfusion.XForms.PopupLayout;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PopupAcceptDecline.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BusyIndicator : StackLayout
    {
        public static readonly BindableProperty IsBusyProperty =
            BindableProperty.Create(nameof(xIsBusy), typeof(bool), typeof(BusyIndicator), default(bool));

        public bool xIsBusy
        {
            get => (bool)GetValue(IsBusyProperty);
            set => SetValue(IsBusyProperty, value);
        }


        public BusyIndicator()
        {
            InitializeComponent();


            // I cant access ctrlBusyIndicator here:
            //ctrlBusyIndicator.SetBinding(SfBusyIndicator.IsBusyProperty, new Binding("xIsBusy", source: this));
        }


        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);



            if (propertyName == nameof(xIsBusy))
            {
                //ctrlPopupLayout.SetBinding(SfPopupLayout.IsOpenProperty, new Binding("xIsBusy"));
                //ctrlPopupLayout.Show();

                ctrlPopupLayout.IsOpen = true;
            }

        }
    }
}