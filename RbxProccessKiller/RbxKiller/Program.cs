using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;

Console.WriteLine("Welcome to RbxKiller! This program is mean't to kill ROBLOX when it crashes and you can't close it!");
Task.Delay(1000).Wait();
Console.WriteLine("Type 'yes' to kill ROBLOX!");
Console.WriteLine("The window closes then the code was executed and ROBLOX was closed! If ROBLOX was open");
var _string = Console.ReadLine();
if (_string == "yes")
{
    foreach (Process cls in Process.GetProcesses())
    {
        if (cls.ProcessName.Equals("RobloxPlayerBeta"))
        {
            Console.WriteLine("Found ROBLOX!");
            cls.Kill();
            Task.Delay(1000).Wait();
            Console.WriteLine("ROBLOX has been killed!");
        }
    }
}