using System;
using System.Collections.Generic;
using System.Text;

namespace NlogImplementation
{
    public class AddNumbers
    {
        Nlog nlog = new Nlog();
        public int Sum(int a, int b)
        {
            if(a == 0 || b == 0)
            {
                nlog.LogDebug("Debug Successfull : sum()");
                nlog.LogError("Expecting Null Value");
                nlog.LogWarn(" a or b Should not Equal to 0");
            }
            int c = a + b;
            nlog.LogDebug("Debug Succesful");
            return c;
        }
    }
}
