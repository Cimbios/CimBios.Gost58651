using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Физически контролирует доступ к AssetContainers.
/// </summary>
[CimClass(ClassUri)]
public partial class Seal(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Seal";

    /// <summary>
    /// Дата и время нанесения пломбы [Дата и время].
    /// </summary>
    public DateTime? appliedDateTime
    {
        get => GetAttribute<DateTime?>(nameof(appliedDateTime));
        set => SetAttribute(nameof(appliedDateTime), value);
    }

    /// <summary>
    /// Состояние пломбы.
    /// </summary>
    public SealConditionKind? condition
    {
        get => GetAttribute<SealConditionKind?>(nameof(condition));
        set => SetAttribute(nameof(condition), value);
    }

    /// <summary>
    /// Вид пломбы.
    /// </summary>
    public SealKind? kind
    {
        get => GetAttribute<SealKind?>(nameof(kind));
        set => SetAttribute(nameof(kind), value);
    }

    /// <summary>
    /// Номер пломбы.
    /// </summary>
    public string? sealNumber
    {
        get => GetAttribute<string?>(nameof(sealNumber));
        set => SetAttribute(nameof(sealNumber), value);
    }

    /// <summary>
    /// Контролируемый контейнер материальных объектов.
    /// </summary>
    public AssetContainer? AssetContainer
    {
        get => GetAssoc1To1<AssetContainer>(nameof(AssetContainer));
        set => SetAssoc1To1(nameof(AssetContainer), value);
    }
}