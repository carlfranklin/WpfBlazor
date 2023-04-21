using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace WpfBlazor;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddWpfBlazorWebView();
        serviceCollection.AddBlazoredModal();
        Resources.Add("services", serviceCollection.BuildServiceProvider());

        InitializeComponent();
        AppState.MainWindow = this;
    }

    public void ShowMessageBox(string Message)
    {
        MessageBox.Show(Message);
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        AppState.IndexComponent.Message = $"Shared String Updated at {DateTime.Now.ToLongTimeString()}";
    }
}
