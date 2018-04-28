namespace Core.Math
{
    public partial interface INumeric<T>
        where T :
                    struct,                     //  exclude System.String (class)
                    System.IComparable,
                    System.IComparable<T>,
                    System.IConvertible,
                    System.IEquatable<T>,
                    System.IFormattable         //  exclude System.Boolean
    {
    }
}
