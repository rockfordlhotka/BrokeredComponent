using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace BrokeredComponent
{
  public sealed class Class
  {
    public IAsyncOperation<string> HelloWorld(string typeName)
    {
      return Task<string>.Run(async () =>
        {
          var t = Type.GetType("SecondaryAssembly.TestService, SecondaryAssembly"); //typeof(SecondaryAssembly.TestService).AssemblyQualifiedName);
          var obj = Activator.CreateInstance(t);
          var m = t.GetMethod("Secondary");
          return (string)m.Invoke(obj, null);

        }).AsAsyncOperation<string>();
    }
  }
}
