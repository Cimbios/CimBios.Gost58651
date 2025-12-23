using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Параметры опыта короткого замыкания обмотки трансформатора.
/// </summary>
[CimClass(ClassUri)]
public partial class ShortCircuitTest(IOIDDescriptor oid, ICimMetaClass metaClass)
    : TransformerTest(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ShortCircuitTest";

    /// <summary>
    /// Положение переключателя ответвлений для обмотки под напряжением.
    /// </summary>
    public int? energisedEndStep
    {
        get => GetAttribute<int?>(nameof(energisedEndStep));
        set => SetAttribute(nameof(energisedEndStep), value);
    }

    /// <summary>
    /// Положение переключателя ответвлений для заземленной обмотки.
    /// </summary>
    public int? groundedEndStep
    {
        get => GetAttribute<int?>(nameof(groundedEndStep));
        set => SetAttribute(nameof(groundedEndStep), value);
    }

    /// <summary>
    /// Потери короткого замыкания, кВт.
    /// </summary>
    public float? loss
    {
        get => GetAttribute<float?>(nameof(loss));
        set => SetAttribute(nameof(loss), value);
    }

    /// <summary>
    /// Напряжение короткого замыкания, %.
    /// </summary>
    public float? voltage
    {
        get => GetAttribute<float?>(nameof(voltage));
        set => SetAttribute(nameof(voltage), value);
    }

    /// <summary>
    /// Вывод трансформатора, к которому относятся данные опыта короткого замыкания.
    /// </summary>
    public TransformerEndInfo? EnergisedEnd
    {
        get => GetAssoc1To1<TransformerEndInfo>(nameof(EnergisedEnd));
        set => SetAssoc1To1(nameof(EnergisedEnd), value);
    }

    /// <summary>
    /// Заземленные выводы трансформатора в опыте короткого замыкания.
    /// </summary>
    public TransformerEndInfo[] GroundedEnds => GetAssoc1ToM<TransformerEndInfo>(nameof(GroundedEnds));

    public void AddToGroundedEnds(TransformerEndInfo assocObject) => AddAssoc1ToM(nameof(GroundedEnds), assocObject);

    public void RemoveFromGroundedEnds(TransformerEndInfo assocObject) =>
        RemoveAssoc1ToM(nameof(GroundedEnds), assocObject);

    public void RemoveAllFromGroundedEnds() => RemoveAllAssocs1ToM(nameof(GroundedEnds));
}