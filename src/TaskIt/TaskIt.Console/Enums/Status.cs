using System;
using System.Collections.Generic;
using System.Text;

namespace TaskIt.Console.Enums
{
    public enum Status
    {
        Pending = 1,
        InProgress,
        Complete,
        OnHold,
        Blocked,
        Cancelled,
        Archived,
    }
}
