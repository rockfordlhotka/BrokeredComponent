using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace WinRTclient
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainPage : Page
  {
    public MainPage()
    {
      this.InitializeComponent();
    }

    public async Task Test()
    {
      var brokered = new BrokeredComponent.Class();
      //var data = new byte[] { 22, 43 };
      var type = typeof(SecondaryAssembly.TestService).AssemblyQualifiedName;
      var result = await brokered.HelloWorld(type);
      this.OutputText.Text = result;
    }

    private async void Page_Loaded(object sender, RoutedEventArgs e)
    {
      await Test();
    }
  }
}
