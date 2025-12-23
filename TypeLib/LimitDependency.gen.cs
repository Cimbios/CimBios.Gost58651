using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Базовый класс зависимостей эксплуатационныхограничений/пределов.
/// </summary>
[CimClass(ClassUri)]
public partial class LimitDependency(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#LimitDependency";


    /// <summary>
    /// Оборудование, к которому относится зависимость эксплуатационных  ограничений/пределов.
    /// </summary>
    public Equipment? Equipment
    {
        get => GetAssoc1To1<Equipment>(nameof(Equipment));
        set => SetAssoc1To1(nameof(Equipment), value);
    }

    /// <summary>
    /// Исходное эксплуатационное ограничение/предел, от которого зависят другие эксплуатационные ограничения/пределы.
    /// </summary>
    public OperationalLimit[] OperationalLimit => GetAssoc1ToM<OperationalLimit>(nameof(OperationalLimit));

    public void AddToOperationalLimit(OperationalLimit assocObject) =>
        AddAssoc1ToM(nameof(OperationalLimit), assocObject);

    public void RemoveFromOperationalLimit(OperationalLimit assocObject) =>
        RemoveAssoc1ToM(nameof(OperationalLimit), assocObject);

    public void RemoveAllFromOperationalLimit() => RemoveAllAssocs1ToM(nameof(OperationalLimit));
}