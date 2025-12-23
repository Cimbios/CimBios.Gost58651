using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Обобщенный объект энергосистемы.
/// </summary>
[CimClass(ClassUri)]
public partial class PowerSystemResource(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PowerSystemResource";


    /// <summary>
    /// Дополнительный классификатор
    /// </summary>
    public PSRType? PSRType
    {
        get => GetAssoc1To1<PSRType>(nameof(PSRType));
        set => SetAssoc1To1(nameof(PSRType), value);
    }

    /// <summary>
    /// Расположение объекта энергосистемы.
    /// </summary>
    public Location? Location
    {
        get => GetAssoc1To1<Location>(nameof(Location));
        set => SetAssoc1To1(nameof(Location), value);
    }

    /// <summary>
    /// Информация о материальном объекте для соответствующего объекта, потомка обощенного объекта энергосистемы.
    /// </summary>
    public AssetInfo? AssetDatasheet
    {
        get => GetAssoc1To1<AssetInfo>(nameof(AssetDatasheet));
        set => SetAssoc1To1(nameof(AssetDatasheet), value);
    }

    /// <summary>
    /// Параметры измерений, которые относятся к обобщенному объекту энергосистемы.
    /// </summary>
    public Measurement[] Measurements => GetAssoc1ToM<Measurement>(nameof(Measurements));

    public void AddToMeasurements(Measurement assocObject) => AddAssoc1ToM(nameof(Measurements), assocObject);
    public void RemoveFromMeasurements(Measurement assocObject) => RemoveAssoc1ToM(nameof(Measurements), assocObject);
    public void RemoveAllFromMeasurements() => RemoveAllAssocs1ToM(nameof(Measurements));

    /// <summary>
    /// Материальные объекты, ассоциированные с объектом энергосистемы.
    /// </summary>
    public Asset[] Assets => GetAssoc1ToM<Asset>(nameof(Assets));

    public void AddToAssets(Asset assocObject) => AddAssoc1ToM(nameof(Assets), assocObject);
    public void RemoveFromAssets(Asset assocObject) => RemoveAssoc1ToM(nameof(Assets), assocObject);
    public void RemoveAllFromAssets() => RemoveAllAssocs1ToM(nameof(Assets));
}