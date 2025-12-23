using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Рациональное число = числитель/знаменатель.
/// </summary>
[CimClass(ClassUri)]
public partial class RationalNumber(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#RationalNumber";

    /// <summary>
    /// Знаменатель. Значение 1 указывает, что число является простым целым числом.
    /// </summary>
    public int? denominator
    {
        get => GetAttribute<int?>(nameof(denominator));
        set => SetAttribute(nameof(denominator), value);
    }

    /// <summary>
    /// Числитель.
    /// </summary>
    public int? numerator
    {
        get => GetAttribute<int?>(nameof(numerator));
        set => SetAttribute(nameof(numerator), value);
    }
}