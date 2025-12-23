using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Таблица зависимости эксплуатационных ограничений/пределов от температуры.
/// </summary>
[CimClass(ClassUri)]
public partial class TemperatureDependentLimitTable(IOIDDescriptor oid, ICimMetaClass metaClass)
    : EnvironmentalDependentLimit(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#TemperatureDependentLimitTable";


    /// <summary>
    /// Строка таблицы зависимости эксплуатационных ограничений/пределов от температуры.
    /// </summary>
    public TemperatureDependentLimitPoint[] TemperatureLimitTablePoint =>
        GetAssoc1ToM<TemperatureDependentLimitPoint>(nameof(TemperatureLimitTablePoint));

    public void AddToTemperatureLimitTablePoint(TemperatureDependentLimitPoint assocObject) =>
        AddAssoc1ToM(nameof(TemperatureLimitTablePoint), assocObject);

    public void RemoveFromTemperatureLimitTablePoint(TemperatureDependentLimitPoint assocObject) =>
        RemoveAssoc1ToM(nameof(TemperatureLimitTablePoint), assocObject);

    public void RemoveAllFromTemperatureLimitTablePoint() => RemoveAllAssocs1ToM(nameof(TemperatureLimitTablePoint));
}