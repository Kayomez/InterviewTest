using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest;
// this may be better as a class with a static function rather than a static class
internal static class ListStringExtensions
{
    public static IList<string> CountAndTotalStringInitialCharacters(this IList<string> strings)
    {
        Dictionary<char, int> charCount = new();
        foreach (var str in strings)
        {
            if (string.IsNullOrEmpty(str))
                continue;
            var c = str.ToUpper()[0];
            if (charCount.ContainsKey(c))
            {
                charCount[c] += str.Length;
                continue;
            }
            charCount.Add(c, str.Length);
        }
        List<string> retLst = new();
        // order by alphabetical and then by count so count takes priority
        charCount.OrderBy(kv => kv.Key)
            .OrderByDescending(kv => kv.Value)
            .ToList()
            .ForEach(kv => retLst.Add($"{kv.Value}-{kv.Key}"));
        return retLst;
    }
}
