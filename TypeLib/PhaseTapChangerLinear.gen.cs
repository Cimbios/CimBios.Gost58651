using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Фазоповоротное устройство с линейной зависимостью.
/// </summary>
[CimClass(ClassUri)]
public partial class PhaseTapChangerLinear(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PhaseTapChanger(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PhaseTapChangerLinear";

    /// <summary>
    /// Изменение фазового угла при изменении позиции регулировочного ответвления на один шаг, град.
    /// </summary>
    public float? stepPhaseShiftIncrement
    {
        get => GetAttribute<float?>(nameof(stepPhaseShiftIncrement));
        set => SetAttribute(nameof(stepPhaseShiftIncrement), value);
    }

    /// <summary>
    /// Максимальное индуктивное сопротивление луча звезды, Ом.
    /// </summary>
    public float? xMax
    {
        get => GetAttribute<float?>(nameof(xMax));
        set => SetAttribute(nameof(xMax), value);
    }

    /// <summary>
    /// Минимальное индуктивное сопротивление луча звезды, Ом.
    /// </summary>
    public float? xMin
    {
        get => GetAttribute<float?>(nameof(xMin));
        set => SetAttribute(nameof(xMin), value);
    }
}