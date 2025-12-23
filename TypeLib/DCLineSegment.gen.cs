using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Участок линии постоянного тока.
/// </summary>
[CimClass(ClassUri)]
public partial class DCLineSegment(IOIDDescriptor oid, ICimMetaClass metaClass)
    : DCConductingEquipment(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#DCLineSegment";

    /// <summary>
    /// Емкость участка линии постоянного тока, Ф.
    /// </summary>
    public float? capacitance
    {
        get => GetAttribute<float?>(nameof(capacitance));
        set => SetAttribute(nameof(capacitance), value);
    }

    /// <summary>
    /// Индуктивность участка линии постоянного тока, Гн.
    /// </summary>
    public float? inductance
    {
        get => GetAttribute<float?>(nameof(inductance));
        set => SetAttribute(nameof(inductance), value);
    }

    /// <summary>
    /// Длина участка линии, используемая для расчета характеристик участка линии, м.
    /// </summary>
    public float? length
    {
        get => GetAttribute<float?>(nameof(length));
        set => SetAttribute(nameof(length), value);
    }

    /// <summary>
    /// Сопротивление участка линии постоянного тока, Ом.
    /// </summary>
    public float? resistance
    {
        get => GetAttribute<float?>(nameof(resistance));
        set => SetAttribute(nameof(resistance), value);
    }
}