using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Трансформатор напряжения.
/// </summary>
[CimClass(ClassUri)]
public partial class PotentialTransformer(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Sensor(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PotentialTransformer";

    /// <summary>
    /// Класс точности.
    /// </summary>
    public string? accuracyClass
    {
        get => GetAttribute<string?>(nameof(accuracyClass));
        set => SetAttribute(nameof(accuracyClass), value);
    }

    /// <summary>
    /// Номинальное напряжение, кВ.
    /// </summary>
    public float? nominalVoltage
    {
        get => GetAttribute<float?>(nameof(nominalVoltage));
        set => SetAttribute(nameof(nominalVoltage), value);
    }

    /// <summary>
    /// Конструктивный тип.
    /// </summary>
    public PotentialTransformerKind? type
    {
        get => GetAttribute<PotentialTransformerKind?>(nameof(type));
        set => SetAttribute(nameof(type), value);
    }


    /// <summary>
    /// Обмотки трансформатора напряжения.
    /// </summary>
    public PotentialTransformerWinding[] Windings => GetAssoc1ToM<PotentialTransformerWinding>(nameof(Windings));

    public void AddToWindings(PotentialTransformerWinding assocObject) => AddAssoc1ToM(nameof(Windings), assocObject);

    public void RemoveFromWindings(PotentialTransformerWinding assocObject) =>
        RemoveAssoc1ToM(nameof(Windings), assocObject);

    public void RemoveAllFromWindings() => RemoveAllAssocs1ToM(nameof(Windings));
}