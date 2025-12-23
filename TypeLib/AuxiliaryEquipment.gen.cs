using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Вспомогательное оборудование.
/// </summary>
[CimClass(ClassUri)]
public partial class AuxiliaryEquipment(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Equipment(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#AuxiliaryEquipment";


    /// <summary>
    /// Полюс вспомогательного оборудования.
    /// </summary>
    public Terminal? Terminal
    {
        get => GetAssoc1To1<Terminal>(nameof(Terminal));
        set => SetAssoc1To1(nameof(Terminal), value);
    }
}