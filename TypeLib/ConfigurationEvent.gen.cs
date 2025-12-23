using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Используется для отчета о создании, изменении или удалении объекта или его конфигурирования.
/// </summary>
[CimClass(ClassUri)]
public partial class ConfigurationEvent(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ActivityRecord(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ConfigurationEvent";

    /// <summary>
    /// Дата и время, когда событие вступило или вступит в силу [Дата и Время].
    /// </summary>
    public DateTime? effectiveDateTime
    {
        get => GetAttribute<DateTime?>(nameof(effectiveDateTime));
        set => SetAttribute(nameof(effectiveDateTime), value);
    }

    /// <summary>
    /// Источник/инициатор модификации.
    /// </summary>
    public string? modifiedBy
    {
        get => GetAttribute<string?>(nameof(modifiedBy));
        set => SetAttribute(nameof(modifiedBy), value);
    }

    /// <summary>
    /// Замечания в виде произвольного текста.
    /// </summary>
    public string? remark
    {
        get => GetAttribute<string?>(nameof(remark));
        set => SetAttribute(nameof(remark), value);
    }

    /// <summary>
    /// Роль организации, к котоой относится событие конфигурирования.
    /// </summary>
    public OrganisationRole? ChangedOrganisationRole
    {
        get => GetAssoc1To1<OrganisationRole>(nameof(ChangedOrganisationRole));
        set => SetAssoc1To1(nameof(ChangedOrganisationRole), value);
    }

    /// <summary>
    /// Точка поставки, изменение которой привело к данному событию конфигурирования.
    /// </summary>
    public UsagePoint? ChangedUsagePoint
    {
        get => GetAssoc1To1<UsagePoint>(nameof(ChangedUsagePoint));
        set => SetAssoc1To1(nameof(ChangedUsagePoint), value);
    }

    /// <summary>
    /// Материальный объект, изменение которого привело к данному событию конфигурирования.
    /// </summary>
    public Asset? ChangedAsset
    {
        get => GetAssoc1To1<Asset>(nameof(ChangedAsset));
        set => SetAssoc1To1(nameof(ChangedAsset), value);
    }

    /// <summary>
    /// Расположение материальных объектов и энергообъектов, изменение которого привело к данному событию конфигурирования.
    /// </summary>
    public Location? ChangedLocation
    {
        get => GetAssoc1To1<Location>(nameof(ChangedLocation));
        set => SetAssoc1To1(nameof(ChangedLocation), value);
    }

    /// <summary>
    /// Документ, изменение которого привело к данному событию конфигурирования.
    /// </summary>
    public Document? ChangedDocument
    {
        get => GetAssoc1To1<Document>(nameof(ChangedDocument));
        set => SetAssoc1To1(nameof(ChangedDocument), value);
    }
}