﻿using System.Collections.Generic;

namespace SimpleCms.Core.Extensions
{
    public static class HashCodeExtensions
    {
        public static int CombineHashCodes(this IEnumerable<object> objs)
        {
            unchecked
            {
                var hash = 17;
                foreach (var obj in objs)
                    hash = hash * 23 + (obj?.GetHashCode() ?? 0);
                return hash;
            }
        }
    }
}