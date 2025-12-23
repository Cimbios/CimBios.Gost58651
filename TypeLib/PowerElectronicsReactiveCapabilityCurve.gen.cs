using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// P-Q диаграмма для устройств на базе силовой электроники.
/// </summary>
[CimClass(ClassUri)]
public partial class PowerElectronicsReactiveCapabilityCurve(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Curve(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#PowerElectronicsReactiveCapabilityCurve";


    /// <summary>
    /// Устройство на базе силовой электроники, к которому относится P-Q диаграмма.
    /// </summary>
    public PowerElectronicsConnection[] PowerElectronicsConnection =>
        GetAssoc1ToM<PowerElectronicsConnection>(nameof(PowerElectronicsConnection));

    public void AddToPowerElectronicsConnection(PowerElectronicsConnection assocObject) =>
        AddAssoc1ToM(nameof(PowerElectronicsConnection), assocObject);

    public void RemoveFromPowerElectronicsConnection(PowerElectronicsConnection assocObject) =>
        RemoveAssoc1ToM(nameof(PowerElectronicsConnection), assocObject);

    public void RemoveAllFromPowerElectronicsConnection() => RemoveAllAssocs1ToM(nameof(PowerElectronicsConnection));
}