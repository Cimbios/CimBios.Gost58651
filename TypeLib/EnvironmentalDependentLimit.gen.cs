using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Зависимость эксплуатационных ограничений/пределов от параметров окружающей среды.
/// </summary>
[CimClass(ClassUri)]
public partial class EnvironmentalDependentLimit(IOIDDescriptor oid, ICimMetaClass metaClass)
    : LimitDependency(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#EnvironmentalDependentLimit";
}