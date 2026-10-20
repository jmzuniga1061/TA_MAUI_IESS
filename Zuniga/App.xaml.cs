using Zuniga.Views;

namespace Zuniga;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new IessPage();
    }
}