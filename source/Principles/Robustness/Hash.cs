using System.Security.Cryptography;
using System.Text;

namespace Principles.Robustness;

public class Hash
{
    readonly SHA256 sha = SHA256.Create();

    public IEnumerable<byte> GetHash(string source)
    {
        return sha.ComputeHash(Encoding.UTF8.GetBytes(source)).Select(b => b);
    }

    // liberal input
    public IEnumerable<byte> GetHash(byte[] bytes)
    {
        return sha.ComputeHash(bytes).Select(b => b);
    }

    // liberal input +
    public IEnumerable<byte> GetHash(IEnumerable<byte> bytes)
    {
        return sha.ComputeHash(bytes.ToArray()).Select(b => b);
    }

    // conservative output
    public byte[] GetHash_ConservativeOutput(IEnumerable<byte> bytes)
    {
        return sha.ComputeHash(bytes.ToArray());
    }

    // conservative output +
    public string GetHash_ConservativeOutput_Plus(IEnumerable<byte> bytes)
    {
        return BitConverter.ToString(sha.ComputeHash(bytes.ToArray()));
    }

    // conservative output ++
    public HashValue GetHash_ConservativeOutput_PlusPlus(IEnumerable<byte> bytes)
    {
        return new HashValue(sha.ComputeHash(bytes.ToArray()));
    }

    public class HashValue
    {
        public string Value { get; }

        public HashValue(byte[] value)
        {
            Value = BitConverter.ToString(value);
        }
    }
}