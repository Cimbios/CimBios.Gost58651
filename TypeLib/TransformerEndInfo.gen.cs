using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры вывода трансформатора.
/// </summary>
[CimClass(ClassUri)]
public partial class TransformerEndInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AssetInfo(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#TransformerEndInfo";

    /// <summary>
    /// Номер вывода трансформатора.
    /// </summary>
    public int? endNumber
    {
        get => GetAttribute<int?>(nameof(endNumber));
        set => SetAttribute(nameof(endNumber), value);
    }

    /// <summary>
    /// Номинальное напряжение, кВ.
    /// </summary>
    public float? ratedU
    {
        get => GetAttribute<float?>(nameof(ratedU));
        set => SetAttribute(nameof(ratedU), value);
    }

    /// <summary>
    /// Информация о конструкции трансформатора.
    /// </summary>
    public TransformerTankInfo? TransformerTankInfo
    {
        get => GetAssoc1To1<TransformerTankInfo>(nameof(TransformerTankInfo));
        set => SetAssoc1To1(nameof(TransformerTankInfo), value);
    }

    /// <summary>
    /// Электрические параметры магнитопровода трансформатора связанные с информацией о технических параметрах выводов трансформатора.
    /// </summary>
    public TransformerCoreAdmittance? CoreAdmittance
    {
        get => GetAssoc1To1<TransformerCoreAdmittance>(nameof(CoreAdmittance));
        set => SetAssoc1To1(nameof(CoreAdmittance), value);
    }

    /// <summary>
    /// Электрические параметры трансформатора по модели звезда, связанные с информацией о технических параметрах выводов трансформатора.
    /// </summary>
    public TransformerStarImpedance? TransformerStarImpedance
    {
        get => GetAssoc1To1<TransformerStarImpedance>(nameof(TransformerStarImpedance));
        set => SetAssoc1To1(nameof(TransformerStarImpedance), value);
    }

    /// <summary>
    /// Все опыты холостого хода, в которых вывод трансформатора был под напряжением.
    /// </summary>
    public NoLoadTest[] EnergisedEndNoLoadTests => GetAssoc1ToM<NoLoadTest>(nameof(EnergisedEndNoLoadTests));

    public void AddToEnergisedEndNoLoadTests(NoLoadTest assocObject) =>
        AddAssoc1ToM(nameof(EnergisedEndNoLoadTests), assocObject);

    public void RemoveFromEnergisedEndNoLoadTests(NoLoadTest assocObject) =>
        RemoveAssoc1ToM(nameof(EnergisedEndNoLoadTests), assocObject);

    public void RemoveAllFromEnergisedEndNoLoadTests() => RemoveAllAssocs1ToM(nameof(EnergisedEndNoLoadTests));

    /// <summary>
    /// Все опыты короткого замыкания, в которых вывод трансформатора был заземлен.
    /// </summary>
    public ShortCircuitTest[] GroundedEndShortCircuitTests =>
        GetAssoc1ToM<ShortCircuitTest>(nameof(GroundedEndShortCircuitTests));

    public void AddToGroundedEndShortCircuitTests(ShortCircuitTest assocObject) =>
        AddAssoc1ToM(nameof(GroundedEndShortCircuitTests), assocObject);

    public void RemoveFromGroundedEndShortCircuitTests(ShortCircuitTest assocObject) =>
        RemoveAssoc1ToM(nameof(GroundedEndShortCircuitTests), assocObject);

    public void RemoveAllFromGroundedEndShortCircuitTests() =>
        RemoveAllAssocs1ToM(nameof(GroundedEndShortCircuitTests));

    /// <summary>
    /// Все опыты короткого замыкания, в которых вывод трансформатора был под напряжением.
    /// </summary>
    public ShortCircuitTest[] EnergisedEndShortCircuitTests =>
        GetAssoc1ToM<ShortCircuitTest>(nameof(EnergisedEndShortCircuitTests));

    public void AddToEnergisedEndShortCircuitTests(ShortCircuitTest assocObject) =>
        AddAssoc1ToM(nameof(EnergisedEndShortCircuitTests), assocObject);

    public void RemoveFromEnergisedEndShortCircuitTests(ShortCircuitTest assocObject) =>
        RemoveAssoc1ToM(nameof(EnergisedEndShortCircuitTests), assocObject);

    public void RemoveAllFromEnergisedEndShortCircuitTests() =>
        RemoveAllAssocs1ToM(nameof(EnergisedEndShortCircuitTests));

    /// <summary>
    /// Выводы трансформаторов, которым принадлежат технические параметры.
    /// </summary>
    public PowerTransformerEnd[] PowerTransformerEnd => GetAssoc1ToM<PowerTransformerEnd>(nameof(PowerTransformerEnd));

    public void AddToPowerTransformerEnd(PowerTransformerEnd assocObject) =>
        AddAssoc1ToM(nameof(PowerTransformerEnd), assocObject);

    public void RemoveFromPowerTransformerEnd(PowerTransformerEnd assocObject) =>
        RemoveAssoc1ToM(nameof(PowerTransformerEnd), assocObject);

    public void RemoveAllFromPowerTransformerEnd() => RemoveAllAssocs1ToM(nameof(PowerTransformerEnd));

    /// <summary>
    /// Компенсационные обмотки трансформатора, к которым относятся технические параметры обмотки.
    /// </summary>
    public StabilizingWinding[] StabilizingWindings => GetAssoc1ToM<StabilizingWinding>(nameof(StabilizingWindings));

    public void AddToStabilizingWindings(StabilizingWinding assocObject) =>
        AddAssoc1ToM(nameof(StabilizingWindings), assocObject);

    public void RemoveFromStabilizingWindings(StabilizingWinding assocObject) =>
        RemoveAssoc1ToM(nameof(StabilizingWindings), assocObject);

    public void RemoveAllFromStabilizingWindings() => RemoveAllAssocs1ToM(nameof(StabilizingWindings));
}