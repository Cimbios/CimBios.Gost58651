using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Секция шин.
/// </summary>
[CimClass(ClassUri)]
public partial class BusbarSection(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Connector(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#BusbarSection";

    /// <summary>
    /// Максимально допустимый пиковый ток короткого замыкания, А.
    /// </summary>
    public float? ipMax
    {
        get => GetAttribute<float?>(nameof(ipMax));
        set => SetAttribute(nameof(ipMax), value);
    }
}