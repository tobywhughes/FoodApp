using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Prism;
using Prism.Mvvm;

namespace Restaurant_Aid.ViewModels
{
    public class CustomerViewModel : BindableBase, IActiveAware
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

        public CustomerViewModel()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(CustomerViewModel)}:  ctor");
            Title = "Customer";

            IsActiveChanged += OnIsActiveChanged;
        }

        private void OnIsActiveChanged(object sender, EventArgs e)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnIsActiveChanged)}: {IsActive}");
        }
    }
}
