using Sqids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTestUtilities.IdEncryption
{
    public class IdEncripterBuilder
    {
        public static SqidsEncoder<long> Build()
        {
            return new SqidsEncoder<long>(new()
            {
                 MinLength = 3,
                 Alphabet = "QhvjJXG63RbS80dLBugexPZ5wF4ftpmNq1HzrTkcnAIUE9i2oaC7yVlDMsYKOW"
            });
        }
    }
}
