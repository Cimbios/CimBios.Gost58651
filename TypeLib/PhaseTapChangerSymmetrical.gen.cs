using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Фазовращатель симметричный.
/// </summary>
[CimClass(ClassUri)]
public partial class PhaseTapChangerSymmetrical(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PhaseTapChangerNonLinear(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PhaseTapChangerSymmetrical";
}