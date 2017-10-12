using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Win2DTest.Views.Win2DImageView
{
    public sealed partial class Win2DImageView : UserControl
    {
        public Win2DImageView()
        {
            this.InitializeComponent();
        }

        private void canvas_CreateResources(Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl sender, Microsoft.Graphics.Canvas.UI.CanvasCreateResourcesEventArgs args)
        {
            Debug.WriteLine("[Win2DImageView] Canvas Create Resources");
        }

        private void canvas_Draw(Microsoft.Graphics.Canvas.UI.Xaml.CanvasControl sender, Microsoft.Graphics.Canvas.UI.Xaml.CanvasDrawEventArgs args)
        {
            Debug.WriteLine("[Win2DImageView] Canvas Draw");
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            if (this.canvas != null)
            {
                this.canvas.RemoveFromVisualTree();
                this.canvas = null;
            }
        }
    }
}
