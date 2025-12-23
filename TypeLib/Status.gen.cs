using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Информация о текущем состоянии, имеющая отношение к сущности.
/// </summary>
[CimClass(ClassUri)]
public partial class Status(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Status";

    /// <summary>
    /// Дата и время, для которых применяется значение статуса.
    /// </summary>
    public DateTime? dateTime
    {
        get => GetAttribute<DateTime?>(nameof(dateTime));
        set => SetAttribute(nameof(dateTime), value);
    }

    /// <summary>
    /// Код причины или объяснение того, почему объект перешел в текущее значение состояния.
    /// </summary>
    public string? reason
    {
        get => GetAttribute<string?>(nameof(reason));
        set => SetAttribute(nameof(reason), value);
    }

    /// <summary>
    /// Соответствующая информация, касающаяся текущего значения, в виде текста свободной формы.
    /// </summary>
    public string? remark
    {
        get => GetAttribute<string?>(nameof(remark));
        set => SetAttribute(nameof(remark), value);
    }

    /// <summary>
    /// Значение статуса.
    /// </summary>
    public string? value
    {
        get => GetAttribute<string?>(nameof(value));
        set => SetAttribute(nameof(value), value);
    }
}