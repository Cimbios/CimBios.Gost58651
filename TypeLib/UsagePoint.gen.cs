using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Точка поставки.
/// </summary>
[CimClass(ClassUri)]
public partial class UsagePoint(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#UsagePoint";

    /// <summary>
    /// Жизненный цикл системы считывания показаний в точке поставки в отношении готовности к выставлению счетов с помощью расширенной инфраструктуры считываний показаний.
    /// </summary>
    public AmiBillingReadyKind? amiBillingReady
    {
        get => GetAttribute<AmiBillingReadyKind?>(nameof(amiBillingReady));
        set => SetAttribute(nameof(amiBillingReady), value);
    }

    /// <summary>
    /// TRUE, если в результате проверки или иным образом есть основания подозревать, что предыдущий биллинг мог быть выполнен с ошибочными данными. Значение следует сбросить после устранения этого потенциального несоответствия.
    /// </summary>
    public bool? checkBilling
    {
        get => GetAttribute<bool?>(nameof(checkBilling));
        set => SetAttribute(nameof(checkBilling), value);
    }

    /// <summary>
    /// Состояние точки поставки по отношению к подключению к сети.
    /// </summary>
    public UsagePointConnectedKind? connectionState
    {
        get => GetAttribute<UsagePointConnectedKind?>(nameof(connectionState));
        set => SetAttribute(nameof(connectionState), value);
    }

    /// <summary>
    /// Плановый график, Вт.
    /// </summary>
    public float? estimatedLoad
    {
        get => GetAttribute<float?>(nameof(estimatedLoad));
        set => SetAttribute(nameof(estimatedLoad), value);
    }

    /// <summary>
    /// TRUE, если заземлено.
    /// </summary>
    public bool? grounded
    {
        get => GetAttribute<bool?>(nameof(grounded));
        set => SetAttribute(nameof(grounded), value);
    }

    /// <summary>
    /// Если TRUE, то точка поставки является точкой предоставления услуг, то есть точкой поставки, где право собственности на услугу переходит из рук в руки.
    /// </summary>
    public bool? isSdp
    {
        get => GetAttribute<bool?>(nameof(isSdp));
        set => SetAttribute(nameof(isSdp), value);
    }

    /// <summary>
    /// Если TRUE, то точка поставки является виртуальной, то есть в сети не существует физического местоположения, где можно было бы разместить прибор учета для сбора показаний.
    /// </summary>
    public bool? isVirtual
    {
        get => GetAttribute<bool?>(nameof(isVirtual));
        set => SetAttribute(nameof(isVirtual), value);
    }

    /// <summary>
    /// Если TRUE, то минимальное или нулевое использование ожидается в точке поставки для таких ситуаций, как логическое или физическое отключение.
    /// </summary>
    public bool? minimalUsageExpected
    {
        get => GetAttribute<bool?>(nameof(minimalUsageExpected));
        set => SetAttribute(nameof(minimalUsageExpected), value);
    }

    /// <summary>
    /// Номинальное рабочее напряжение.
    /// </summary>
    public float? nominalServiceVoltage
    {
        get => GetAttribute<float?>(nameof(nominalServiceVoltage));
        set => SetAttribute(nameof(nominalServiceVoltage), value);
    }

    /// <summary>
    /// Область отключения подачи электроэнергии, в которой расположена данная точка поставки.
    /// </summary>
    public string? outageRegion
    {
        get => GetAttribute<string?>(nameof(outageRegion));
        set => SetAttribute(nameof(outageRegion), value);
    }

    /// <summary>
    /// Код фазы.
    /// </summary>
    public PhaseCode? phaseCode
    {
        get => GetAttribute<PhaseCode?>(nameof(phaseCode));
        set => SetAttribute(nameof(phaseCode), value);
    }

    /// <summary>
    /// Направление тока, на которое настроена точка поставки.
    /// </summary>
    public float? ratedCurrent
    {
        get => GetAttribute<float?>(nameof(ratedCurrent));
        set => SetAttribute(nameof(ratedCurrent), value);
    }

    /// <summary>
    /// Максимальная мощность в точке поставки.
    /// </summary>
    public float? ratedPower
    {
        get => GetAttribute<float?>(nameof(ratedPower));
        set => SetAttribute(nameof(ratedPower), value);
    }

    /// <summary>
    /// День цикла, как правило, в который считывается прибор учета в точке поставки.
    /// </summary>
    public string? readCycle
    {
        get => GetAttribute<string?>(nameof(readCycle));
        set => SetAttribute(nameof(readCycle), value);
    }

    /// <summary>
    /// Идентификатор маршрута, которому назначена точка поставки для целей считывания показаний прибора учета.
    /// </summary>
    public string? readRoute
    {
        get => GetAttribute<string?>(nameof(readRoute));
        set => SetAttribute(nameof(readRoute), value);
    }

    /// <summary>
    /// Замечания о точке поставки, например: причина, по которой ей присвоен неноминальный приоритет.
    /// </summary>
    public string? serviceDeliveryRemark
    {
        get => GetAttribute<string?>(nameof(serviceDeliveryRemark));
        set => SetAttribute(nameof(serviceDeliveryRemark), value);
    }

    /// <summary>
    /// Приоритетное обслуживание данной точки поставки.
    /// </summary>
    public string? servicePriority
    {
        get => GetAttribute<string?>(nameof(servicePriority));
        set => SetAttribute(nameof(servicePriority), value);
    }

    /// <summary>
    /// Расположение точки учета.
    /// </summary>
    public UsagePointLocation? UsagePointLocation
    {
        get => GetAssoc1To1<UsagePointLocation>(nameof(UsagePointLocation));
        set => SetAssoc1To1(nameof(UsagePointLocation), value);
    }

    /// <summary>
    /// Договор с потребителем, регулирующий данную точку поставки.
    /// </summary>
    public CustomerAgreement? CustomerAgreement
    {
        get => GetAssoc1To1<CustomerAgreement>(nameof(CustomerAgreement));
        set => SetAssoc1To1(nameof(CustomerAgreement), value);
    }

    /// <summary>
    /// Категория услуг, предоставляемая точкой поставки.
    /// </summary>
    public ServiceCategory? ServiceCategory
    {
        get => GetAssoc1To1<ServiceCategory>(nameof(ServiceCategory));
        set => SetAssoc1To1(nameof(ServiceCategory), value);
    }

    /// <summary>
    /// Объект энергоснабжения, обслуживаемый точкой поставки.
    /// </summary>
    public ServiceLocation? ServiceLocation
    {
        get => GetAssoc1To1<ServiceLocation>(nameof(ServiceLocation));
        set => SetAssoc1To1(nameof(ServiceLocation), value);
    }

    /// <summary>
    /// Поставщик услуг, использующий точку поставки для предоставления услуг.
    /// </summary>
    public ServiceSupplier? ServiceSupplier
    {
        get => GetAssoc1To1<ServiceSupplier>(nameof(ServiceSupplier));
        set => SetAssoc1To1(nameof(ServiceSupplier), value);
    }

    /// <summary>
    /// Оконечные устройства точки поставки.
    /// </summary>
    public EndDevice[] EndDevices => GetAssoc1ToM<EndDevice>(nameof(EndDevices));

    public void AddToEndDevices(EndDevice assocObject) => AddAssoc1ToM(nameof(EndDevices), assocObject);
    public void RemoveFromEndDevices(EndDevice assocObject) => RemoveAssoc1ToM(nameof(EndDevices), assocObject);
    public void RemoveAllFromEndDevices() => RemoveAllAssocs1ToM(nameof(EndDevices));

    /// <summary>
    /// Элементы управления конечными устройствами, отправляющие команды в эту точку поставки.
    /// </summary>
    public EndDeviceControl[] EndDeviceControls => GetAssoc1ToM<EndDeviceControl>(nameof(EndDeviceControls));

    public void AddToEndDeviceControls(EndDeviceControl assocObject) =>
        AddAssoc1ToM(nameof(EndDeviceControls), assocObject);

    public void RemoveFromEndDeviceControls(EndDeviceControl assocObject) =>
        RemoveAssoc1ToM(nameof(EndDeviceControls), assocObject);

    public void RemoveAllFromEndDeviceControls() => RemoveAllAssocs1ToM(nameof(EndDeviceControls));

    /// <summary>
    /// События конечных устройств для этой точки поставки.
    /// </summary>
    public EndDeviceEvent[] EndDeviceEvents => GetAssoc1ToM<EndDeviceEvent>(nameof(EndDeviceEvents));

    public void AddToEndDeviceEvents(EndDeviceEvent assocObject) => AddAssoc1ToM(nameof(EndDeviceEvents), assocObject);

    public void RemoveFromEndDeviceEvents(EndDeviceEvent assocObject) =>
        RemoveAssoc1ToM(nameof(EndDeviceEvents), assocObject);

    public void RemoveAllFromEndDeviceEvents() => RemoveAllAssocs1ToM(nameof(EndDeviceEvents));

    /// <summary>
    /// Показания прибора учета, полученные из этой точки поставки.
    /// </summary>
    public MeterReading[] MeterReadings => GetAssoc1ToM<MeterReading>(nameof(MeterReadings));

    public void AddToMeterReadings(MeterReading assocObject) => AddAssoc1ToM(nameof(MeterReadings), assocObject);

    public void RemoveFromMeterReadings(MeterReading assocObject) =>
        RemoveAssoc1ToM(nameof(MeterReadings), assocObject);

    public void RemoveAllFromMeterReadings() => RemoveAllAssocs1ToM(nameof(MeterReadings));

    /// <summary>
    /// Метрологические требования для точки поставки.
    /// </summary>
    public MetrologyRequirement[] MetrologyRequirements =>
        GetAssoc1ToM<MetrologyRequirement>(nameof(MetrologyRequirements));

    public void AddToMetrologyRequirements(MetrologyRequirement assocObject) =>
        AddAssoc1ToM(nameof(MetrologyRequirements), assocObject);

    public void RemoveFromMetrologyRequirements(MetrologyRequirement assocObject) =>
        RemoveAssoc1ToM(nameof(MetrologyRequirements), assocObject);

    public void RemoveAllFromMetrologyRequirements() => RemoveAllAssocs1ToM(nameof(MetrologyRequirements));

    /// <summary>
    /// Коэффициенты точки поставки.
    /// </summary>
    public ServiceMultiplier[] ServiceMultipliers => GetAssoc1ToM<ServiceMultiplier>(nameof(ServiceMultipliers));

    public void AddToServiceMultipliers(ServiceMultiplier assocObject) =>
        AddAssoc1ToM(nameof(ServiceMultipliers), assocObject);

    public void RemoveFromServiceMultipliers(ServiceMultiplier assocObject) =>
        RemoveAssoc1ToM(nameof(ServiceMultipliers), assocObject);

    public void RemoveAllFromServiceMultipliers() => RemoveAllAssocs1ToM(nameof(ServiceMultipliers));

    /// <summary>
    /// Ценовые структуры, применимые к точке поставки (с прибором учета предоплаты, работающим как автономное устройство, без CustomerAgreement или клиента).
    /// </summary>
    public PricingStructure[] PricingStructures => GetAssoc1ToM<PricingStructure>(nameof(PricingStructures));

    public void AddToPricingStructures(PricingStructure assocObject) =>
        AddAssoc1ToM(nameof(PricingStructures), assocObject);

    public void RemoveFromPricingStructures(PricingStructure assocObject) =>
        RemoveAssoc1ToM(nameof(PricingStructures), assocObject);

    public void RemoveAllFromPricingStructures() => RemoveAllAssocs1ToM(nameof(PricingStructures));

    /// <summary>
    /// События конфигурирования точки поставки.
    /// </summary>
    public ConfigurationEvent[] ConfigurationEvents => GetAssoc1ToM<ConfigurationEvent>(nameof(ConfigurationEvents));

    public void AddToConfigurationEvents(ConfigurationEvent assocObject) =>
        AddAssoc1ToM(nameof(ConfigurationEvents), assocObject);

    public void RemoveFromConfigurationEvents(ConfigurationEvent assocObject) =>
        RemoveAssoc1ToM(nameof(ConfigurationEvents), assocObject);

    public void RemoveAllFromConfigurationEvents() => RemoveAllAssocs1ToM(nameof(ConfigurationEvents));

    /// <summary>
    /// Оборудование, к которому относится точка учета.
    /// </summary>
    public Equipment[] Equipments => GetAssoc1ToM<Equipment>(nameof(Equipments));

    public void AddToEquipments(Equipment assocObject) => AddAssoc1ToM(nameof(Equipments), assocObject);
    public void RemoveFromEquipments(Equipment assocObject) => RemoveAssoc1ToM(nameof(Equipments), assocObject);
    public void RemoveAllFromEquipments() => RemoveAllAssocs1ToM(nameof(Equipments));
}