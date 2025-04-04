﻿using Creational.Singleton;

// Simple Singleton
Console.WriteLine("Simple Singleton:");

Singleton s1 = Singleton.GetInstance();
Singleton s2 = Singleton.GetInstance();

if (s1 == s2)
{
  Console.WriteLine("Singleton works, both variables contain the same instance.");
}
else
{
  Console.WriteLine("Singleton failed, variables contain different instances.");
}

Console.WriteLine("");
Console.WriteLine("Multi Thread Safe Singleton:");

// Multi Thread Safe Singleton
Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );

Thread process1 = new Thread(() =>
{
  TestSingletonMultiThreadSafe("FOO");
});
Thread process2 = new Thread(() =>
{
  TestSingletonMultiThreadSafe("BAR");
});

process1.Start();
process2.Start();

process1.Join();
process2.Join();


static void TestSingletonMultiThreadSafe(string value)
{
  SingletonMultiThreadSafe singleton = SingletonMultiThreadSafe.GetInstance(value);
  Console.WriteLine(singleton.Value);
}
