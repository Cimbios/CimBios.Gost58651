using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Эквивалент для поставщика электроэнергии на уровне напряжения передачи или распределения электроэнергии.
/// </summary>
[CimClass(ClassUri)]
public partial class EnergySource(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ConductingEquipment(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#EnergySource";
}