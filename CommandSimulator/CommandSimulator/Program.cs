namespace CommandSimulator;
using System;
using System.Collections.Generic;

public class Program { 
    public static void Main()
    {
        string[] strInput = [
            "cd /",
            "cd home",
            "cd ./user//",
            "cd ../..",
            "cd ../..",
            "cd var/log",
            "pwd",
            "cd /etc/./nginx/../ssh",
            "pwd",
            "cd ..",
            "pwd"

            ];
        var strOutput=CommandSimulator.Simulate(strInput);
        foreach(var strCommand in strOutput)
        {
        Console.WriteLine(strCommand);
        }
    }
}