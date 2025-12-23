using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Официальное соглашение.
/// </summary>
[CimClass(ClassUri)]
public partial class Agreement(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Document(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Agreement";

    /// <summary>
    /// Дата заключения договора [Дата и Время].
    /// </summary>
    public DateTime? signDate
    {
        get => GetAttribute<DateTime?>(nameof(signDate));
        set => SetAttribute(nameof(signDate), value);
    }

    /// <summary>
    /// Период действия договора (с момента вступления в силу до прекращения действия) [Дата и Время].
    /// </summary>
    public DateTimeInterval? validityInterval
    {
        get => GetAttribute<DateTimeInterval?>(nameof(validityInterval));
        set => SetAttribute(nameof(validityInterval), value);
    }
}