﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JTNE.DotNetty.Abstractions.Dtos
{
    public class JTNEResultDto<T>
    {
        public JTNEResultDto()
        {
            Code = JTNEResultCode.Ok;
        }

        public string Message { get; set; }

        public int Code { get; set; }

        public T Data { get; set; }
    }

    public class JTNEResultCode
    {
        public const int Ok = 200;
        public const int Empty = 201;
        public const int NotFound = 404;
        public const int Fail = 400;
        public const int Error = 500;
    }
}