using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Подробное описание качества значения показания, производимого конечным устройством или системой.
/// </summary>
[CimClass(ClassUri)]
public partial class ReadingQualityType(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ReadingQualityType";

    /// <summary>
    /// Высокоуровневая предметная область качества значения показания.
    /// </summary>
    public string? category
    {
        get => GetAttribute<string?>(nameof(category));
        set => SetAttribute(nameof(category), value);
    }

    /// <summary>
    /// Более специфическая предметная область качества значения показания, как подвариант category.
    /// </summary>
    public string? subCategory
    {
        get => GetAttribute<string?>(nameof(subCategory));
        set => SetAttribute(nameof(subCategory), value);
    }

    /// <summary>
    /// Идентификатор системы, заявившей о проблеме с данными или предоставившей комментарий к этим данным.
    /// </summary>
    public string? systemId
    {
        get => GetAttribute<string?>(nameof(systemId));
        set => SetAttribute(nameof(systemId), value);
    }


    /// <summary>
    /// Качества показаний этого типа.
    /// </summary>
    public ReadingQuality[] ReadingQualities => GetAssoc1ToM<ReadingQuality>(nameof(ReadingQualities));

    public void AddToReadingQualities(ReadingQuality assocObject) =>
        AddAssoc1ToM(nameof(ReadingQualities), assocObject);

    public void RemoveFromReadingQualities(ReadingQuality assocObject) =>
        RemoveAssoc1ToM(nameof(ReadingQualities), assocObject);

    public void RemoveAllFromReadingQualities() => RemoveAllAssocs1ToM(nameof(ReadingQualities));
}