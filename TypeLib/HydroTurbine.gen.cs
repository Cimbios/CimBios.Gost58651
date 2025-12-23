using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Гидротурбина.
/// </summary>
[CimClass(ClassUri)]
public partial class HydroTurbine(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PrimeMover(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#HydroTurbine";

    /// <summary>
    /// Тип турбины.
    /// </summary>
    public HydroTurbineKind? turbineType
    {
        get => GetAttribute<HydroTurbineKind?>(nameof(turbineType));
        set => SetAttribute(nameof(turbineType), value);
    }
}