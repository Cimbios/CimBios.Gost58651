using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Измеряемый дискретный параметр.
/// </summary>
[CimClass(ClassUri)]
public partial class Discrete(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Measurement(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Discrete";

    /// <summary>
    /// Максимальное значение нормального диапазона допустимого значения для измерения.
    /// </summary>
    public int? maxValue
    {
        get => GetAttribute<int?>(nameof(maxValue));
        set => SetAttribute(nameof(maxValue), value);
    }

    /// <summary>
    /// Минимальное значение нормального диапазона допустимого значения для измерения.
    /// </summary>
    public int? minValue
    {
        get => GetAttribute<int?>(nameof(minValue));
        set => SetAttribute(nameof(minValue), value);
    }

    /// <summary>
    /// Нормальное измеренное значение, например, использованное в процентных расчетах.
    /// </summary>
    public int? normalValue
    {
        get => GetAttribute<int?>(nameof(normalValue));
        set => SetAttribute(nameof(normalValue), value);
    }


    /// <summary>
    /// Значения дискретных измерений.
    /// </summary>
    public DiscreteValue[] DiscreteValues => GetAssoc1ToM<DiscreteValue>(nameof(DiscreteValues));

    public void AddToDiscreteValues(DiscreteValue assocObject) => AddAssoc1ToM(nameof(DiscreteValues), assocObject);

    public void RemoveFromDiscreteValues(DiscreteValue assocObject) =>
        RemoveAssoc1ToM(nameof(DiscreteValues), assocObject);

    public void RemoveAllFromDiscreteValues() => RemoveAllAssocs1ToM(nameof(DiscreteValues));
}