using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.Web.WebView2.Core;
using System;
using System.IO;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUi3WebView2TouchAndMouseIssue;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    private async void Page_Loading(FrameworkElement sender, object args)
    {
        var options = new CoreWebView2EnvironmentOptions
        {
            AdditionalBrowserArguments = "--disable-features=OverscrollHistoryNavigation,msExperimentalScrolling,ElasticOverscroll",
            IsCustomCrashReportingEnabled = true,
        };
        var env = await CoreWebView2Environment.CreateWithOptionsAsync(null, null, options);
        await MyWebView.EnsureCoreWebView2Async(env);

        MyWebView.CoreWebView2.Settings.IsSwipeNavigationEnabled = false;

        string htmlPath = Path.Combine(AppContext.BaseDirectory, "index.html");
        MyWebView.Source = new Uri(htmlPath);
    }
}
