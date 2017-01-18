using System;
using System.Collections.Generic;
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
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Hello
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();  //an example of a CONSTRUCTOR. "this" refers to the same name as the class (i.e. "MainPage")
                                         // A CONSTRUCTOR is a special method with the same name as the class.
                                         //it runs when an instance of the class is created, and can contain code to initialize the instance.
        }

        private void okClick(object sender, RoutedEventArgs e)
        {
            MessageDialog msg = new MessageDialog("Hello" + " " + userName.Text);
            msg.ShowAsync();
        }
    }
}
