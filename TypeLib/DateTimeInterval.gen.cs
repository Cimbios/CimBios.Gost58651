using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Интервал между двумя временными точками.
/// </summary>
[CimClass(ClassUri)]
public partial class DateTimeInterval(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#DateTimeInterval";

    /// <summary>
    /// Дата и время конца.
    /// </summary>
    public DateTime? end
    {
        get => GetAttribute<DateTime?>(nameof(end));
        set => SetAttribute(nameof(end), value);
    }

    /// <summary>
    /// Дата и время начала.
    /// </summary>
    public DateTime? start
    {
        get => GetAttribute<DateTime?>(nameof(start));
        set => SetAttribute(nameof(start), value);
    }
}