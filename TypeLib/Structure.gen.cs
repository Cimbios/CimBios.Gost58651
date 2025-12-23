using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Базовый класс описания конструкции ЛЭП, распределительного устройства, опор ЛЭП.
/// </summary>
[CimClass(ClassUri)]
public partial class Structure(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AssetContainer(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Structure";

    /// <summary>
    /// Конструктивное номинальное напряжение, на которое рассчитана конструкция участка ЛЭП, кВ.
    /// </summary>
    public float? ratedVoltage
    {
        get => GetAttribute<float?>(nameof(ratedVoltage));
        set => SetAttribute(nameof(ratedVoltage), value);
    }

    /// <summary>
    /// Удельное сопротивление грунта, Ом/м.
    /// </summary>
    public float? rEarth
    {
        get => GetAttribute<float?>(nameof(rEarth));
        set => SetAttribute(nameof(rEarth), value);
    }


    /// <summary>
    /// Информация о расщеплении проводников ЛЭП.
    /// </summary>
    public WireSpacingInfo[] WireSpacingInfos => GetAssoc1ToM<WireSpacingInfo>(nameof(WireSpacingInfos));

    public void AddToWireSpacingInfos(WireSpacingInfo assocObject) =>
        AddAssoc1ToM(nameof(WireSpacingInfos), assocObject);

    public void RemoveFromWireSpacingInfos(WireSpacingInfo assocObject) =>
        RemoveAssoc1ToM(nameof(WireSpacingInfos), assocObject);

    public void RemoveAllFromWireSpacingInfos() => RemoveAllAssocs1ToM(nameof(WireSpacingInfos));
}