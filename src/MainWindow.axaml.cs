using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace alphabets
{
    /// <summary>
    /// Main window of the application. Allows user to enter text and pick a different alphabet to render it in.
    /// </summary>
    public class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
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