using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Составная часть схемы замещения трансформатора типа полного многоугольника.
/// </summary>
[CimClass(ClassUri)]
public partial class TransformerMeshImpedance(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#TransformerMeshImpedance";

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
    /// Вывод трансформатора �из�, с которым связан TransformerMeshImpedance.
    /// </summary>
    public TransformerEnd? FromTransformerEnd
    {
        get => GetAssoc1To1<TransformerEnd>(nameof(FromTransformerEnd));
        set => SetAssoc1To1(nameof(FromTransformerEnd), value);
    }

    /// <summary>
    /// Вывод трансформатора �в�, с которым связан TransformerMeshImpedance.
    /// </summary>
    public TransformerEnd[] ToTransformerEnd => GetAssoc1ToM<TransformerEnd>(nameof(ToTransformerEnd));

    public void AddToToTransformerEnd(TransformerEnd assocObject) =>
        AddAssoc1ToM(nameof(ToTransformerEnd), assocObject);

    public void RemoveFromToTransformerEnd(TransformerEnd assocObject) =>
        RemoveAssoc1ToM(nameof(ToTransformerEnd), assocObject);

    public void RemoveAllFromToTransformerEnd() => RemoveAllAssocs1ToM(nameof(ToTransformerEnd));
}