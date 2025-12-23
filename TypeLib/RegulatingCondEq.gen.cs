using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Регулирующее электропроводящее оборудование.
/// </summary>
[CimClass(ClassUri)]
public partial class RegulatingCondEq(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ConductingEquipment(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#RegulatingCondEq";


    /// <summary>
    /// Система автоматического регулирования оборудования.
    /// </summary>
    public RegulatingControl? RegulatingControl
    {
        get => GetAssoc1To1<RegulatingControl>(nameof(RegulatingControl));
        set => SetAssoc1To1(nameof(RegulatingControl), value);
    }
}