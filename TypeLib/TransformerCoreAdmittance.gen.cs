using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Электрические параметры магнитопровода трансформатора.
/// </summary>
[CimClass(ClassUri)]
public partial class TransformerCoreAdmittance(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#TransformerCoreAdmittance";

    /// <summary>
    /// Реактивная проводимость прямой последовательности шунта намагничивания, приведенная к номинальному напряжению вывода с наивысшим напряжением, См.
    /// </summary>
    public float? b
    {
        get => GetAttribute<float?>(nameof(b));
        set => SetAttribute(nameof(b), value);
    }

    /// <summary>
    /// Реактивная проводимость нулевой последовательности шунта намагничивания, приведенная к номинальному напряжению вывода с наивысшим напряжением, См.
    /// </summary>
    public float? b0
    {
        get => GetAttribute<float?>(nameof(b0));
        set => SetAttribute(nameof(b0), value);
    }

    /// <summary>
    /// Схема соединения обмоток.
    /// </summary>
    public WindingConnection? connectionKind
    {
        get => GetAttribute<WindingConnection?>(nameof(connectionKind));
        set => SetAttribute(nameof(connectionKind), value);
    }

    /// <summary>
    /// Активная проводимость прямой последовательности шунта намагничивания, приведенная к номинальному напряжению вывода с наивысшим напряжением, См.
    /// </summary>
    public float? g
    {
        get => GetAttribute<float?>(nameof(g));
        set => SetAttribute(nameof(g), value);
    }

    /// <summary>
    /// Технические параметры вывода трансформатора с которыми связаны электрические параметры магнитопровода трансформатора.
    /// </summary>
    public TransformerEndInfo? TransformerEndInfo
    {
        get => GetAssoc1To1<TransformerEndInfo>(nameof(TransformerEndInfo));
        set => SetAssoc1To1(nameof(TransformerEndInfo), value);
    }

    /// <summary>
    /// Выводы трансформатора с которыми связаны электрические параметры магнитопровода трансформатора.
    /// </summary>
    public TransformerEnd[] TransformerEnd => GetAssoc1ToM<TransformerEnd>(nameof(TransformerEnd));

    public void AddToTransformerEnd(TransformerEnd assocObject) => AddAssoc1ToM(nameof(TransformerEnd), assocObject);

    public void RemoveFromTransformerEnd(TransformerEnd assocObject) =>
        RemoveAssoc1ToM(nameof(TransformerEnd), assocObject);

    public void RemoveAllFromTransformerEnd() => RemoveAllAssocs1ToM(nameof(TransformerEnd));
}