using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Качество значения показания или интервального значения показания.
/// </summary>
[CimClass(ClassUri)]
public partial class ReadingQuality(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ReadingQuality";

    /// <summary>
    /// Комментарий к коду качества.
    /// </summary>
    public string? comment
    {
        get => GetAttribute<string?>(nameof(comment));
        set => SetAttribute(nameof(comment), value);
    }

    /// <summary>
    /// Система, выступающая в качестве источника кода качества.
    /// </summary>
    public string? source
    {
        get => GetAttribute<string?>(nameof(source));
        set => SetAttribute(nameof(source), value);
    }

    /// <summary>
    /// Дата и время присвоения или установления кода качества [Дата и время].
    /// </summary>
    public DateTime? timeStamp
    {
        get => GetAttribute<DateTime?>(nameof(timeStamp));
        set => SetAttribute(nameof(timeStamp), value);
    }

    /// <summary>
    /// Показание, обладающее этим качеством.
    /// </summary>
    public BaseReading? Reading
    {
        get => GetAssoc1To1<BaseReading>(nameof(Reading));
        set => SetAssoc1To1(nameof(Reading), value);
    }

    /// <summary>
    /// Тип качества.
    /// </summary>
    public ReadingQualityType? ReadingQualityType
    {
        get => GetAssoc1To1<ReadingQualityType>(nameof(ReadingQualityType));
        set => SetAssoc1To1(nameof(ReadingQualityType), value);
    }
}