using System;

class NullOperations
{
    public void PerformNullChecks()
    {
        string username = null;

        Console.WriteLine(username == null ? "Username is not available" : username);

        Console.WriteLine(username ?? "Username is not available");

        username ??= "DefaultUser";
        Console.WriteLine("Updated : " + username);
    }
}

