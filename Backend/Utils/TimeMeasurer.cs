﻿//
// Copyright (c) NickAc. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//
using System;
using System.Diagnostics;

namespace NickAc.LightPOS.Backend.Utils
{
    public static class TimeMeasurer
    {
        public static void MeasureTime(Action a) => MeasureTime("", a);

        public static void MeasureTime(string action, Action a)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            a();
            sw.Stop();
            Console.WriteLine(string.Format("Action[{1}] took {0}ms to execute.", sw.ElapsedMilliseconds, action));
        }
    }
}