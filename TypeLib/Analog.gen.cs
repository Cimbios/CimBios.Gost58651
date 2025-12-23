using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Измеряемый аналоговый параметр.
/// </summary>
[CimClass(ClassUri)]
public partial class Analog(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Measurement(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Analog";

    /// <summary>
    /// Максимальное значение нормального диапазона допустимого значения для измерения.
    /// </summary>
    public float? maxValue
    {
        get => GetAttribute<float?>(nameof(maxValue));
        set => SetAttribute(nameof(maxValue), value);
    }

    /// <summary>
    /// Минимальное значение нормального диапазона допустимого значения для измерения.
    /// </summary>
    public float? minValue
    {
        get => GetAttribute<float?>(nameof(minValue));
        set => SetAttribute(nameof(minValue), value);
    }

    /// <summary>
    /// Нормальное измеренное значение, например использованное в процентных расчетах.
    /// </summary>
    public float? normalValue
    {
        get => GetAttribute<float?>(nameof(normalValue));
        set => SetAttribute(nameof(normalValue), value);
    }

    /// <summary>
    /// Указывает, что положительное значение перетока мощности или тока соответствует направлению извне в полюс оборудования.
    /// </summary>
    public bool? positiveFlowIn
    {
        get => GetAttribute<bool?>(nameof(positiveFlowIn));
        set => SetAttribute(nameof(positiveFlowIn), value);
    }


    /// <summary>
    /// Значения аналоговых измерений.
    /// </summary>
    public AnalogValue[] AnalogValues => GetAssoc1ToM<AnalogValue>(nameof(AnalogValues));

    public void AddToAnalogValues(AnalogValue assocObject) => AddAssoc1ToM(nameof(AnalogValues), assocObject);
    public void RemoveFromAnalogValues(AnalogValue assocObject) => RemoveAssoc1ToM(nameof(AnalogValues), assocObject);
    public void RemoveAllFromAnalogValues() => RemoveAllAssocs1ToM(nameof(AnalogValues));
}