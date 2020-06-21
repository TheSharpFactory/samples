/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Query
{
    public partial class StoredProcResult<TResult>
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// This class represents the Result of a stored procedure call.
    /// </summary>
    public partial class StoredProcResult<TResult>
    {
        /// <summary>
        /// Gets or sets the result set.
        /// </summary>
        /// <value>
        /// List of TResult
        /// </value>
        public List<TResult> Result { get; set; }
        /// <summary>
        /// Gets or sets the Return Value.
        /// </summary>
        /// <value>
        /// int
        /// </value>
        public int ReturnValue { get; set; }
    }
}
