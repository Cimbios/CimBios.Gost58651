using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Вторичная обмотка измерительного трансформатора.
/// </summary>
[CimClass(ClassUri)]
public partial class SensorWinding(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#SensorWinding";

    /// <summary>
    /// Класс точности.
    /// </summary>
    public string? accuracyClass
    {
        get => GetAttribute<string?>(nameof(accuracyClass));
        set => SetAttribute(nameof(accuracyClass), value);
    }

    /// <summary>
    /// Схема соединения обмоток.
    /// </summary>
    public WindingConnection? connectionKind
    {
        get => GetAttribute<WindingConnection?>(nameof(connectionKind));
        set => SetAttribute(nameof(connectionKind), value);
    }

    /// <summary>
    /// Номинальная полная мощность, МВА.
    /// </summary>
    public float? ratedS
    {
        get => GetAttribute<float?>(nameof(ratedS));
        set => SetAttribute(nameof(ratedS), value);
    }
}