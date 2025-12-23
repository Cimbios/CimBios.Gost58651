using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Регулируемое шунтирующее компенсирующее устройство.
/// </summary>
[CimClass(ClassUri)]
public partial class StaticVarCompensator(IOIDDescriptor oid, ICimMetaClass metaClass)
    : RegulatingCondEq(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#StaticVarCompensator";

    /// <summary>
    /// Емкостное сопротивление при максимальной генерируемой реактивной мощности (положительное значение), Ом.
    /// </summary>
    public float? capacitiveRating
    {
        get => GetAttribute<float?>(nameof(capacitiveRating));
        set => SetAttribute(nameof(capacitiveRating), value);
    }

    /// <summary>
    /// Индуктивное сопротивление при максимальной потребляемой реактивной мощности (отрицательное значение), Ом.
    /// </summary>
    public float? inductiveRating
    {
        get => GetAttribute<float?>(nameof(inductiveRating));
        set => SetAttribute(nameof(inductiveRating), value);
    }

    /// <summary>
    /// Верхняя граница регулировочного диапазона, Мвар.
    /// </summary>
    public float? maxQ
    {
        get => GetAttribute<float?>(nameof(maxQ));
        set => SetAttribute(nameof(maxQ), value);
    }

    /// <summary>
    /// Нижняя граница регулировочного диапазона, Мвар.
    /// </summary>
    public float? minQ
    {
        get => GetAttribute<float?>(nameof(minQ));
        set => SetAttribute(nameof(minQ), value);
    }

    /// <summary>
    /// Активное сопротивление прямой последовательности, Ом,
    /// </summary>
    public float? r
    {
        get => GetAttribute<float?>(nameof(r));
        set => SetAttribute(nameof(r), value);
    }

    /// <summary>
    /// Активное сопротивление нулевой последовательности, Ом.
    /// </summary>
    public float? r0
    {
        get => GetAttribute<float?>(nameof(r0));
        set => SetAttribute(nameof(r0), value);
    }

    /// <summary>
    /// Статизм регулирования напряжения по реактивной мощности dU/dQ, кВ/Мвар.
    /// </summary>
    public float? slope
    {
        get => GetAttribute<float?>(nameof(slope));
        set => SetAttribute(nameof(slope), value);
    }
}