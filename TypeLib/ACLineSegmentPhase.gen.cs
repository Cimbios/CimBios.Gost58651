using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Фаза участка ЛЭП.
/// </summary>
[CimClass(ClassUri)]
public partial class ACLineSegmentPhase(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PowerSystemResource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ACLineSegmentPhase";

    /// <summary>
    /// Буквенное обозначение фазы.
    /// </summary>
    public SinglePhaseKind? phase
    {
        get => GetAttribute<SinglePhaseKind?>(nameof(phase));
        set => SetAttribute(nameof(phase), value);
    }

    /// <summary>
    /// Порядковый номер фазы, совпадающий с нумерацией фаз в классах WirePosition, WirePhaseInfo.
    /// </summary>
    public int? sequenceNumber
    {
        get => GetAttribute<int?>(nameof(sequenceNumber));
        set => SetAttribute(nameof(sequenceNumber), value);
    }

    /// <summary>
    /// Участок линии переменного тока для отдельной ее фазы.
    /// </summary>
    public ACLineSegment? ACLineSegment
    {
        get => GetAssoc1To1<ACLineSegment>(nameof(ACLineSegment));
        set => SetAssoc1To1(nameof(ACLineSegment), value);
    }
}