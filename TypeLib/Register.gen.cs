using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Устройство, которое указывает или записывает единицы измерения товара или другой измеряемой величины.
/// </summary>
[CimClass(ClassUri)]
public partial class Register(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Register";

    /// <summary>
    /// Если TRUE, то данные вычисляют или измеряют устройством, отличным от физического конечного устройства/прибора учета.
    /// </summary>
    public bool? isVirtual
    {
        get => GetAttribute<bool?>(nameof(isVirtual));
        set => SetAttribute(nameof(isVirtual), value);
    }

    /// <summary>
    /// Количество цифр (циферблатов на механическом приборе учета) слева от десятичного знака; по умолчанию, как правило, 5.
    /// </summary>
    public int? leftDigitCount
    {
        get => GetAttribute<int?>(nameof(leftDigitCount));
        set => SetAttribute(nameof(leftDigitCount), value);
    }

    /// <summary>
    /// Количество цифр (циферблатов на механическом приборе учета) справа от десятичного знака.
    /// </summary>
    public int? rightDigitCount
    {
        get => GetAttribute<int?>(nameof(rightDigitCount));
        set => SetAttribute(nameof(rightDigitCount), value);
    }

    /// <summary>
    /// Интервал времени, в течение которого регистр начинает/прекращает накопление TOU (например, начало в 8:00, остановка в 17:00).
    /// </summary>
    public TimeInterval? touTier
    {
        get => GetAttribute<TimeInterval?>(nameof(touTier));
        set => SetAttribute(nameof(touTier), value);
    }

    /// <summary>
    /// Имя, используемое для TOU. Например, &#171;пиковый&#187;, &#171;непиковый&#187;, &#171;TOU категории А&#187; и т. д.
    /// </summary>
    public string? touTierName
    {
        get => GetAttribute<string?>(nameof(touTierName));
        set => SetAttribute(nameof(touTierName), value);
    }

    /// <summary>
    /// Функция конечного устройства, связанная с этим записывающим устройством.
    /// </summary>
    public EndDeviceFunction? EndDeviceFunction
    {
        get => GetAssoc1To1<EndDeviceFunction>(nameof(EndDeviceFunction));
        set => SetAssoc1To1(nameof(EndDeviceFunction), value);
    }

    /// <summary>
    /// Каналы, которые собирают/сообщают значения регистра.
    /// </summary>
    public Channel[] Channels => GetAssoc1ToM<Channel>(nameof(Channels));

    public void AddToChannels(Channel assocObject) => AddAssoc1ToM(nameof(Channels), assocObject);
    public void RemoveFromChannels(Channel assocObject) => RemoveAssoc1ToM(nameof(Channels), assocObject);
    public void RemoveAllFromChannels() => RemoveAllAssocs1ToM(nameof(Channels));
}