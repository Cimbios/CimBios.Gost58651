using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Общие технические параметры проводниковразличных видов.
/// </summary>
[CimClass(ClassUri)]
public partial class WireInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AssetInfo(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#WireInfo";

    /// <summary>
    /// Радиус (центрального) сердечника провода, м (если материалы отличаются).
    /// </summary>
    public float? coreRadius
    {
        get => GetAttribute<float?>(nameof(coreRadius));
        set => SetAttribute(nameof(coreRadius), value);
    }

    /// <summary>
    /// Сечение проводника, м2.
    /// </summary>
    public float? crossSection
    {
        get => GetAttribute<float?>(nameof(crossSection));
        set => SetAttribute(nameof(crossSection), value);
    }

    /// <summary>
    /// Если присвоено значение &#171;Истина&#187;, проводник изолирован.
    /// </summary>
    public bool? insulated
    {
        get => GetAttribute<bool?>(nameof(insulated));
        set => SetAttribute(nameof(insulated), value);
    }

    /// <summary>
    /// Изоляционный материал.
    /// </summary>
    public WireInsulationKind? insulationMaterial
    {
        get => GetAttribute<WireInsulationKind?>(nameof(insulationMaterial));
        set => SetAttribute(nameof(insulationMaterial), value);
    }

    /// <summary>
    /// Толщина изоляции проводника, м.
    /// </summary>
    public float? insulationThickness
    {
        get => GetAttribute<float?>(nameof(insulationThickness));
        set => SetAttribute(nameof(insulationThickness), value);
    }

    /// <summary>
    /// Материал проводника.
    /// </summary>
    public WireMaterialKind? material
    {
        get => GetAttribute<WireMaterialKind?>(nameof(material));
        set => SetAttribute(nameof(material), value);
    }

    /// <summary>
    /// Внешний радиус проводника, м.
    /// </summary>
    public float? radius
    {
        get => GetAttribute<float?>(nameof(radius));
        set => SetAttribute(nameof(radius), value);
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
    /// Удельное сопротивление постоянному току при температуре 20 &#176;C, Ом/м.
    /// </summary>
    public float? rDC20
    {
        get => GetAttribute<float?>(nameof(rDC20));
        set => SetAttribute(nameof(rDC20), value);
    }

    /// <summary>
    /// Текстовая маркировка проводника или его сечения.
    /// </summary>
    public string? sizeDescription
    {
        get => GetAttribute<string?>(nameof(sizeDescription));
        set => SetAttribute(nameof(sizeDescription), value);
    }


    /// <summary>
    /// Фазы участка линии переменного тока, к которым относится информация о проводнике.
    /// </summary>
    public WirePhaseInfo[] WirePhaseInfo => GetAssoc1ToM<WirePhaseInfo>(nameof(WirePhaseInfo));

    public void AddToWirePhaseInfo(WirePhaseInfo assocObject) => AddAssoc1ToM(nameof(WirePhaseInfo), assocObject);

    public void RemoveFromWirePhaseInfo(WirePhaseInfo assocObject) =>
        RemoveAssoc1ToM(nameof(WirePhaseInfo), assocObject);

    public void RemoveAllFromWirePhaseInfo() => RemoveAllAssocs1ToM(nameof(WirePhaseInfo));
}