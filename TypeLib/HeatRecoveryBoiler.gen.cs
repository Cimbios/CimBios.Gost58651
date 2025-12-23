using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Котел утилизатор.
/// </summary>
[CimClass(ClassUri)]
public partial class HeatRecoveryBoiler(IOIDDescriptor oid, ICimMetaClass metaClass)
    : FossilSteamSupply(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#HeatRecoveryBoiler";


    /// <summary>
    /// Газовая турбина котла утилизатора.
    /// </summary>
    public CombustionTurbine[] CombustionTurbines => GetAssoc1ToM<CombustionTurbine>(nameof(CombustionTurbines));

    public void AddToCombustionTurbines(CombustionTurbine assocObject) =>
        AddAssoc1ToM(nameof(CombustionTurbines), assocObject);

    public void RemoveFromCombustionTurbines(CombustionTurbine assocObject) =>
        RemoveAssoc1ToM(nameof(CombustionTurbines), assocObject);

    public void RemoveAllFromCombustionTurbines() => RemoveAllAssocs1ToM(nameof(CombustionTurbines));
}