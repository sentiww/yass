using System.Buffers;
using Yass.Console;

var data = new Data(1, 12.34m, DateTime.UtcNow);

Console.WriteLine("Original:");
Console.WriteLine($"  Id: {data.Id}");
Console.WriteLine($"  Total: {data.Total}");
Console.WriteLine($"  CreatedUtc: {data.CreatedUtc:o}");
Console.WriteLine();

var buffer = new ArrayBufferWriter<byte>();
Data.Serialize(buffer, data);
var bytes = buffer.WrittenSpan.ToArray();

Console.WriteLine("Serialized bytes:");
Console.WriteLine(BitConverter.ToString(bytes));
Console.WriteLine();

var restored = Data.Deserialize(bytes);
Console.WriteLine("Deserialized:");
Console.WriteLine($"  Id: {restored.Id}");
Console.WriteLine($"  Total: {restored.Total}");
Console.WriteLine($"  CreatedUtc: {restored.CreatedUtc:o}");
