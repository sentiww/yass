# Yass (Yet another source-generated serializer)
Experimenting with source generated binary serialization.

## Benchmarks
| Method      | Mean     | Error    | StdDev   | Median   | Gen0   | Allocated |
|------------ |---------:|---------:|---------:|---------:|-------:|----------:|
| Serialize   | 35.08 ns | 0.762 ns | 2.185 ns | 34.08 ns | 0.0229 |      96 B |
| Deserialize | 23.87 ns | 0.538 ns | 1.319 ns | 23.71 ns | 0.0210 |      88 B |
