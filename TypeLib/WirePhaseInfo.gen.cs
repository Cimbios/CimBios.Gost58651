using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры фазы проводника.
/// </summary>
[CimClass(ClassUri)]
public partial class WirePhaseInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#WirePhaseInfo";

    /// <summary>
    /// Фаза проводника.
    /// </summary>
    public SinglePhaseKind? phaseInfo
    {
        get => GetAttribute<SinglePhaseKind?>(nameof(phaseInfo));
        set => SetAttribute(nameof(phaseInfo), value);
    }

    /// <summary>
    /// Порядковый номер фазы, совпадающий с нумерацией фаз в классе ACLineSegmentPhase.
    /// </summary>
    public int? sequenceNumber
    {
        get => GetAttribute<int?>(nameof(sequenceNumber));
        set => SetAttribute(nameof(sequenceNumber), value);
    }

    /// <summary>
    /// Информация о многожильном проводнике.
    /// </summary>
    public WireAssemblyInfo? WireAssemblyInfo
    {
        get => GetAssoc1To1<WireAssemblyInfo>(nameof(WireAssemblyInfo));
        set => SetAssoc1To1(nameof(WireAssemblyInfo), value);
    }

    /// <summary>
    /// Информация о проводнике.
    /// </summary>
    public WireInfo? WireInfo
    {
        get => GetAssoc1To1<WireInfo>(nameof(WireInfo));
        set => SetAssoc1To1(nameof(WireInfo), value);
    }

    /// <summary>
    /// Информация о расположении фазы.
    /// </summary>
    public WirePosition? WirePosition
    {
        get => GetAssoc1To1<WirePosition>(nameof(WirePosition));
        set => SetAssoc1To1(nameof(WirePosition), value);
    }
}