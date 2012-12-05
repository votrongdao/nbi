﻿using System;
using System.Linq;
using NUnit.Framework;

namespace NBi.NUnit.Runtime
{
    public class CustomStackTraceAssertionException: AssertionException
    {
        private readonly string stackTrace;

        public CustomStackTraceAssertionException(string stackTrace)
            : base(null)
        {
            this.stackTrace = stackTrace;
        }
        
        public override string StackTrace 
        { 
            get 
            {   
                return stackTrace;
            }
        }
    }
}
