

using System;
using System.Threading.Tasks;

namespace csharp_ide;

public class AppProjectBuilder
{
    private readonly string _outputDir;

    public AppProjectBuilder()
    {
        _outputDir = AppDomain.CurrentDomain.BaseDirectory.ToString();
    }

    public async Task BuildAsync()
    {
        await Task.Run(() => 
        {
            
        });
    }
}