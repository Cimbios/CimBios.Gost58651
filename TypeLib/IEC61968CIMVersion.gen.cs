using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Номер версии IEC 61968 CIM, присвоенный этой модели UML.
/// </summary>
[CimClass(ClassUri)]
public partial class IEC61968CIMVersion(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#IEC61968CIMVersion";

    /// <summary>
    /// Форма - ГГГГ-ММ-ДД, например, для 5 января 2009 года это 2009-01-05.
    /// </summary>
    public DateTime? date
    {
        get => GetAttribute<DateTime?>(nameof(date));
        set => SetAttribute(nameof(date), value);
    }

    /// <summary>
    /// Форма - IEC61968CIMXXvYY, где XX - основная версия пакета CIM, а YY - младшая версия. Например, IEC61968CIM10v17a.
    /// </summary>
    public string? version
    {
        get => GetAttribute<string?>(nameof(version));
        set => SetAttribute(nameof(version), value);
    }
}