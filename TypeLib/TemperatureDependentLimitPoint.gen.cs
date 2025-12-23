using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Строка таблицы зависимости эксплуатационных ограничений/пределов от температуры.
/// </summary>
[CimClass(ClassUri)]
public partial class TemperatureDependentLimitPoint(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#TemperatureDependentLimitPoint";

    /// <summary>
    /// Допустимость интерполяции при промежуточных значениях температуры (по умолчанию � &#171;истина&#187;).При недопустимости интерполяции для промежуточных значений температур принимаются указанные значения для ближайшей большей температуры
    /// </summary>
    public bool? interpolation
    {
        get => GetAttribute<bool?>(nameof(interpolation));
        set => SetAttribute(nameof(interpolation), value);
    }

    /// <summary>
    /// Отношение значения эксплуатационного ограничения/предела для заданной температуры к нормальному значению эксплуатационного ограничения/предела, %.
    /// </summary>
    public float? limitPercent
    {
        get => GetAttribute<float?>(nameof(limitPercent));
        set => SetAttribute(nameof(limitPercent), value);
    }

    /// <summary>
    /// Температура, &#176;C.
    /// </summary>
    public float? temperature
    {
        get => GetAttribute<float?>(nameof(temperature));
        set => SetAttribute(nameof(temperature), value);
    }

    /// <summary>
    /// Таблица зависимости эксплуатационных ограничений/пределов от температуры.
    /// </summary>
    public TemperatureDependentLimitTable? TemperatureDependentLimitTable
    {
        get => GetAssoc1To1<TemperatureDependentLimitTable>(nameof(TemperatureDependentLimitTable));
        set => SetAssoc1To1(nameof(TemperatureDependentLimitTable), value);
    }
}