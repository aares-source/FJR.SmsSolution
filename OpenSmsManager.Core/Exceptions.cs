using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSmsManager.Core
{
    public class UnexpectedResponseException : Exception
    {
        internal UnexpectedResponseException(string message) : base(message) { }
    }

    public class DecodeException : Exception
    {
        internal DecodeException(string message) : base(message) { }
    }

    public class ConnectionFailedException : Exception
    {
        internal ConnectionFailedException(string message) : base(message) { }
    }

    public class SerialPortAllReadyOpenException : Exception
    {
        internal SerialPortAllReadyOpenException(string message) : base(message) { }
    }
}