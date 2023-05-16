using Wpf.Ui.Common.Interfaces;

namespace UiDesktopApp1.Views.Pages
{
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class CargasPages : INavigableView<ViewModels.CargasViewModel>
    {
        public ViewModels.CargasViewModel ViewModel
        {
            get;
        }

        public CargasPages(ViewModels.CargasViewModel viewModel)
        {
            ViewModel = viewModel;

            InitializeComponent();
        }
    }
}