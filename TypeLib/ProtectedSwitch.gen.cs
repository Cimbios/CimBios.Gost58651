using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Защищающий коммутационный аппарат.
/// </summary>
[CimClass(ClassUri)]
public partial class ProtectedSwitch(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Switch(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ProtectedSwitch";

    /// <summary>
    /// Номинальный ток отключения выключателя, А.
    /// </summary>
    public float? breakingCapacity
    {
        get => GetAttribute<float?>(nameof(breakingCapacity));
        set => SetAttribute(nameof(breakingCapacity), value);
    }
}