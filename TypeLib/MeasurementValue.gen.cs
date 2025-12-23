using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Значение измерения.
/// </summary>
[CimClass(ClassUri)]
public partial class MeasurementValue(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IOPoint(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#MeasurementValue";

    /// <summary>
    /// Время измерения.
    /// </summary>
    public DateTime? timeStamp
    {
        get => GetAttribute<DateTime?>(nameof(timeStamp));
        set => SetAttribute(nameof(timeStamp), value);
    }
}