using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Строка таблицы зависимости параметров обмотки трансформатора от положения регулировочного ответвления.
/// </summary>
[CimClass(ClassUri)]
public partial class TapChangerTablePoint(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#TapChangerTablePoint";

    /// <summary>
    /// Отклонение реактивной проводимости намагничивания от номинального значения, %.
    /// </summary>
    public float? b
    {
        get => GetAttribute<float?>(nameof(b));
        set => SetAttribute(nameof(b), value);
    }

    /// <summary>
    /// Отклонение активной проводимости намагничивания от номинального значения, %.
    /// </summary>
    public float? g
    {
        get => GetAttribute<float?>(nameof(g));
        set => SetAttribute(nameof(g), value);
    }

    /// <summary>
    /// Отклонение продольного активного сопротивления обмотки от номинального значения, %.
    /// </summary>
    public float? r
    {
        get => GetAttribute<float?>(nameof(r));
        set => SetAttribute(nameof(r), value);
    }

    /// <summary>
    /// Отношение напряжения для заданного положения регулировочного ответвления к номинальному, о.е.
    /// </summary>
    public float? ratio
    {
        get => GetAttribute<float?>(nameof(ratio));
        set => SetAttribute(nameof(ratio), value);
    }

    /// <summary>
    /// Положение регулировочного ответвления.
    /// </summary>
    public int? step
    {
        get => GetAttribute<int?>(nameof(step));
        set => SetAttribute(nameof(step), value);
    }

    /// <summary>
    /// Отклонение продольного реактивного сопротивления обмотки от номинального значения, %.
    /// </summary>
    public float? x
    {
        get => GetAttribute<float?>(nameof(x));
        set => SetAttribute(nameof(x), value);
    }
}