using Microsoft.Graphics.Canvas.UI.Xaml;
using Microsoft.UI;
using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUiApp.Win2D
{
    /// <summary>
    /// Win2D "Hello, World!" quickstart
    /// https://learn.microsoft.com/en-us/windows/apps/develop/win2d/hellowin2dworld
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ExtendsContentIntoTitleBar = true;
        }

        private void CanvasControl_Draw(CanvasControl sender, CanvasDrawEventArgs args)
        {
            args.DrawingSession.DrawEllipse(180, 115, 170, 30, Colors.Black, 3);
            args.DrawingSession.DrawText("Hello, Win2D World!", 100, 100, Colors.Yellow);
        }
    }
}
