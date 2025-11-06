using System.Buffers;

namespace Yass;

public interface IBinarySerializable<T>
{
    public static abstract void Serialize(IBufferWriter<byte> writer, T value);

    public static abstract T Deserialize(ReadOnlySequence<byte> data);
}