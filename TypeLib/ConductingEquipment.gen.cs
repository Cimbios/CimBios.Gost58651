using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Электропроводящее оборудование.
/// </summary>
[CimClass(ClassUri)]
public partial class ConductingEquipment(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Equipment(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ConductingEquipment";

    /// <summary>
    /// Трехфазное исполнение оборудования.
    /// </summary>
    public bool? isThreePhaseEquipment
    {
        get => GetAttribute<bool?>(nameof(isThreePhaseEquipment));
        set => SetAttribute(nameof(isThreePhaseEquipment), value);
    }

    /// <summary>
    /// Стандартное номинальное напряжение электропроводящего оборудования.
    /// </summary>
    public BaseVoltage? BaseVoltage
    {
        get => GetAssoc1To1<BaseVoltage>(nameof(BaseVoltage));
        set => SetAssoc1To1(nameof(BaseVoltage), value);
    }

    /// <summary>
    /// Полюса электропроводящего оборудования.
    /// </summary>
    public Terminal[] Terminals => GetAssoc1ToM<Terminal>(nameof(Terminals));

    public void AddToTerminals(Terminal assocObject) => AddAssoc1ToM(nameof(Terminals), assocObject);
    public void RemoveFromTerminals(Terminal assocObject) => RemoveAssoc1ToM(nameof(Terminals), assocObject);
    public void RemoveAllFromTerminals() => RemoveAllAssocs1ToM(nameof(Terminals));
}