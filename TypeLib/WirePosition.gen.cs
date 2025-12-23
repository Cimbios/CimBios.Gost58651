using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Пространственное расположение фазного проводника.
/// </summary>
[CimClass(ClassUri)]
public partial class WirePosition(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#WirePosition";

    /// <summary>
    /// Горизонтальная координата проводника относительно общей оси, м.
    /// </summary>
    public float? xCoord
    {
        get => GetAttribute<float?>(nameof(xCoord));
        set => SetAttribute(nameof(xCoord), value);
    }

    /// <summary>
    /// Вертикальная координата проводника относительно земли, м.
    /// </summary>
    public float? yCoord
    {
        get => GetAttribute<float?>(nameof(yCoord));
        set => SetAttribute(nameof(yCoord), value);
    }

    /// <summary>
    /// Параметры расщепления провода.
    /// </summary>
    public WireSpacingInfo? WireSpacingInfo
    {
        get => GetAssoc1To1<WireSpacingInfo>(nameof(WireSpacingInfo));
        set => SetAssoc1To1(nameof(WireSpacingInfo), value);
    }

    /// <summary>
    /// Информация о фазе проводника.
    /// </summary>
    public WirePhaseInfo[] WirePhaseInfo => GetAssoc1ToM<WirePhaseInfo>(nameof(WirePhaseInfo));

    public void AddToWirePhaseInfo(WirePhaseInfo assocObject) => AddAssoc1ToM(nameof(WirePhaseInfo), assocObject);

    public void RemoveFromWirePhaseInfo(WirePhaseInfo assocObject) =>
        RemoveAssoc1ToM(nameof(WirePhaseInfo), assocObject);

    public void RemoveAllFromWirePhaseInfo() => RemoveAllAssocs1ToM(nameof(WirePhaseInfo));
}