using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace alphabets
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            AvaloniaXamlLoader.Load(this);

            DataContext = new MainWindowModel();

#if DEBUG
            this.AttachDevTools();
#endif
        }
    }
}