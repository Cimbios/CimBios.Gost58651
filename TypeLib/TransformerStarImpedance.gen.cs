using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Сопротивления трансформатора по модели звезда. Применяется для 2- и 3-обмоточных трансформаторов.
/// </summary>
[CimClass(ClassUri)]
public partial class TransformerStarImpedance(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#TransformerStarImpedance";

    /// <summary>
    /// Активное сопротивление прямой последовательности, Ом.
    /// </summary>
    public float? r
    {
        get => GetAttribute<float?>(nameof(r));
        set => SetAttribute(nameof(r), value);
    }

    /// <summary>
    /// Активное сопротивление нулевой последовательности, Ом.
    /// </summary>
    public float? r0
    {
        get => GetAttribute<float?>(nameof(r0));
        set => SetAttribute(nameof(r0), value);
    }

    /// <summary>
    /// Реактивное сопротивление прямой последовательности, Ом.
    /// </summary>
    public float? x
    {
        get => GetAttribute<float?>(nameof(x));
        set => SetAttribute(nameof(x), value);
    }

    /// <summary>
    /// Реактивное сопротивление нулевой последовательности, Ом.
    /// </summary>
    public float? x0
    {
        get => GetAttribute<float?>(nameof(x0));
        set => SetAttribute(nameof(x0), value);
    }

    /// <summary>
    /// Технические параметры вывода трансформатора с которыми связаны электрические параметры трансформатора по модели звезда.
    /// </summary>
    public TransformerEndInfo? TransformerEndInfo
    {
        get => GetAssoc1To1<TransformerEndInfo>(nameof(TransformerEndInfo));
        set => SetAssoc1To1(nameof(TransformerEndInfo), value);
    }

    /// <summary>
    /// Выводы трансформатора с которыми связаны электрические параметры трансформатора по модели звезда.
    /// </summary>
    public TransformerEnd[] TransformerEnd => GetAssoc1ToM<TransformerEnd>(nameof(TransformerEnd));

    public void AddToTransformerEnd(TransformerEnd assocObject) => AddAssoc1ToM(nameof(TransformerEnd), assocObject);

    public void RemoveFromTransformerEnd(TransformerEnd assocObject) =>
        RemoveAssoc1ToM(nameof(TransformerEnd), assocObject);

    public void RemoveAllFromTransformerEnd() => RemoveAllAssocs1ToM(nameof(TransformerEnd));
}