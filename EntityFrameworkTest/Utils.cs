using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest
{
    public static class Utils
    {
        public static string GenerateHashCode(int length)
        {
            return Guid.NewGuid().ToString("N").Substring(0, length);
        }
    }
}
