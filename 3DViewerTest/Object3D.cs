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

namespace _3DViewerTest
{
    public sealed class Object3D : Control
    {
        private WebView _view;

        public Object3D()
        {
            this.DefaultStyleKey = typeof(Object3D);
        }

        protected override void OnApplyTemplate()
        {

            base.OnApplyTemplate();

            _view = GetTemplateChild("View") as WebView;
            if (_view != null)
            {
                _view.Navigate(new Uri("ms-appx-web:///BabylonView.html"));
            }
        }

        public string Source
        {
            get { return (string)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Source.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(string), typeof(Object3D), new PropertyMetadata(string.Empty, OnSourceChanged));

        private static void OnSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
