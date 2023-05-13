using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;

Console.WriteLine("Welcome to RbxKiller! This program is mean't to kill ROBLOX and ROBLOX Studio, when it crashes and you can't close it!");
Task.Delay(1000).Wait();
Console.WriteLine("The commands are: kroblox(kills roblox) kstudio(kills roblox studio) help(gives discord)");
Console.WriteLine("This console window does close when you exeucte!");
var _string = Console.ReadLine();
if (_string == "kroblox")
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
if (_string == "kstudio")
{
    foreach (Process cls in Process.GetProcesses())
    {
        if (cls.ProcessName.Equals("RobloxStudioBeta"))
        {
            Console.WriteLine("Found ROBLOX Studio!");
            cls.Kill();
            Task.Delay(1000).Wait();
            Console.WriteLine("ROBLOX Studio has been killed!");
        }
    }
}
if (_string == "help")
{
    Console.WriteLine("Our Help Discord: https://discord.gg/qTRxg36Jbb");
    Process.Start("RbxKiller");
}