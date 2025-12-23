using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Полюс постоянного и переменного тока.
/// </summary>
[CimClass(ClassUri)]
public partial class ACDCTerminal(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ACDCTerminal";

    /// <summary>
    /// Порядковый номер полюса электропроводящего оборудования
    /// </summary>
    public int? sequenceNumber
    {
        get => GetAttribute<int?>(nameof(sequenceNumber));
        set => SetAttribute(nameof(sequenceNumber), value);
    }


    /// <summary>
    /// Эксплуатационные ограничения/пределы, относящиеся к полюсу.
    /// </summary>
    public OperationalLimitSet[] OperationalLimitSet => GetAssoc1ToM<OperationalLimitSet>(nameof(OperationalLimitSet));

    public void AddToOperationalLimitSet(OperationalLimitSet assocObject) =>
        AddAssoc1ToM(nameof(OperationalLimitSet), assocObject);

    public void RemoveFromOperationalLimitSet(OperationalLimitSet assocObject) =>
        RemoveAssoc1ToM(nameof(OperationalLimitSet), assocObject);

    public void RemoveAllFromOperationalLimitSet() => RemoveAllAssocs1ToM(nameof(OperationalLimitSet));

    /// <summary>
    /// Параметры измерений, которые относятся к полюсу электропроводящего оборудования.
    /// </summary>
    public Measurement[] Measurements => GetAssoc1ToM<Measurement>(nameof(Measurements));

    public void AddToMeasurements(Measurement assocObject) => AddAssoc1ToM(nameof(Measurements), assocObject);
    public void RemoveFromMeasurements(Measurement assocObject) => RemoveAssoc1ToM(nameof(Measurements), assocObject);
    public void RemoveAllFromMeasurements() => RemoveAllAssocs1ToM(nameof(Measurements));
}