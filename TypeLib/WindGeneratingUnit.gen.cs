using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Ветроэлектрогенератор.
/// </summary>
[CimClass(ClassUri)]
public partial class WindGeneratingUnit(IOIDDescriptor oid, ICimMetaClass metaClass)
    : GeneratingUnit(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#WindGeneratingUnit";
}