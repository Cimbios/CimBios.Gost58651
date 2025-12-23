using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Трансформатор тока.
/// </summary>
[CimClass(ClassUri)]
public partial class CurrentTransformer(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Sensor(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#CurrentTransformer";

    /// <summary>
    /// Класс точности.
    /// </summary>
    public string? accuracyClass
    {
        get => GetAttribute<string?>(nameof(accuracyClass));
        set => SetAttribute(nameof(accuracyClass), value);
    }

    /// <summary>
    /// Трансформатор тока встроенный (если присвоено значение &#171;Истина&#187;).
    /// </summary>
    public bool? isEmbeded
    {
        get => GetAttribute<bool?>(nameof(isEmbeded));
        set => SetAttribute(nameof(isEmbeded), value);
    }

    /// <summary>
    /// Номинальный ток, А.
    /// </summary>
    public float? ratedCurrent
    {
        get => GetAttribute<float?>(nameof(ratedCurrent));
        set => SetAttribute(nameof(ratedCurrent), value);
    }

    /// <summary>
    /// Номинальный вторичный ток, А.
    /// </summary>
    public float? ratedSecondaryCurrent
    {
        get => GetAttribute<float?>(nameof(ratedSecondaryCurrent));
        set => SetAttribute(nameof(ratedSecondaryCurrent), value);
    }


    /// <summary>
    /// Обмотки трансформатора тока.
    /// </summary>
    public CurrentTransformerWinding[] Windings => GetAssoc1ToM<CurrentTransformerWinding>(nameof(Windings));

    public void AddToWindings(CurrentTransformerWinding assocObject) => AddAssoc1ToM(nameof(Windings), assocObject);

    public void RemoveFromWindings(CurrentTransformerWinding assocObject) =>
        RemoveAssoc1ToM(nameof(Windings), assocObject);

    public void RemoveAllFromWindings() => RemoveAllAssocs1ToM(nameof(Windings));
}