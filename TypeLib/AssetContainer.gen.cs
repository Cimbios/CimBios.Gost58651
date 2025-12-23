using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Материальный объект, который состоит из других материальных объектов.
/// </summary>
[CimClass(ClassUri)]
public partial class AssetContainer(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Asset(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#AssetContainer";


    /// <summary>
    /// Материальные объекты, которые входят в состав текущего материального объекта.
    /// </summary>
    public Asset[] Assets => GetAssoc1ToM<Asset>(nameof(Assets));

    public void AddToAssets(Asset assocObject) => AddAssoc1ToM(nameof(Assets), assocObject);
    public void RemoveFromAssets(Asset assocObject) => RemoveAssoc1ToM(nameof(Assets), assocObject);
    public void RemoveAllFromAssets() => RemoveAllAssocs1ToM(nameof(Assets));

    /// <summary>
    /// Пломбы, применяемые к контейнеру материальных объектов.
    /// </summary>
    public Seal[] Seals => GetAssoc1ToM<Seal>(nameof(Seals));

    public void AddToSeals(Seal assocObject) => AddAssoc1ToM(nameof(Seals), assocObject);
    public void RemoveFromSeals(Seal assocObject) => RemoveAssoc1ToM(nameof(Seals), assocObject);
    public void RemoveAllFromSeals() => RemoveAllAssocs1ToM(nameof(Seals));
}