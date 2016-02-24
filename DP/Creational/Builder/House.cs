using System;
using System.Collections.Generic;

namespace DP.Creational.Builder
{
    public class House
    {
        private List<string> parts { get; set; } = new List<string>();

        public void AddPart(string part)
        {
            parts.Add(part);
        }

        public void Print()
        {
            parts.ForEach(Console.WriteLine);
        }
    }
}