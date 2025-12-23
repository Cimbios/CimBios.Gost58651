using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Паровая турбина.
/// </summary>
[CimClass(ClassUri)]
public partial class SteamTurbine(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PrimeMover(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#SteamTurbine";


    /// <summary>
    /// Котлы, снабжающие паровую турбину.
    /// </summary>
    public SteamSupply[] SteamSupplies => GetAssoc1ToM<SteamSupply>(nameof(SteamSupplies));

    public void AddToSteamSupplies(SteamSupply assocObject) => AddAssoc1ToM(nameof(SteamSupplies), assocObject);
    public void RemoveFromSteamSupplies(SteamSupply assocObject) => RemoveAssoc1ToM(nameof(SteamSupplies), assocObject);
    public void RemoveAllFromSteamSupplies() => RemoveAllAssocs1ToM(nameof(SteamSupplies));
}