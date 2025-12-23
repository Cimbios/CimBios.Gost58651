using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Базовый класс для удельных сопротивленийучастка ЛЭП.
/// </summary>
[CimClass(ClassUri)]
public partial class PerLengthImpedance(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PerLengthLineParameter(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PerLengthImpedance";


    /// <summary>
    /// Участки линии переменного тока, имеющие указанные удельные параметры.
    /// </summary>
    public ACLineSegment[] ACLineSegments => GetAssoc1ToM<ACLineSegment>(nameof(ACLineSegments));

    public void AddToACLineSegments(ACLineSegment assocObject) => AddAssoc1ToM(nameof(ACLineSegments), assocObject);

    public void RemoveFromACLineSegments(ACLineSegment assocObject) =>
        RemoveAssoc1ToM(nameof(ACLineSegments), assocObject);

    public void RemoveAllFromACLineSegments() => RemoveAllAssocs1ToM(nameof(ACLineSegments));

    /// <summary>
    /// Сегменты участка линии переменного тока, имеющие указанные удельные параметры.
    /// </summary>
    public ACLineSeriesSection[] ACLineSeriesSection => GetAssoc1ToM<ACLineSeriesSection>(nameof(ACLineSeriesSection));

    public void AddToACLineSeriesSection(ACLineSeriesSection assocObject) =>
        AddAssoc1ToM(nameof(ACLineSeriesSection), assocObject);

    public void RemoveFromACLineSeriesSection(ACLineSeriesSection assocObject) =>
        RemoveAssoc1ToM(nameof(ACLineSeriesSection), assocObject);

    public void RemoveAllFromACLineSeriesSection() => RemoveAllAssocs1ToM(nameof(ACLineSeriesSection));
}