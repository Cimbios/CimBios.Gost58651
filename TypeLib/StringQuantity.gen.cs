using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Величина со строковым значением.
/// </summary>
[CimClass(ClassUri)]
public partial class StringQuantity(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#StringQuantity";

    /// <summary>
    /// Значение.
    /// </summary>
    public string? value
    {
        get => GetAttribute<string?>(nameof(value));
        set => SetAttribute(nameof(value), value);
    }
}