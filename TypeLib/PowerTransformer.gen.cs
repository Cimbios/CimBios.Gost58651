using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Силовой трансформатор.
/// </summary>
[CimClass(ClassUri)]
public partial class PowerTransformer(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ConductingEquipment(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PowerTransformer";

    /// <summary>
    /// Группа соединения обмоток.
    /// </summary>
    public string? vectorGroup
    {
        get => GetAttribute<string?>(nameof(vectorGroup));
        set => SetAttribute(nameof(vectorGroup), value);
    }


    /// <summary>
    /// Электрическиe выводы силового трансформатора.
    /// </summary>
    public PowerTransformerEnd[] PowerTransformerEnd => GetAssoc1ToM<PowerTransformerEnd>(nameof(PowerTransformerEnd));

    public void AddToPowerTransformerEnd(PowerTransformerEnd assocObject) =>
        AddAssoc1ToM(nameof(PowerTransformerEnd), assocObject);

    public void RemoveFromPowerTransformerEnd(PowerTransformerEnd assocObject) =>
        RemoveAssoc1ToM(nameof(PowerTransformerEnd), assocObject);

    public void RemoveAllFromPowerTransformerEnd() => RemoveAllAssocs1ToM(nameof(PowerTransformerEnd));

    /// <summary>
    /// Корпуса силового трансформатора.
    /// </summary>
    public TransformerTank[] TransformerTanks => GetAssoc1ToM<TransformerTank>(nameof(TransformerTanks));

    public void AddToTransformerTanks(TransformerTank assocObject) =>
        AddAssoc1ToM(nameof(TransformerTanks), assocObject);

    public void RemoveFromTransformerTanks(TransformerTank assocObject) =>
        RemoveAssoc1ToM(nameof(TransformerTanks), assocObject);

    public void RemoveAllFromTransformerTanks() => RemoveAllAssocs1ToM(nameof(TransformerTanks));

    /// <summary>
    /// Компенсационные обмотки трансформатора.
    /// </summary>
    public StabilizingWinding[] StabilizingWindings => GetAssoc1ToM<StabilizingWinding>(nameof(StabilizingWindings));

    public void AddToStabilizingWindings(StabilizingWinding assocObject) =>
        AddAssoc1ToM(nameof(StabilizingWindings), assocObject);

    public void RemoveFromStabilizingWindings(StabilizingWinding assocObject) =>
        RemoveAssoc1ToM(nameof(StabilizingWindings), assocObject);

    public void RemoveAllFromStabilizingWindings() => RemoveAllAssocs1ToM(nameof(StabilizingWindings));
}