using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Контейнер материальных объектов, выполняющий одну или несколько функций оконечного устройства и имеющий возможность обмена данными.
/// </summary>
[CimClass(ClassUri)]
public partial class EndDevice(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AssetContainer(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#EndDevice";

    /// <summary>
    /// Установочный код устройства.
    /// </summary>
    public string? installCode
    {
        get => GetAttribute<string?>(nameof(installCode));
        set => SetAttribute(nameof(installCode), value);
    }

    /// <summary>
    /// Если TRUE, то сетевое устройство.
    /// </summary>
    public bool? isPan
    {
        get => GetAttribute<bool?>(nameof(isPan));
        set => SetAttribute(nameof(isPan), value);
    }

    /// <summary>
    /// Если TRUE, то физического устройства не существует. Например, виртуальный прибор учета может быть определен для агрегирования потребления для двух или более физических приборов учета. В противном случае это физическое аппаратное устройство.
    /// </summary>
    public bool? isVirtual
    {
        get => GetAttribute<bool?>(nameof(isVirtual));
        set => SetAttribute(nameof(isVirtual), value);
    }

    /// <summary>
    /// Смещение часового пояса относительно GMT для местоположения этого устройства в минутах.
    /// </summary>
    public float? timeZoneOffset
    {
        get => GetAttribute<float?>(nameof(timeZoneOffset));
        set => SetAttribute(nameof(timeZoneOffset), value);
    }

    /// <summary>
    /// Данные конечного устройства.
    /// </summary>
    public EndDeviceInfo? EndDeviceInfo
    {
        get => GetAssoc1To1<EndDeviceInfo>(nameof(EndDeviceInfo));
        set => SetAssoc1To1(nameof(EndDeviceInfo), value);
    }

    /// <summary>
    /// Точка поставки, к которой относится это конечное устройство.
    /// </summary>
    public UsagePoint? UsagePoint
    {
        get => GetAssoc1To1<UsagePoint>(nameof(UsagePoint));
        set => SetAssoc1To1(nameof(UsagePoint), value);
    }

    /// <summary>
    /// Клиент, владеющий этим конечным устройством.
    /// </summary>
    public Customer? Customer
    {
        get => GetAssoc1To1<Customer>(nameof(Customer));
        set => SetAssoc1To1(nameof(Customer), value);
    }

    /// <summary>
    /// Функции конечного устройства, которыевыполняет конечное устройство.
    /// </summary>
    public EndDeviceFunction[] EndDeviceFunctions => GetAssoc1ToM<EndDeviceFunction>(nameof(EndDeviceFunctions));

    public void AddToEndDeviceFunctions(EndDeviceFunction assocObject) =>
        AddAssoc1ToM(nameof(EndDeviceFunctions), assocObject);

    public void RemoveFromEndDeviceFunctions(EndDeviceFunction assocObject) =>
        RemoveAssoc1ToM(nameof(EndDeviceFunctions), assocObject);

    public void RemoveAllFromEndDeviceFunctions() => RemoveAllAssocs1ToM(nameof(EndDeviceFunctions));

    /// <summary>
    /// Элементы управления конечными устройствами, отправляющие команды на это конечное устройство.
    /// </summary>
    public EndDeviceControl[] EndDeviceControls => GetAssoc1ToM<EndDeviceControl>(nameof(EndDeviceControls));

    public void AddToEndDeviceControls(EndDeviceControl assocObject) =>
        AddAssoc1ToM(nameof(EndDeviceControls), assocObject);

    public void RemoveFromEndDeviceControls(EndDeviceControl assocObject) =>
        RemoveAssoc1ToM(nameof(EndDeviceControls), assocObject);

    public void RemoveAllFromEndDeviceControls() => RemoveAllAssocs1ToM(nameof(EndDeviceControls));
}