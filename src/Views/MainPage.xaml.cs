using DIDemo.ViewModels;

namespace DIDemo.Views;

public partial class MainPage
{
    public MainPage(MainPageViewModel viewModel)
    {
        BindingContext = viewModel;

        InitializeComponent();
    }
}
