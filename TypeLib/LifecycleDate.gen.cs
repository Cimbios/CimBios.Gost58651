using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Даты этапов жизненного цикла.
/// </summary>
[CimClass(ClassUri)]
public partial class LifecycleDate(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#LifecycleDate";

    /// <summary>
    /// Первоначальная дата ввода оборудования в эксплуатацию.
    /// </summary>
    public DateTime? initialInServiceDate
    {
        get => GetAttribute<DateTime?>(nameof(initialInServiceDate));
        set => SetAttribute(nameof(initialInServiceDate), value);
    }

    /// <summary>
    /// Дата установки.
    /// </summary>
    public DateTime? installationDate
    {
        get => GetAttribute<DateTime?>(nameof(installationDate));
        set => SetAttribute(nameof(installationDate), value);
    }

    /// <summary>
    /// Дата производства.
    /// </summary>
    public DateTime? manufacturedDate
    {
        get => GetAttribute<DateTime?>(nameof(manufacturedDate));
        set => SetAttribute(nameof(manufacturedDate), value);
    }

    /// <summary>
    /// Дата демонтажа.
    /// </summary>
    public DateTime? removalDate
    {
        get => GetAttribute<DateTime?>(nameof(removalDate));
        set => SetAttribute(nameof(removalDate), value);
    }

    /// <summary>
    /// Дата списания.
    /// </summary>
    public DateTime? retiredDate
    {
        get => GetAttribute<DateTime?>(nameof(retiredDate));
        set => SetAttribute(nameof(retiredDate), value);
    }
}