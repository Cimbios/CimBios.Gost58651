using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Расположение материальных объектов и энергообъектов.
/// </summary>
[CimClass(ClassUri)]
public partial class Location(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Location";

    /// <summary>
    /// Направление, позволяющее полевым бригадам быстро найти данный объект.
    /// </summary>
    public string? direction
    {
        get => GetAttribute<string?>(nameof(direction));
        set => SetAttribute(nameof(direction), value);
    }

    /// <summary>
    /// Электронный адрес.
    /// </summary>
    public ElectronicAddress? electronicAddress
    {
        get => GetAttribute<ElectronicAddress?>(nameof(electronicAddress));
        set => SetAttribute(nameof(electronicAddress), value);
    }

    /// <summary>
    /// Ссылка на географический источник информации, часто не относящийся к объекту.
    /// </summary>
    public string? geoInfoReference
    {
        get => GetAttribute<string?>(nameof(geoInfoReference));
        set => SetAttribute(nameof(geoInfoReference), value);
    }

    /// <summary>
    /// Основной адрес.
    /// </summary>
    public StreetAddress? mainAddress
    {
        get => GetAttribute<StreetAddress?>(nameof(mainAddress));
        set => SetAttribute(nameof(mainAddress), value);
    }

    /// <summary>
    /// Номер телефона.
    /// </summary>
    public TelephoneNumber? phone1
    {
        get => GetAttribute<TelephoneNumber?>(nameof(phone1));
        set => SetAttribute(nameof(phone1), value);
    }

    /// <summary>
    /// Дополнительный номер телефона.
    /// </summary>
    public TelephoneNumber? phone2
    {
        get => GetAttribute<TelephoneNumber?>(nameof(phone2));
        set => SetAttribute(nameof(phone2), value);
    }

    /// <summary>
    /// Дополнительный адрес.
    /// </summary>
    public StreetAddress? secondaryAddress
    {
        get => GetAttribute<StreetAddress?>(nameof(secondaryAddress));
        set => SetAttribute(nameof(secondaryAddress), value);
    }

    /// <summary>
    /// Статус.
    /// </summary>
    public Status? status
    {
        get => GetAttribute<Status?>(nameof(status));
        set => SetAttribute(nameof(status), value);
    }

    /// <summary>
    /// Классификация по корпоративным стандартам и практикам предприятия.
    /// </summary>
    public string? type
    {
        get => GetAttribute<string?>(nameof(type));
        set => SetAttribute(nameof(type), value);
    }

    /// <summary>
    /// Система координат, используемая для описания местоположения.
    /// </summary>
    public CoordinateSystem? CoordinateSystem
    {
        get => GetAssoc1To1<CoordinateSystem>(nameof(CoordinateSystem));
        set => SetAssoc1To1(nameof(CoordinateSystem), value);
    }

    /// <summary>
    /// События конфигурирования местоположения.
    /// </summary>
    public ConfigurationEvent[] ConfigurationEvents => GetAssoc1ToM<ConfigurationEvent>(nameof(ConfigurationEvents));

    public void AddToConfigurationEvents(ConfigurationEvent assocObject) =>
        AddAssoc1ToM(nameof(ConfigurationEvents), assocObject);

    public void RemoveFromConfigurationEvents(ConfigurationEvent assocObject) =>
        RemoveAssoc1ToM(nameof(ConfigurationEvents), assocObject);

    public void RemoveAllFromConfigurationEvents() => RemoveAllAssocs1ToM(nameof(ConfigurationEvents));

    /// <summary>
    /// Последовательность расположения координатных точек, описывающих это местоположение, выраженная в системе координат.
    /// </summary>
    public PositionPoint[] PositionPoints => GetAssoc1ToM<PositionPoint>(nameof(PositionPoints));

    public void AddToPositionPoints(PositionPoint assocObject) => AddAssoc1ToM(nameof(PositionPoints), assocObject);

    public void RemoveFromPositionPoints(PositionPoint assocObject) =>
        RemoveAssoc1ToM(nameof(PositionPoints), assocObject);

    public void RemoveAllFromPositionPoints() => RemoveAllAssocs1ToM(nameof(PositionPoints));

    /// <summary>
    /// Материальные объекты в данном расположении.
    /// </summary>
    public Asset[] Assets => GetAssoc1ToM<Asset>(nameof(Assets));

    public void AddToAssets(Asset assocObject) => AddAssoc1ToM(nameof(Assets), assocObject);
    public void RemoveFromAssets(Asset assocObject) => RemoveAssoc1ToM(nameof(Assets), assocObject);
    public void RemoveAllFromAssets() => RemoveAllAssocs1ToM(nameof(Assets));

    /// <summary>
    /// Объекты энергосистемы в данном расположении.
    /// </summary>
    public PowerSystemResource[] PowerSystemResources =>
        GetAssoc1ToM<PowerSystemResource>(nameof(PowerSystemResources));

    public void AddToPowerSystemResources(PowerSystemResource assocObject) =>
        AddAssoc1ToM(nameof(PowerSystemResources), assocObject);

    public void RemoveFromPowerSystemResources(PowerSystemResource assocObject) =>
        RemoveAssoc1ToM(nameof(PowerSystemResources), assocObject);

    public void RemoveAllFromPowerSystemResources() => RemoveAllAssocs1ToM(nameof(PowerSystemResources));
}