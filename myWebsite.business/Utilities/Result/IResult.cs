﻿using System;
using System.Collections.Generic;
using System.Text;

namespace myWebsite.business.Utilities.Result
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
