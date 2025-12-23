using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Дугогасящая катушка Петерсена.
/// </summary>
[CimClass(ClassUri)]
public partial class PetersenCoil(IOIDDescriptor oid, ICimMetaClass metaClass)
    : EarthFaultCompensator(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PetersenCoil";

    /// <summary>
    /// Режим работы дугогасящей катушки.
    /// </summary>
    public PetersenCoilModeKind? mode
    {
        get => GetAttribute<PetersenCoilModeKind?>(nameof(mode));
        set => SetAttribute(nameof(mode), value);
    }

    /// <summary>
    /// Номинальное напряжение, кВ.
    /// </summary>
    public float? nominalU
    {
        get => GetAttribute<float?>(nameof(nominalU));
        set => SetAttribute(nameof(nominalU), value);
    }

    /// <summary>
    /// Нескомпенсированный регулятором реактивный ток дугогасящей катушки, А.
    /// </summary>
    public float? offsetCurrent
    {
        get => GetAttribute<float?>(nameof(offsetCurrent));
        set => SetAttribute(nameof(offsetCurrent), value);
    }

    /// <summary>
    /// Максимальное реактивное сопротивление, Ом.
    /// </summary>
    public float? xGroundMax
    {
        get => GetAttribute<float?>(nameof(xGroundMax));
        set => SetAttribute(nameof(xGroundMax), value);
    }

    /// <summary>
    /// Минимальное реактивное сопротивление, Ом.
    /// </summary>
    public float? xGroundMin
    {
        get => GetAttribute<float?>(nameof(xGroundMin));
        set => SetAttribute(nameof(xGroundMin), value);
    }

    /// <summary>
    /// Номинальное реактивное сопротивление, Ом.
    /// </summary>
    public float? xGroundNominal
    {
        get => GetAttribute<float?>(nameof(xGroundNominal));
        set => SetAttribute(nameof(xGroundNominal), value);
    }
}