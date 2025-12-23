using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры кабеля с ленточным проводящим экраном.
/// </summary>
[CimClass(ClassUri)]
public partial class TapeShieldCableInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : CableInfo(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#TapeShieldCableInfo";

    /// <summary>
    /// Процент перекрытия намотки ленточного проводящего экрана, %.
    /// </summary>
    public float? tapeLap
    {
        get => GetAttribute<float?>(nameof(tapeLap));
        set => SetAttribute(nameof(tapeLap), value);
    }

    /// <summary>
    /// Толщина ленты проводящего экрана кабеля, м.
    /// </summary>
    public float? tapeThickness
    {
        get => GetAttribute<float?>(nameof(tapeThickness));
        set => SetAttribute(nameof(tapeThickness), value);
    }
}