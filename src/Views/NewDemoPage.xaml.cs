using DIDemo.ViewModels;

namespace DIDemo.Views;

public partial class NewDemoPage
{
    public NewDemoPage(NewDemoPageViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }
}
