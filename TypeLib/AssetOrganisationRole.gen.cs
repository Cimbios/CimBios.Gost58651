using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Базовый класс для обозначения ролей организаций в отношении материальных объектов.
/// </summary>
[CimClass(ClassUri)]
public partial class AssetOrganisationRole(IOIDDescriptor oid, ICimMetaClass metaClass)
    : OrganisationRole(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#AssetOrganisationRole";


    /// <summary>
    /// Материальные объекты с определенной  организационной ролью.
    /// </summary>
    public Asset[] Assets => GetAssoc1ToM<Asset>(nameof(Assets));

    public void AddToAssets(Asset assocObject) => AddAssoc1ToM(nameof(Assets), assocObject);
    public void RemoveFromAssets(Asset assocObject) => RemoveAssoc1ToM(nameof(Assets), assocObject);
    public void RemoveAllFromAssets() => RemoveAllAssocs1ToM(nameof(Assets));
}