using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Спецификация требований к измерению для конкретной точки в сети.
/// </summary>
[CimClass(ClassUri)]
public partial class MetrologyRequirement(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#MetrologyRequirement";

    /// <summary>
    /// Причина метрологического требования.
    /// </summary>
    public ReadingReasonKind? reason
    {
        get => GetAttribute<ReadingReasonKind?>(nameof(reason));
        set => SetAttribute(nameof(reason), value);
    }


    /// <summary>
    /// Точки поставки для метрологического требования.
    /// </summary>
    public UsagePoint[] UsagePoints => GetAssoc1ToM<UsagePoint>(nameof(UsagePoints));

    public void AddToUsagePoints(UsagePoint assocObject) => AddAssoc1ToM(nameof(UsagePoints), assocObject);
    public void RemoveFromUsagePoints(UsagePoint assocObject) => RemoveAssoc1ToM(nameof(UsagePoints), assocObject);
    public void RemoveAllFromUsagePoints() => RemoveAllAssocs1ToM(nameof(UsagePoints));

    /// <summary>
    /// Типы показаний, которые должны быть собраны в соответствии с метрологическим требованием.
    /// </summary>
    public ReadingType[] ReadingTypes => GetAssoc1ToM<ReadingType>(nameof(ReadingTypes));

    public void AddToReadingTypes(ReadingType assocObject) => AddAssoc1ToM(nameof(ReadingTypes), assocObject);
    public void RemoveFromReadingTypes(ReadingType assocObject) => RemoveAssoc1ToM(nameof(ReadingTypes), assocObject);
    public void RemoveAllFromReadingTypes() => RemoveAllAssocs1ToM(nameof(ReadingTypes));
}