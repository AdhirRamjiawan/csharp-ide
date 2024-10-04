

using System.Diagnostics;
using System.Threading.Tasks;

namespace csharp_ide;

public class AppBuilder
{
    public async Task BuildAsync()
    {
        await Task.Run(() => 
        {
            var startInfo = new ProcessStartInfo("dotnet", "build");
        });
    }
}