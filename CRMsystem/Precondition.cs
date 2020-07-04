using System;
using System.Collections.Generic;
using System.Text;

namespace CRMsystem
{
    public static class Precondition
    {
        public static void Requires(bool precondition)
        {
            if (!precondition)
                throw new Exception("The precondition was not met");
        }
    }
}
