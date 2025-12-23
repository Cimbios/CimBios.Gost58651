using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Даты внедрения.
/// </summary>
[CimClass(ClassUri)]
public partial class DeploymentDate(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#DeploymentDate";

    /// <summary>
    /// Дата и время ввода в работу.
    /// </summary>
    public DateTime? inServiceDate
    {
        get => GetAttribute<DateTime?>(nameof(inServiceDate));
        set => SetAttribute(nameof(inServiceDate), value);
    }

    /// <summary>
    /// Дата и время монтажа.
    /// </summary>
    public DateTime? installedDate
    {
        get => GetAttribute<DateTime?>(nameof(installedDate));
        set => SetAttribute(nameof(installedDate), value);
    }

    /// <summary>
    /// Дата и время перехода в состояние &#171;Монтаж не закончен&#187;.
    /// </summary>
    public DateTime? notYetInstalledDate
    {
        get => GetAttribute<DateTime?>(nameof(notYetInstalledDate));
        set => SetAttribute(nameof(notYetInstalledDate), value);
    }

    /// <summary>
    /// Дата и время вывода из работы.
    /// </summary>
    public DateTime? outOfServiceDate
    {
        get => GetAttribute<DateTime?>(nameof(outOfServiceDate));
        set => SetAttribute(nameof(outOfServiceDate), value);
    }

    /// <summary>
    /// Дата и время демонтажа.
    /// </summary>
    public DateTime? removedDate
    {
        get => GetAttribute<DateTime?>(nameof(removedDate));
        set => SetAttribute(nameof(removedDate), value);
    }
}