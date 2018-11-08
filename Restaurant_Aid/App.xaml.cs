using Prism;
using Prism.Ioc;
using Restaurant_Aid.ViewModels;
using Restaurant_Aid.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Restaurant_Aid
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();

            //Register pages for navigation! Or else you'll never navigate.
            containerRegistry.RegisterForNavigation<TabContainer, TabContainerViewModel>();
            containerRegistry.RegisterForNavigation<CustomerPage, CustomerViewModel>();
            containerRegistry.RegisterForNavigation<RestaurantPage, RestaurantViewModel>();
        }
    }
}
