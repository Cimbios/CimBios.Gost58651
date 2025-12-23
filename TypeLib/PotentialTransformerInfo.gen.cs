using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Свойства ТН.
/// </summary>
[CimClass(ClassUri)]
public partial class PotentialTransformerInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AssetInfo(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PotentialTransformerInfo";

    /// <summary>
    /// Передаточное отношение для устройства РПН первичной обмотки.
    /// </summary>
    public Ratio? primaryRatio
    {
        get => GetAttribute<Ratio?>(nameof(primaryRatio));
        set => SetAttribute(nameof(primaryRatio), value);
    }

    /// <summary>
    /// Класс ТН.
    /// </summary>
    public string? ptClass
    {
        get => GetAttribute<string?>(nameof(ptClass));
        set => SetAttribute(nameof(ptClass), value);
    }

    /// <summary>
    /// Номинальное напряжение на первичной стороне, В.
    /// </summary>
    public float? ratedVoltage
    {
        get => GetAttribute<float?>(nameof(ratedVoltage));
        set => SetAttribute(nameof(ratedVoltage), value);
    }

    /// <summary>
    /// Передаточное отношение для устройства РПН вторичной обмотки.
    /// </summary>
    public Ratio? secondaryRatio
    {
        get => GetAttribute<Ratio?>(nameof(secondaryRatio));
        set => SetAttribute(nameof(secondaryRatio), value);
    }

    /// <summary>
    /// Передаточное отношение для устройства РПН третичной обмотки.
    /// </summary>
    public Ratio? tertiaryRatio
    {
        get => GetAttribute<Ratio?>(nameof(tertiaryRatio));
        set => SetAttribute(nameof(tertiaryRatio), value);
    }
}