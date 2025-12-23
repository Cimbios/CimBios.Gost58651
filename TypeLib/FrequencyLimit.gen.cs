using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Эксплуатационное ограничение/предел по частоте.
/// </summary>
[CimClass(ClassUri)]
public partial class FrequencyLimit(IOIDDescriptor oid, ICimMetaClass metaClass)
    : OperationalLimit(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#FrequencyLimit";

    /// <summary>
    /// Нормальное значение эксплуатационного ограничения/предела по частоте, Гц.
    /// </summary>
    public float? normalValue
    {
        get => GetAttribute<float?>(nameof(normalValue));
        set => SetAttribute(nameof(normalValue), value);
    }

    /// <summary>
    /// Значение эксплуатационного ограничения/предела по частоте, Гц.
    /// </summary>
    public float? value
    {
        get => GetAttribute<float?>(nameof(value));
        set => SetAttribute(nameof(value), value);
    }
}