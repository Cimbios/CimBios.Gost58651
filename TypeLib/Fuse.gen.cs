using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Предохранитель с плавкой вставкой.
/// </summary>
[CimClass(ClassUri)]
public partial class Fuse(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Switch(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Fuse";
}