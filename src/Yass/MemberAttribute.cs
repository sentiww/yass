namespace Yass;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public sealed class MemberAttribute : Attribute
{
    public int Order { get; }

    public MemberAttribute(int order) => Order = order;
}