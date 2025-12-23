using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Данные, полученные через регулярные промежутки времени.
/// </summary>
[CimClass(ClassUri)]
public partial class IntervalReading(IOIDDescriptor oid, ICimMetaClass metaClass)
    : BaseReading(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#IntervalReading";


    /// <summary>
    /// Временные последовательности показаний, содержащие это показание.
    /// </summary>
    public IntervalBlock[] IntervalBlocks => GetAssoc1ToM<IntervalBlock>(nameof(IntervalBlocks));

    public void AddToIntervalBlocks(IntervalBlock assocObject) => AddAssoc1ToM(nameof(IntervalBlocks), assocObject);

    public void RemoveFromIntervalBlocks(IntervalBlock assocObject) =>
        RemoveAssoc1ToM(nameof(IntervalBlocks), assocObject);

    public void RemoveAllFromIntervalBlocks() => RemoveAllAssocs1ToM(nameof(IntervalBlocks));
}