using Microsoft.Extensions.Logging;
using test24240.ViewModels;

namespace test24240;

public partial class MainPage : ContentPage
{
    private readonly ILogger<MainPage> logger;

    public MainPage(
        MainPageViewModel mainPageViewModel,
        ILogger<MainPage> logger)
    {
        InitializeComponent();
        BindingContext = mainPageViewModel;
        this.logger = logger;
    }

    private void NotImplementedButton(object sender, EventArgs e)
    {
        DisplayAlert("Not Implemented", "This feature is not implemented yet.", "OK");
    }
}