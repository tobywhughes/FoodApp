using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Restaurant_Aid.Views;
using Xamarin.Forms;

namespace Restaurant_Aid.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        INavigationService _navigationService;
        public DelegateCommand NavigateToTabContainerCommand { get; set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(MainPageViewModel)}:  ctor");

            _navigationService = navigationService;
            NavigateToTabContainerCommand = new DelegateCommand(OnNavigateToTabContainer);
            Title = "Main Page";
        }

        private void OnNavigateToTabContainer()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigateToTabContainer)}");

            _navigationService.NavigateAsync(nameof(TabContainer));
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatedFrom)}");
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatedTo)}");
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatingTo)}");
        }
    }
}
