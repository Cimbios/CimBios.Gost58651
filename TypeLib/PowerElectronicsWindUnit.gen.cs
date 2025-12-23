using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Ветряная энергоустановка или ветропарк, подключаемые в сеть с использованием устройств на базе силовой электроники.
/// </summary>
[CimClass(ClassUri)]
public partial class PowerElectronicsWindUnit(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PowerElectronicsUnit(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PowerElectronicsWindUnit";
}