using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Многофункциональная кривая.
/// </summary>
[CimClass(ClassUri)]
public partial class Curve(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Curve";

    /// <summary>
    /// Тип кривой.
    /// </summary>
    public CurveStyle? curveStyle
    {
        get => GetAttribute<CurveStyle?>(nameof(curveStyle));
        set => SetAttribute(nameof(curveStyle), value);
    }

    /// <summary>
    /// Множитель по оси X.
    /// </summary>
    public UnitMultiplier? xMultiplier
    {
        get => GetAttribute<UnitMultiplier?>(nameof(xMultiplier));
        set => SetAttribute(nameof(xMultiplier), value);
    }

    /// <summary>
    /// Единица измерения по оси X.
    /// </summary>
    public UnitSymbol? xUnit
    {
        get => GetAttribute<UnitSymbol?>(nameof(xUnit));
        set => SetAttribute(nameof(xUnit), value);
    }

    /// <summary>
    /// Множитель по оси Y1.
    /// </summary>
    public UnitMultiplier? y1Multiplier
    {
        get => GetAttribute<UnitMultiplier?>(nameof(y1Multiplier));
        set => SetAttribute(nameof(y1Multiplier), value);
    }

    /// <summary>
    /// Единица измерения по оси Y1.
    /// </summary>
    public UnitSymbol? y1Unit
    {
        get => GetAttribute<UnitSymbol?>(nameof(y1Unit));
        set => SetAttribute(nameof(y1Unit), value);
    }

    /// <summary>
    /// Множитель по оси Y2.
    /// </summary>
    public UnitMultiplier? y2Multiplier
    {
        get => GetAttribute<UnitMultiplier?>(nameof(y2Multiplier));
        set => SetAttribute(nameof(y2Multiplier), value);
    }

    /// <summary>
    /// Единица измерения по оси Y2.
    /// </summary>
    public UnitSymbol? y2Unit
    {
        get => GetAttribute<UnitSymbol?>(nameof(y2Unit));
        set => SetAttribute(nameof(y2Unit), value);
    }

    /// <summary>
    /// Множитель по оси Y3.
    /// </summary>
    public UnitMultiplier? y3Multiplier
    {
        get => GetAttribute<UnitMultiplier?>(nameof(y3Multiplier));
        set => SetAttribute(nameof(y3Multiplier), value);
    }

    /// <summary>
    /// Единица измерения по оси Y3.
    /// </summary>
    public UnitSymbol? y3Unit
    {
        get => GetAttribute<UnitSymbol?>(nameof(y3Unit));
        set => SetAttribute(nameof(y3Unit), value);
    }


    /// <summary>
    /// Данные многофункциональной кривой.
    /// </summary>
    public CurveData[] CurveDatas => GetAssoc1ToM<CurveData>(nameof(CurveDatas));

    public void AddToCurveDatas(CurveData assocObject) => AddAssoc1ToM(nameof(CurveDatas), assocObject);
    public void RemoveFromCurveDatas(CurveData assocObject) => RemoveAssoc1ToM(nameof(CurveDatas), assocObject);
    public void RemoveAllFromCurveDatas() => RemoveAllAssocs1ToM(nameof(CurveDatas));
}