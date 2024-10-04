

using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace csharp_ide;

public class AppBuilder
{
    public async Task BuildAsync()
    {
        await Task.Run(() => 
        {
            var startInfo = new ProcessStartInfo("Scripts/Linux/create-build-run-project.sh", "test test console");
            startInfo.RedirectStandardError = true;

            Console.WriteLine(startInfo.WorkingDirectory);

            var process = Process.Start(startInfo);
            process.ErrorDataReceived += (sender, args) => Console.WriteLine(args.Data);
            process.OutputDataReceived += (sender, args) => Console.WriteLine(args.Data);
        });
    }
}