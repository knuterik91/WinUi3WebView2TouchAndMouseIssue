using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUi3WebView2TouchAndMouseIssue;
/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        rootFrame.Content = new MainPage();
        //MyWebView.EnsureCoreWebView2Async();
        //MyWebView.CoreWebView2.Navigate("file:///C:/Users/knutel/OneDrive%20-%20PHOENIXOnline/Skrivebord/test.html");
    }



}
