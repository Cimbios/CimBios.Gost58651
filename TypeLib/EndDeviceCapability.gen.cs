using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Возможности, присущие конечному устройству (т.е. функции, которые оно поддерживает).
/// </summary>
[CimClass(ClassUri)]
public partial class EndDeviceCapability(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#EndDeviceCapability";

    /// <summary>
    /// TRUE, если поддерживается автономная функция DST (летнее время).
    /// </summary>
    public bool? autonomousDst
    {
        get => GetAttribute<bool?>(nameof(autonomousDst));
        set => SetAttribute(nameof(autonomousDst), value);
    }

    /// <summary>
    /// TRUE, если поддерживается функция связи.
    /// </summary>
    public bool? communication
    {
        get => GetAttribute<bool?>(nameof(communication));
        set => SetAttribute(nameof(communication), value);
    }

    /// <summary>
    /// TRUE, если поддерживается функция подключения и отключения.
    /// </summary>
    public bool? connectDisconnect
    {
        get => GetAttribute<bool?>(nameof(connectDisconnect));
        set => SetAttribute(nameof(connectDisconnect), value);
    }

    /// <summary>
    /// TRUE, если поддерживается функция сброса.
    /// </summary>
    public bool? demandResponse
    {
        get => GetAttribute<bool?>(nameof(demandResponse));
        set => SetAttribute(nameof(demandResponse), value);
    }

    /// <summary>
    /// TRUE, если поддерживается функция учета электрической энергии.
    /// </summary>
    public bool? electricMetering
    {
        get => GetAttribute<bool?>(nameof(electricMetering));
        set => SetAttribute(nameof(electricMetering), value);
    }

    /// <summary>
    /// TRUE, если поддерживается функция учета газа.
    /// </summary>
    public bool? gasMetering
    {
        get => GetAttribute<bool?>(nameof(gasMetering));
        set => SetAttribute(nameof(gasMetering), value);
    }

    /// <summary>
    /// TRUE, если поддерживается функция метрологии.
    /// </summary>
    public bool? metrology
    {
        get => GetAttribute<bool?>(nameof(metrology));
        set => SetAttribute(nameof(metrology), value);
    }

    /// <summary>
    /// TRUE, если по запросу поддерживается функция чтения.
    /// </summary>
    public bool? onRequestRead
    {
        get => GetAttribute<bool?>(nameof(onRequestRead));
        set => SetAttribute(nameof(onRequestRead), value);
    }

    /// <summary>
    /// TRUE, если поддерживается функция истории отключений.
    /// </summary>
    public bool? outageHistory
    {
        get => GetAttribute<bool?>(nameof(outageHistory));
        set => SetAttribute(nameof(outageHistory), value);
    }

    /// <summary>
    /// TRUE, если устройство выполняет компенсацию давления для дозированных величин.
    /// </summary>
    public bool? pressureCompensation
    {
        get => GetAttribute<bool?>(nameof(pressureCompensation));
        set => SetAttribute(nameof(pressureCompensation), value);
    }

    /// <summary>
    /// TRUE, если поддерживается информация о ценах.
    /// </summary>
    public bool? pricingInfo
    {
        get => GetAttribute<bool?>(nameof(pricingInfo));
        set => SetAttribute(nameof(pricingInfo), value);
    }

    /// <summary>
    /// TRUE, если устройство выдает импульсные выходы.
    /// </summary>
    public bool? pulseOutput
    {
        get => GetAttribute<bool?>(nameof(pulseOutput));
        set => SetAttribute(nameof(pulseOutput), value);
    }

    /// <summary>
    /// TRUE, если поддерживается функция программирования реле.
    /// </summary>
    public bool? relaysProgramming
    {
        get => GetAttribute<bool?>(nameof(relaysProgramming));
        set => SetAttribute(nameof(relaysProgramming), value);
    }

    /// <summary>
    /// TRUE, если поддерживается функция обратного направления.
    /// </summary>
    public bool? reverseFlow
    {
        get => GetAttribute<bool?>(nameof(reverseFlow));
        set => SetAttribute(nameof(reverseFlow), value);
    }

    /// <summary>
    /// TRUE, если устройство выполняет суперкомпенсацию сжимаемости для измеренных величин.
    /// </summary>
    public bool? superCompressibilityCompensation
    {
        get => GetAttribute<bool?>(nameof(superCompressibilityCompensation));
        set => SetAttribute(nameof(superCompressibilityCompensation), value);
    }

    /// <summary>
    /// TRUE, если устройство выполняет температурную компенсацию измеренных величин.
    /// </summary>
    public bool? temperatureCompensation
    {
        get => GetAttribute<bool?>(nameof(temperatureCompensation));
        set => SetAttribute(nameof(temperatureCompensation), value);
    }

    /// <summary>
    /// TRUE, если поддерживается отображение текстовых сообщений.
    /// </summary>
    public bool? textMessage
    {
        get => GetAttribute<bool?>(nameof(textMessage));
        set => SetAttribute(nameof(textMessage), value);
    }

    /// <summary>
    /// TRUE, если поддерживается функция учета воды.
    /// </summary>
    public bool? waterMetering
    {
        get => GetAttribute<bool?>(nameof(waterMetering));
        set => SetAttribute(nameof(waterMetering), value);
    }
}