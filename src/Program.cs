using Avalonia;

namespace alphabets
{
    /// <summary>
    /// The entry point for the program.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The entry point for the program. Performs initialization.
        /// </summary>
        /// <param name="args">Command-line arguments to the program.</param>
        /// <remarks>
        /// Don't use any Avalonia, third-party APIs or any SynchronizationContext-reliant code before AppMain is
        /// called: things aren't initialized yet and stuff might break.
        /// </remarks>
        public static void Main(string[] args)
            => BuildAvaloniaApp()
                .StartWithClassicDesktopLifetime(args);

        /// <summary>
        /// Build Avalonia configuration. Used by visual designer; do not remove.
        /// </summary>
        /// <returns>Avalonia application builder to run the UI.</returns>
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace();
    }
}
