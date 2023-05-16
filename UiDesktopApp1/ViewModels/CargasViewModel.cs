using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Windows.Input;
using Wpf.Ui.Common.Interfaces;

namespace UiDesktopApp1.ViewModels
{
    public partial class CargasViewModel : ObservableObject, INavigationAware
    {
        private bool _isInitialized = false;
        public void OnNavigatedTo()
        {
            if (!_isInitialized)
                InitializeViewModel();
        }

        public void OnNavigatedFrom()
        {
        }

        public void InitializeViewModel()
        {
        }

    }
}
