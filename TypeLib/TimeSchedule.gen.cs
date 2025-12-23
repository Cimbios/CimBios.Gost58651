using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Описание всего, что меняется с течением времени.
/// </summary>
[CimClass(ClassUri)]
public partial class TimeSchedule(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Document(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#TimeSchedule";

    /// <summary>
    /// Расписание.
    /// </summary>
    public DateTimeInterval? scheduleInterval
    {
        get => GetAttribute<DateTimeInterval?>(nameof(scheduleInterval));
        set => SetAttribute(nameof(scheduleInterval), value);
    }
}