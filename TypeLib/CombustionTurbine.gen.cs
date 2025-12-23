using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Газовая турбина.
/// </summary>
[CimClass(ClassUri)]
public partial class CombustionTurbine(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PrimeMover(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#CombustionTurbine";


    /// <summary>
    /// Котел утилизатор газовой турбины.
    /// </summary>
    public HeatRecoveryBoiler? HeatRecoveryBoiler
    {
        get => GetAssoc1To1<HeatRecoveryBoiler>(nameof(HeatRecoveryBoiler));
        set => SetAssoc1To1(nameof(HeatRecoveryBoiler), value);
    }
}