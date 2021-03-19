﻿using System;
using System.Collections.Generic;
using System.Text;

namespace myWebsite.business.Utilities.Result
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
