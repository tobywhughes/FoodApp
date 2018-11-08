using System;
using System.Diagnostics;
using Prism;
using Prism.Mvvm;

namespace Restaurant_Aid.ViewModels
{
    public class RestaurantViewModel : BindableBase, IActiveAware
    {
        private string _title;

        public event EventHandler IsActiveChanged;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                SetProperty(ref _isActive, value);
                IsActiveChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public RestaurantViewModel()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(RestaurantViewModel)}:  ctor");
            Title = "Restaurant";

            IsActiveChanged += OnIsActiveChanged;
        }

        private void OnIsActiveChanged(object sender, EventArgs e)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnIsActiveChanged)}: {IsActive}");
        }
    }
}
