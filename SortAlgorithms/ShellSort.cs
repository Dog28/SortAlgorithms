﻿using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class ShellSort<T> : AlgorithmsBase<T>
        where T : IComparable
    {
        public ShellSort(IEnumerable<T> items) : base(items) { }
        public ShellSort() { }
        public override string ToString()
        {
            return "ShellSort";
        }
        protected override void Sort()
        {
            int step = Items.Count / 2;
            while(step > 0)
            {
                for (int i = step; i < Items.Count; i++)
                {
                    int j = i;                   
                    while (j >= step && (Compare(Items[j - step],Items[j]) == 1))
                    {
                        Swop(j - step, j);
                        j -= step;
                    }
                }
                step /= 2;
            }
        }
    }
}
