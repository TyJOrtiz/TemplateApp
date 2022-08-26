using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace TemplateApp
{
    public sealed class TitleBar : Control
    {
        public TitleBar()
        {
            this.DefaultStyleKey = typeof(TitleBar);
        }

        public object CenterContent
        {
            get { return (object)GetValue(CenterContentProperty); }
            set { SetValue(CenterContentProperty, value); }
        }

        public DependencyProperty CenterContentProperty { get; private set; }

        public bool IsBackButtonEnabled
        {
            get { return (bool)GetValue(BackButtonEnabledProperty); }
            set { SetValue(BackButtonEnabledProperty, value); }
        }

        public DependencyProperty BackButtonEnabledProperty { get; private set; }
    }
}
