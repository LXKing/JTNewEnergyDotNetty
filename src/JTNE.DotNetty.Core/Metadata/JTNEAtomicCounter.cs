﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace JTNE.DotNetty.Core.Metadata
{
    /// <summary>
    /// 
    /// <see cref="Grpc.Core.Internal"/>
    /// </summary>
    public class JTNEAtomicCounter
    {
        long counter = 0;

        public JTNEAtomicCounter(long initialCount = 0)
        {
            this.counter = initialCount;
        }

        public void Reset()
        {
            Interlocked.Exchange(ref counter, 0);
        }

        public long Increment()
        {
            return Interlocked.Increment(ref counter);
        }

        public long Add(long len)
        {
            return Interlocked.Add(ref counter,len);
        }

        public long Decrement()
        {
            return Interlocked.Decrement(ref counter);
        }

        public long Count
        {
            get
            {
                return Interlocked.Read(ref counter);
            }
        }
    }
}
