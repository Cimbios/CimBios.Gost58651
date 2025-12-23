using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Базовый класс описания технических параметров оборудования различного вида.
/// </summary>
[CimClass(ClassUri)]
public partial class AssetInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#AssetInfo";


    /// <summary>
    /// Модель оборудования, к которой относится описание.
    /// </summary>
    public ProductAssetModel? ProductAssetModel
    {
        get => GetAssoc1To1<ProductAssetModel>(nameof(ProductAssetModel));
        set => SetAssoc1To1(nameof(ProductAssetModel), value);
    }

    /// <summary>
    /// Материальные объекты, к которым относится техническая информация.
    /// </summary>
    public Asset[] Assets => GetAssoc1ToM<Asset>(nameof(Assets));

    public void AddToAssets(Asset assocObject) => AddAssoc1ToM(nameof(Assets), assocObject);
    public void RemoveFromAssets(Asset assocObject) => RemoveAssoc1ToM(nameof(Assets), assocObject);
    public void RemoveAllFromAssets() => RemoveAllAssocs1ToM(nameof(Assets));

    /// <summary>
    /// Техническая информация об обобщенном объекте энергосистемы.
    /// </summary>
    public PowerSystemResource[] PowerSystemResources =>
        GetAssoc1ToM<PowerSystemResource>(nameof(PowerSystemResources));

    public void AddToPowerSystemResources(PowerSystemResource assocObject) =>
        AddAssoc1ToM(nameof(PowerSystemResources), assocObject);

    public void RemoveFromPowerSystemResources(PowerSystemResource assocObject) =>
        RemoveAssoc1ToM(nameof(PowerSystemResources), assocObject);

    public void RemoveAllFromPowerSystemResources() => RemoveAllAssocs1ToM(nameof(PowerSystemResources));
}