using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Потребитель электрической энергии (обобщенное понятие) � точка потребления.
/// </summary>
[CimClass(ClassUri)]
public partial class EnergyConsumer(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ConductingEquipment(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#EnergyConsumer";

    /// <summary>
    /// Количество индивидуальных потребителей, представленных данной точкой потребления.
    /// </summary>
    public int? customerCount
    {
        get => GetAttribute<int?>(nameof(customerCount));
        set => SetAttribute(nameof(customerCount), value);
    }
}