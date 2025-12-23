using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Интергармоники представлены в виде рационального числа numerator/denominator, гармоники идентифицируются как denominator = 1.
/// </summary>
[CimClass(ClassUri)]
public partial class ReadingInterharmonic(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ReadingInterharmonic";

    /// <summary>
    /// Знаменатель.
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