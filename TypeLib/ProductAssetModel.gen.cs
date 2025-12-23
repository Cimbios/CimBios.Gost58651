using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Модель оборудования определенного производителя.
/// </summary>
[CimClass(ClassUri)]
public partial class ProductAssetModel(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ProductAssetModel";

    /// <summary>
    /// Вид корпоративного стандарта модели материального объекта.
    /// </summary>
    public CorporateStandardKind? corporateStandardKind
    {
        get => GetAttribute<CorporateStandardKind?>(nameof(corporateStandardKind));
        set => SetAttribute(nameof(corporateStandardKind), value);
    }

    /// <summary>
    /// Номер модели производителя.
    /// </summary>
    public string? modelNumber
    {
        get => GetAttribute<string?>(nameof(modelNumber));
        set => SetAttribute(nameof(modelNumber), value);
    }

    /// <summary>
    /// Номер версии модели продукта, указывающий на год выпуска продукта.
    /// </summary>
    public string? modelVersion
    {
        get => GetAttribute<string?>(nameof(modelVersion));
        set => SetAttribute(nameof(modelVersion), value);
    }

    /// <summary>
    /// Предполагаемое использование для модели материального объекта.
    /// </summary>
    public AssetModelUsageKind? usageKind
    {
        get => GetAttribute<AssetModelUsageKind?>(nameof(usageKind));
        set => SetAttribute(nameof(usageKind), value);
    }

    /// <summary>
    /// Технические параметры модели оборудования.
    /// </summary>
    public AssetInfo? AssetInfo
    {
        get => GetAssoc1To1<AssetInfo>(nameof(AssetInfo));
        set => SetAssoc1To1(nameof(AssetInfo), value);
    }

    /// <summary>
    /// Производитель определенной модели оборудования.
    /// </summary>
    public Manufacturer? Manufacturer
    {
        get => GetAssoc1To1<Manufacturer>(nameof(Manufacturer));
        set => SetAssoc1To1(nameof(Manufacturer), value);
    }

    /// <summary>
    /// Материальные объекты, соответствующие определенной модели оборудования.
    /// </summary>
    public Asset[] Asset => GetAssoc1ToM<Asset>(nameof(Asset));

    public void AddToAsset(Asset assocObject) => AddAssoc1ToM(nameof(Asset), assocObject);
    public void RemoveFromAsset(Asset assocObject) => RemoveAssoc1ToM(nameof(Asset), assocObject);
    public void RemoveAllFromAsset() => RemoveAllAssocs1ToM(nameof(Asset));
}