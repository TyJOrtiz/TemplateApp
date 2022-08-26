using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TemplateApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private CoreApplicationViewTitleBar coreTitleBar;

        public MainPage()
        {
            this.InitializeComponent();

            coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            Microsoft.UI.Xaml.Controls.BackdropMaterial.SetApplyToRootOrPageBackground(this, true);
            coreTitleBar.ExtendViewIntoTitleBar = true;
            ApplicationViewTitleBar formattableTitleBar = ApplicationView.GetForCurrentView().TitleBar;
            formattableTitleBar.ButtonBackgroundColor = Colors.Transparent;
            formattableTitleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
            {
                switch (this.ActualTheme)
                {
                    case ElementTheme.Dark:
                        formattableTitleBar.ButtonForegroundColor = Colors.White;
                        break;
                    case ElementTheme.Light:
                        formattableTitleBar.ButtonForegroundColor = Colors.Black;
                        break;
                    case ElementTheme.Default:
                        if (App.Current.RequestedTheme == ApplicationTheme.Light)
                        {
                            formattableTitleBar.ButtonForegroundColor = Colors.Black;
                        }
                        else
                        {
                            formattableTitleBar.ButtonForegroundColor = Colors.White;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void NavView_BackRequested(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewBackRequestedEventArgs args)
        {
            // handle back button click. Use this for navigating backwards in a frame, for example.
        }

        private void NavView_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            // Use this to navigate through pages in a frame or start an action.
        }
    }
}
