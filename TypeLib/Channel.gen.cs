using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Единый путь для сбора или представления значений регистра в течение определенного периода времени.
/// </summary>
[CimClass(ClassUri)]
public partial class Channel(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Channel";

    /// <summary>
    /// Если TRUE, то данные рассчитываются корпоративной системой, а не измеряются напрямую.
    /// </summary>
    public bool? isVirtual
    {
        get => GetAttribute<bool?>(nameof(isVirtual));
        set => SetAttribute(nameof(isVirtual), value);
    }

    /// <summary>
    /// Тип показания значений регистра, сообщаемых/собираемых каналом.
    /// </summary>
    public ReadingType? ReadingType
    {
        get => GetAssoc1To1<ReadingType>(nameof(ReadingType));
        set => SetAssoc1To1(nameof(ReadingType), value);
    }

    /// <summary>
    /// Записывающее устройство, передающее значения по этому каналу.
    /// </summary>
    public Register? Register
    {
        get => GetAssoc1To1<Register>(nameof(Register));
        set => SetAssoc1To1(nameof(Register), value);
    }
}