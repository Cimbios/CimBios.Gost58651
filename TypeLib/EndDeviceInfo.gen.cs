using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Данные конечного устройства.
/// </summary>
[CimClass(ClassUri)]
public partial class EndDeviceInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AssetInfo(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#EndDeviceInfo";

    /// <summary>
    /// Присущие устройству возможности (то есть функции, которые оно поддерживает).
    /// </summary>
    public EndDeviceCapability? capability
    {
        get => GetAttribute<EndDeviceCapability?>(nameof(capability));
        set => SetAttribute(nameof(capability), value);
    }

    /// <summary>
    /// Если TRUE, то твердотельное конечное устройство (в отличие от механического или электромеханического устройства).
    /// </summary>
    public bool? isSolidState
    {
        get => GetAttribute<bool?>(nameof(isSolidState));
        set => SetAttribute(nameof(isSolidState), value);
    }

    /// <summary>
    /// Количество фаз, поддерживаемых конечным устройством, как правило, 0, 1 или 3.
    /// </summary>
    public int? phaseCount
    {
        get => GetAttribute<int?>(nameof(phaseCount));
        set => SetAttribute(nameof(phaseCount), value);
    }

    /// <summary>
    /// Номинальный ток, А.
    /// </summary>
    public float? ratedCurrent
    {
        get => GetAttribute<float?>(nameof(ratedCurrent));
        set => SetAttribute(nameof(ratedCurrent), value);
    }

    /// <summary>
    /// Номинальное напряжение, В.
    /// </summary>
    public float? ratedVoltage
    {
        get => GetAttribute<float?>(nameof(ratedVoltage));
        set => SetAttribute(nameof(ratedVoltage), value);
    }


    /// <summary>
    /// Конечные устройства, имеющие эти данные.
    /// </summary>
    public EndDevice[] EndDevices => GetAssoc1ToM<EndDevice>(nameof(EndDevices));

    public void AddToEndDevices(EndDevice assocObject) => AddAssoc1ToM(nameof(EndDevices), assocObject);
    public void RemoveFromEndDevices(EndDevice assocObject) => RemoveAssoc1ToM(nameof(EndDevices), assocObject);
    public void RemoveAllFromEndDevices() => RemoveAllAssocs1ToM(nameof(EndDevices));
}