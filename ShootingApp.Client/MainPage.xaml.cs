using ShootingApp.Client.ViewModels; 

namespace ShootingApp.Client;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel(); 
    }
}