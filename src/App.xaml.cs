using DIDemo.Views;

namespace DIDemo;

public partial class App : Application
{
    /*public App(AppShell mainPage)
    {
        InitializeComponent();

        MainPage = mainPage;
    }*/

    public App(MainPage mainPage)
    {
        InitializeComponent();

        MainPage = new NavigationPage(mainPage);
    }
}
