using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Проводник.
/// </summary>
[CimClass(ClassUri)]
public partial class Conductor(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ConductingEquipment(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Conductor";

    /// <summary>
    /// Длина проводника, м.
    /// </summary>
    public float? length
    {
        get => GetAttribute<float?>(nameof(length));
        set => SetAttribute(nameof(length), value);
    }
}