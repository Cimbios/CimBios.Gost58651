using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Фотоэлектрический солнечный модуль или группа модулей.
/// </summary>
[CimClass(ClassUri)]
public partial class PhotoVoltaicUnit(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PowerElectronicsUnit(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PhotoVoltaicUnit";
}