using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Подробная информация о функции удаленного подключения и отключения.
/// </summary>
[CimClass(ClassUri)]
public partial class RemoteConnectDisconnectInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#RemoteConnectDisconnectInfo";

    /// <summary>
    /// Настройка тайм-аута истекшего времени.
    /// </summary>
    public float? armedTimeout
    {
        get => GetAttribute<float?>(nameof(armedTimeout));
        set => SetAttribute(nameof(armedTimeout), value);
    }

    /// <summary>
    /// Предел напряжения на стороне потребителя выключателя, выше которого подключение не должно выполняться.
    /// </summary>
    public float? customerVoltageLimit
    {
        get => GetAttribute<float?>(nameof(customerVoltageLimit));
        set => SetAttribute(nameof(customerVoltageLimit), value);
    }

    /// <summary>
    /// Лимит энергии перед отключением.
    /// </summary>
    public float? energyLimit
    {
        get => GetAttribute<float?>(nameof(energyLimit));
        set => SetAttribute(nameof(energyLimit), value);
    }

    /// <summary>
    /// Дата начала и время накопления энергии для ограничения энергопотребления.
    /// </summary>
    public DateTime? energyUsageStartDateTime
    {
        get => GetAttribute<DateTime?>(nameof(energyUsageStartDateTime));
        set => SetAttribute(nameof(energyUsageStartDateTime), value);
    }

    /// <summary>
    /// Предупреждение об ограничении энергии, используемое для запуска кода события, что потребление энергии приближается к пределу.
    /// </summary>
    public float? energyUsageWarning
    {
        get => GetAttribute<float?>(nameof(energyUsageWarning));
        set => SetAttribute(nameof(energyUsageWarning), value);
    }

    /// <summary>
    /// TRUE, если переключатель должен быть включен до начала действия подключения.
    /// </summary>
    public bool? isArmConnect
    {
        get => GetAttribute<bool?>(nameof(isArmConnect));
        set => SetAttribute(nameof(isArmConnect), value);
    }

    /// <summary>
    /// TRUE, если переключатель должен быть включен до начала действия отключения.
    /// </summary>
    public bool? isArmDisconnect
    {
        get => GetAttribute<bool?>(nameof(isArmDisconnect));
        set => SetAttribute(nameof(isArmDisconnect), value);
    }

    /// <summary>
    /// TRUE, если потребление энергии ограничено, и клиент будет отключен, если он превысит лимит.
    /// </summary>
    public bool? isEnergyLimiting
    {
        get => GetAttribute<bool?>(nameof(isEnergyLimiting));
        set => SetAttribute(nameof(isEnergyLimiting), value);
    }

    /// <summary>
    /// TRUE, если необходимо проверить предел нагрузки для немедленного отключения (после подключения), если нагрузка превышает предел.
    /// </summary>
    public bool? needsPowerLimitCheck
    {
        get => GetAttribute<bool?>(nameof(needsPowerLimitCheck));
        set => SetAttribute(nameof(needsPowerLimitCheck), value);
    }

    /// <summary>
    /// TRUE, если предел напряжения должен быть проверен, чтобы предотвратить подключение, если напряжение превышает предел.
    /// </summary>
    public bool? needsVoltageLimitCheck
    {
        get => GetAttribute<bool?>(nameof(needsVoltageLimitCheck));
        set => SetAttribute(nameof(needsVoltageLimitCheck), value);
    }

    /// <summary>
    /// Лимит мощности, выше которого подключение либо не должно происходить, либо должно привести к немедленному отключению.
    /// </summary>
    public float? powerLimit
    {
        get => GetAttribute<float?>(nameof(powerLimit));
        set => SetAttribute(nameof(powerLimit), value);
    }

    /// <summary>
    /// TRUE, если для подключения необходимо использовать кнопку.
    /// </summary>
    public bool? usePushbutton
    {
        get => GetAttribute<bool?>(nameof(usePushbutton));
        set => SetAttribute(nameof(usePushbutton), value);
    }
}