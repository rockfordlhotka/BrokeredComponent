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
          //// use reflection in a way that only works in full .NET
          //var t = this.GetType();
          //var m = t.GetMethod("HelloWorld");
          //return m.Name;

          //var ad = AppDomain.CurrentDomain;
          //return ad.BaseDirectory;

          await Task.Delay(1000);
          //return typeName;
          string result;
          try
          {
            var t = Type.GetType(typeName); //typeof(SecondaryAssembly.TestService).AssemblyQualifiedName);
            if (t == null)
              result = "<null>";
            else
              result = "client: " + typeName + " server: " + t.AssemblyQualifiedName;
          }
          catch (Exception ex)
          {
            result = ex.Message;
          }
          return result;
          //var obj = Activator.CreateInstance(t);
          //var m = t.GetMethod("Secondary");
          //return (string)m.Invoke(obj, null);

        }).AsAsyncOperation<string>();
    }
  }
}
