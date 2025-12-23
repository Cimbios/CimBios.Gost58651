using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Данные многофункциональной кривой.
/// </summary>
[CimClass(ClassUri)]
public partial class CurveData(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#CurveData";

    /// <summary>
    /// Значение по оси X.
    /// </summary>
    public float? xvalue
    {
        get => GetAttribute<float?>(nameof(xvalue));
        set => SetAttribute(nameof(xvalue), value);
    }

    /// <summary>
    /// Значение по оси Y1.
    /// </summary>
    public float? y1value
    {
        get => GetAttribute<float?>(nameof(y1value));
        set => SetAttribute(nameof(y1value), value);
    }

    /// <summary>
    /// Значение по оси Y2.
    /// </summary>
    public float? y2value
    {
        get => GetAttribute<float?>(nameof(y2value));
        set => SetAttribute(nameof(y2value), value);
    }

    /// <summary>
    /// Значение по оси Y3.
    /// </summary>
    public float? y3value
    {
        get => GetAttribute<float?>(nameof(y3value));
        set => SetAttribute(nameof(y3value), value);
    }

    /// <summary>
    /// Многофункциональная кривая, к которой относится параметр кривой.
    /// </summary>
    public Curve? Curve
    {
        get => GetAssoc1To1<Curve>(nameof(Curve));
        set => SetAssoc1To1(nameof(Curve), value);
    }
}