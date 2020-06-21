/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
************************************************/

using System;
using System.Runtime.Serialization;

namespace TheSharpFactory.Data.Exceptions
{

    /// <summary>
    /// This exception is raised when the Data Exchange fails.
    /// </summary>
    public class DataExchangeException:ApplicationException
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public DataExchangeException():base()
        {
        }

        /// <summary>
        /// Constructor with exception message
        /// </summary>
        /// <param name="message"></param>
        public DataExchangeException(string message):base(message)
        {
        }

        /// <summary>
        /// Constructor with message and inner exception
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public DataExchangeException(string message, Exception inner):base(message, inner)
        {
        }

        /// <summary>
        /// Protected constructor to de-serialize data
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected DataExchangeException(SerializationInfo info, StreamingContext context):base(info, context)
        {
        }
    }
}
