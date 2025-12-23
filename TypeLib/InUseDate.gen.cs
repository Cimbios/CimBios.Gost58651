using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Даты этапов ввода в эксплуатацию.
/// </summary>
[CimClass(ClassUri)]
public partial class InUseDate(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#InUseDate";

    /// <summary>
    /// Дата ввода в эксплуатацию.
    /// </summary>
    public DateTime? inUseDate
    {
        get => GetAttribute<DateTime?>(nameof(inUseDate));
        set => SetAttribute(nameof(inUseDate), value);
    }

    /// <summary>
    /// Дата перехода в состояние &#171;Не готово к эксплуатации&#187;.
    /// </summary>
    public DateTime? notReadyForUseDate
    {
        get => GetAttribute<DateTime?>(nameof(notReadyForUseDate));
        set => SetAttribute(nameof(notReadyForUseDate), value);
    }

    /// <summary>
    /// Дата готовности для ввода в эксплуатацию.
    /// </summary>
    public DateTime? readyForUseDate
    {
        get => GetAttribute<DateTime?>(nameof(readyForUseDate));
        set => SetAttribute(nameof(readyForUseDate), value);
    }
}