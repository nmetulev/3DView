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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _3DViewerTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<string> Assets = new List<string>();
        int CurrentAsset = 0;

        public MainPage()
        {
            this.InitializeComponent();
            Assets.Add("poop.glb");
            Assets.Add("duck.glb");
            Assets.Add("https://models.babylonjs.com/ufo.glb");
        }

        private void Element_AssetLoading(object sender, EventArgs e)
        {
            Debug.WriteLine("Loading");
        }

        private void Element_AssetLoaded(object sender, EventArgs e)
        {
            Debug.WriteLine("Loaded");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CurrentAsset = (CurrentAsset + 1) % Assets.Count;
            Element.Source = Assets[CurrentAsset];
        }
    }
}
