namespace Core.Math
{
    public partial interface INumeric<T>
        where T :
                    struct,                     //  exclude System.String (class)
                    System.IComparable,
                    System.IComparable<T>,
                    #if !NETSTANDARD1_0
                    System.IConvertible,
                    #endif
                    System.IEquatable<T>,
                    System.IFormattable         //  exclude System.Boolean
    {
    }
}
