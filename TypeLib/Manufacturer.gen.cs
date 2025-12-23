using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Организация-производитель определенного типа оборудования.
/// </summary>
[CimClass(ClassUri)]
public partial class Manufacturer(IOIDDescriptor oid, ICimMetaClass metaClass)
    : OrganisationRole(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Manufacturer";


    /// <summary>
    /// Модели оборудования определенного производителя.
    /// </summary>
    public ProductAssetModel[] ProductAssetModel => GetAssoc1ToM<ProductAssetModel>(nameof(ProductAssetModel));

    public void AddToProductAssetModel(ProductAssetModel assocObject) =>
        AddAssoc1ToM(nameof(ProductAssetModel), assocObject);

    public void RemoveFromProductAssetModel(ProductAssetModel assocObject) =>
        RemoveAssoc1ToM(nameof(ProductAssetModel), assocObject);

    public void RemoveAllFromProductAssetModel() => RemoveAllAssocs1ToM(nameof(ProductAssetModel));
}