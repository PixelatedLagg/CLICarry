# CLICarry
Carry your CLI to the next level with this incredibly simple C# library.

## Installation
Use the following command:
```
dotnet add package CLICarry
```

## Important Links
[Nuget Page](https://www.nuget.org/packages/CLICarry)

## Example
```c#
using System;
using CLICarry;

class Program
{
    public static void Main(string[] args)
    {
        CLIManager.Run<Example>(args);
    }
}

class Example : CLI
{
    void CLI.Error(CLICarry.ErrorContext context)
    {
        Console.WriteLine("An error has occurred!");
    }

    [Command("hello")]
    public void Hello(CommandArgs args)
    {
        Console.WriteLine("Hello!");
    }

    [Command("echo", "message", FlagValueType.String)]
    public void Echo(CommandArgs args)
    {
        if (!args.Flags.HasFlag("message"))
        {
            Console.WriteLine("Provide a message!");
        }
        else
        {
            Console.WriteLine(args.Flags["message"].Value);
        }
    }
}
```

Input:
```
dotnet run -- hello
dotnet run -- echo -message "test!!!"
dotnet run -- -echo
```

Output:
```
Hello!
test!!!
An error has occurred!
```
