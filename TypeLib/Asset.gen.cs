using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Материальный объект.
/// </summary>
[CimClass(ClassUri)]
public partial class Asset(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Asset";

    /// <summary>
    /// Состояние материального объекта на складе или во время установки.
    /// </summary>
    public string? baselineCondition
    {
        get => GetAttribute<string?>(nameof(baselineCondition));
        set => SetAttribute(nameof(baselineCondition), value);
    }

    /// <summary>
    /// Процент ожидаемого срока службы нового материального объекта, когда материальный объект восстанавливается; ноль для новых устройств [Проценты].
    /// </summary>
    public float? baselineLossOfLife
    {
        get => GetAttribute<float?>(nameof(baselineLossOfLife));
        set => SetAttribute(nameof(baselineLossOfLife), value);
    }

    /// <summary>
    /// Электронный адрес устройства.
    /// </summary>
    public ElectronicAddress? electronicAddress
    {
        get => GetAttribute<ElectronicAddress?>(nameof(electronicAddress));
        set => SetAttribute(nameof(electronicAddress), value);
    }

    /// <summary>
    /// Даты этапов ввода в эксплуатацию.
    /// </summary>
    public InUseDate? inUseDate
    {
        get => GetAttribute<InUseDate?>(nameof(inUseDate));
        set => SetAttribute(nameof(inUseDate), value);
    }

    /// <summary>
    /// Виды состояний ввода в эксплуатацию.
    /// </summary>
    public InUseStateKind? inUseState
    {
        get => GetAttribute<InUseStateKind?>(nameof(inUseState));
        set => SetAttribute(nameof(inUseState), value);
    }

    /// <summary>
    /// Даты этапов жизненного цикла актива/материального объекта.
    /// </summary>
    public LifecycleDate? lifecycleDate
    {
        get => GetAttribute<LifecycleDate?>(nameof(lifecycleDate));
        set => SetAttribute(nameof(lifecycleDate), value);
    }

    /// <summary>
    /// Номер партии устройства.
    /// </summary>
    public string? lotNumber
    {
        get => GetAttribute<string?>(nameof(lotNumber));
        set => SetAttribute(nameof(lotNumber), value);
    }

    /// <summary>
    /// Положение материального объекта (обычно в отношении других материальных объектов).
    /// </summary>
    public string? position
    {
        get => GetAttribute<string?>(nameof(position));
        set => SetAttribute(nameof(position), value);
    }

    /// <summary>
    /// Серийный номер устройства.
    /// </summary>
    public string? serialNumber
    {
        get => GetAttribute<string?>(nameof(serialNumber));
        set => SetAttribute(nameof(serialNumber), value);
    }

    /// <summary>
    /// Состояние.
    /// </summary>
    public string? status
    {
        get => GetAttribute<string?>(nameof(status));
        set => SetAttribute(nameof(status), value);
    }

    /// <summary>
    /// Тип материального объекта.
    /// </summary>
    public string? type
    {
        get => GetAttribute<string?>(nameof(type));
        set => SetAttribute(nameof(type), value);
    }

    /// <summary>
    /// Уникально отслеживаемый товарный номер (UTC).
    /// </summary>
    public string? utcNumber
    {
        get => GetAttribute<string?>(nameof(utcNumber));
        set => SetAttribute(nameof(utcNumber), value);
    }

    /// <summary>
    /// Модель материального объекта.
    /// </summary>
    public ProductAssetModel? ProductAssetModel
    {
        get => GetAssoc1To1<ProductAssetModel>(nameof(ProductAssetModel));
        set => SetAssoc1To1(nameof(ProductAssetModel), value);
    }

    /// <summary>
    /// Материальный объект, включающий в себя текущий материальный объект.
    /// </summary>
    public AssetContainer? AssetContainer
    {
        get => GetAssoc1To1<AssetContainer>(nameof(AssetContainer));
        set => SetAssoc1To1(nameof(AssetContainer), value);
    }

    /// <summary>
    /// Информация о внедрении материального объекта.
    /// </summary>
    public AssetDeployment? AssetDeployment
    {
        get => GetAssoc1To1<AssetDeployment>(nameof(AssetDeployment));
        set => SetAssoc1To1(nameof(AssetDeployment), value);
    }

    /// <summary>
    /// Техническая информация о материальном объекте.
    /// </summary>
    public AssetInfo? AssetInfo
    {
        get => GetAssoc1To1<AssetInfo>(nameof(AssetInfo));
        set => SetAssoc1To1(nameof(AssetInfo), value);
    }

    /// <summary>
    /// Информация о расположении материального объекта.
    /// </summary>
    public Location? Location
    {
        get => GetAssoc1To1<Location>(nameof(Location));
        set => SetAssoc1To1(nameof(Location), value);
    }

    /// <summary>
    /// Организационные роли материального объекта.
    /// </summary>
    public AssetOrganisationRole[] AssetOrganisationRoles =>
        GetAssoc1ToM<AssetOrganisationRole>(nameof(AssetOrganisationRoles));

    public void AddToAssetOrganisationRoles(AssetOrganisationRole assocObject) =>
        AddAssoc1ToM(nameof(AssetOrganisationRoles), assocObject);

    public void RemoveFromAssetOrganisationRoles(AssetOrganisationRole assocObject) =>
        RemoveAssoc1ToM(nameof(AssetOrganisationRoles), assocObject);

    public void RemoveAllFromAssetOrganisationRoles() => RemoveAllAssocs1ToM(nameof(AssetOrganisationRoles));

    /// <summary>
    /// Записи активности материального объекта.
    /// </summary>
    public ActivityRecord[] ActivityRecords => GetAssoc1ToM<ActivityRecord>(nameof(ActivityRecords));

    public void AddToActivityRecords(ActivityRecord assocObject) => AddAssoc1ToM(nameof(ActivityRecords), assocObject);

    public void RemoveFromActivityRecords(ActivityRecord assocObject) =>
        RemoveAssoc1ToM(nameof(ActivityRecords), assocObject);

    public void RemoveAllFromActivityRecords() => RemoveAllAssocs1ToM(nameof(ActivityRecords));

    /// <summary>
    /// События конфигурирования материального объекта.
    /// </summary>
    public ConfigurationEvent[] ConfigurationEvents => GetAssoc1ToM<ConfigurationEvent>(nameof(ConfigurationEvents));

    public void AddToConfigurationEvents(ConfigurationEvent assocObject) =>
        AddAssoc1ToM(nameof(ConfigurationEvents), assocObject);

    public void RemoveFromConfigurationEvents(ConfigurationEvent assocObject) =>
        RemoveAssoc1ToM(nameof(ConfigurationEvents), assocObject);

    public void RemoveAllFromConfigurationEvents() => RemoveAllAssocs1ToM(nameof(ConfigurationEvents));

    /// <summary>
    /// Объекты энергосистемы, ассоциированные с материальным объектом.
    /// </summary>
    public PowerSystemResource[] PowerSystemResources =>
        GetAssoc1ToM<PowerSystemResource>(nameof(PowerSystemResources));

    public void AddToPowerSystemResources(PowerSystemResource assocObject) =>
        AddAssoc1ToM(nameof(PowerSystemResources), assocObject);

    public void RemoveFromPowerSystemResources(PowerSystemResource assocObject) =>
        RemoveAssoc1ToM(nameof(PowerSystemResources), assocObject);

    public void RemoveAllFromPowerSystemResources() => RemoveAllAssocs1ToM(nameof(PowerSystemResources));
}