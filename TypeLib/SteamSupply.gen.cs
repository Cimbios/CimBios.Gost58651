using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Котел.
/// </summary>
[CimClass(ClassUri)]
public partial class SteamSupply(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PowerSystemResource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#SteamSupply";


    /// <summary>
    /// Паровые турбины, снабжаемые котлом.
    /// </summary>
    public SteamTurbine[] SteamTurbines => GetAssoc1ToM<SteamTurbine>(nameof(SteamTurbines));

    public void AddToSteamTurbines(SteamTurbine assocObject) => AddAssoc1ToM(nameof(SteamTurbines), assocObject);

    public void RemoveFromSteamTurbines(SteamTurbine assocObject) =>
        RemoveAssoc1ToM(nameof(SteamTurbines), assocObject);

    public void RemoveAllFromSteamTurbines() => RemoveAllAssocs1ToM(nameof(SteamTurbines));
}