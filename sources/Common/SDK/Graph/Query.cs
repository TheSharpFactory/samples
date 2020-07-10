using System;
using System.CodeDom.Compiler;

namespace TheSharpFactory.SDK
{
    [GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Query
        : global::StrawberryShake.IDocument
    {
        private readonly byte[] _hashName = new byte[]
        {
            109,
            100,
            53,
            72,
            97,
            115,
            104
        };
        private readonly byte[] _hash = new byte[]
        {
            55,
            102,
            97,
            100,
            102,
            56,
            101,
            55,
            50,
            57,
            52,
            56,
            100,
            51,
            100,
            101,
            49,
            55,
            50,
            102,
            99,
            51,
            97,
            56,
            99,
            99,
            53,
            100,
            57,
            101,
            52,
            49
        };
        private readonly byte[] _content = new byte[]
        {
            113,
            117,
            101,
            114,
            121,
            32,
            71,
            101,
            116,
            67,
            117,
            115,
            116,
            111,
            109,
            101,
            114,
            115,
            32,
            123,
            32,
            99,
            117,
            115,
            116,
            111,
            109,
            101,
            114,
            115,
            32,
            123,
            32,
            95,
            95,
            116,
            121,
            112,
            101,
            110,
            97,
            109,
            101,
            32,
            110,
            97,
            109,
            101,
            32,
            125,
            32,
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static Query Default { get; } = new Query();

        public override string ToString() => 
            @"query GetCustomers {
              customers {
                name
              }
            }";
    }
}
