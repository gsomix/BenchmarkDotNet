﻿using System.Threading;
using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNet.Samples
{
    // It is very easy to use BenchmarkDotNet. You should just create a class
    [DryJob]
    public class IntroCustomEnvironmentInfo
    {
        [CustomEnvironmentInfo]
        public static string PlainText() => "Plain text";

        [Benchmark]
        public void Sleep() => Thread.Sleep(10);

        [Benchmark(Description = "Thread.Sleep(10)")]
        public void SleepWithDescription() => Thread.Sleep(10);
    }
}
