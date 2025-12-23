using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Общие дополнительные технические параметры коммутационных аппаратов.
/// </summary>
[CimClass(ClassUri)]
public partial class OldSwitchInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : SwitchInfo(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#OldSwitchInfo";
}