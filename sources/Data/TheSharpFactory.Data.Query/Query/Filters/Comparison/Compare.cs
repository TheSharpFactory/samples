/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Data.Query
{
    public partial class Compare
    {
    }
}

************************************************/

using System;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// This class holds methods to compare types.
    /// </summary>
    public partial class Compare
    {
        /// <summary>
        /// Compares two byte arrays for equality.
        /// </summary>
        /// <param name="a">First byte array to compare.</param>
        /// <param name="b">Second byte array to compare.</param>
        /// <returns>Returns true if the arrays are equal.</returns>
        public static bool ByteArrays(byte[] a, byte[] b)
        {
            if(a == null && b == null)
                return true;
            if(a == null && b != null)
                return false;
            if(a != null && b == null)
                return false;
             if(a.Length != b.Length)
                return false;
            if(object.ReferenceEquals(a, b))
                return true;
            var length = a.Length;
            for(int i = 0; i < length; i++) 
                if(a[i] != b[i])
                    return false;
            return true;
        }
    }
}
