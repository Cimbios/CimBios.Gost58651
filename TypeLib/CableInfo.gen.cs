using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры кабеля.
/// </summary>
[CimClass(ClassUri)]
public partial class CableInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : WireInfo(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#CableInfo";

    /// <summary>
    /// Тип конструкции кабеля.
    /// </summary>
    public CableConstructionKind? constructionKind
    {
        get => GetAttribute<CableConstructionKind?>(nameof(constructionKind));
        set => SetAttribute(nameof(constructionKind), value);
    }

    /// <summary>
    /// Диаметр проводящей части, включая полупроводящие оболочки, не включая изолирующие слои, м.
    /// </summary>
    public float? diameterOverCore
    {
        get => GetAttribute<float?>(nameof(diameterOverCore));
        set => SetAttribute(nameof(diameterOverCore), value);
    }

    /// <summary>
    /// Диаметр изолирующей оболочки, исключая внешней экран, мм.
    /// </summary>
    public float? diameterOverInsulation
    {
        get => GetAttribute<float?>(nameof(diameterOverInsulation));
        set => SetAttribute(nameof(diameterOverInsulation), value);
    }

    /// <summary>
    /// Диаметр наружной оболочки кабеля, м.
    /// </summary>
    public float? diameterOverJacket
    {
        get => GetAttribute<float?>(nameof(diameterOverJacket));
        set => SetAttribute(nameof(diameterOverJacket), value);
    }

    /// <summary>
    /// Диаметр по полупроводящему экрану под проводящим экраном, м.
    /// </summary>
    public float? diameterOverScreen
    {
        get => GetAttribute<float?>(nameof(diameterOverScreen));
        set => SetAttribute(nameof(diameterOverScreen), value);
    }

    /// <summary>
    /// Относительная диэлектрическая проницаемость изоляции между жилой и экраном, о.е.
    /// </summary>
    public float? insulationEr
    {
        get => GetAttribute<float?>(nameof(insulationEr));
        set => SetAttribute(nameof(insulationEr), value);
    }

    /// <summary>
    /// Относительная диэлектрическая проницаемость изоляции экрана, о.е.
    /// </summary>
    public float? insulationErShield
    {
        get => GetAttribute<float?>(nameof(insulationErShield));
        set => SetAttribute(nameof(insulationErShield), value);
    }

    /// <summary>
    /// Длительно допустимая температура нагрева жил кабеля, &#176;C.
    /// </summary>
    public float? nominalTemperature
    {
        get => GetAttribute<float?>(nameof(nominalTemperature));
        set => SetAttribute(nameof(nominalTemperature), value);
    }

    /// <summary>
    /// Вид материала наружной оболочки.
    /// </summary>
    public CableOuterJacketKind? outerJacketKind
    {
        get => GetAttribute<CableOuterJacketKind?>(nameof(outerJacketKind));
        set => SetAttribute(nameof(outerJacketKind), value);
    }

    /// <summary>
    /// Толщина алюминиевой ленты для поперечной герметизации, м.
    /// </summary>
    public float? radialMoistureBarrierThicknes
    {
        get => GetAttribute<float?>(nameof(radialMoistureBarrierThicknes));
        set => SetAttribute(nameof(radialMoistureBarrierThicknes), value);
    }

    /// <summary>
    /// Толщина брони кабеля, м.
    /// </summary>
    public float? sheathThickness
    {
        get => GetAttribute<float?>(nameof(sheathThickness));
        set => SetAttribute(nameof(sheathThickness), value);
    }

    /// <summary>
    /// Сечение экрана, м2.
    /// </summary>
    public float? shieldCrossSection
    {
        get => GetAttribute<float?>(nameof(shieldCrossSection));
        set => SetAttribute(nameof(shieldCrossSection), value);
    }

    /// <summary>
    /// Тип заземления экрана.
    /// </summary>
    public ShieldGroundingKind? shieldGrounding
    {
        get => GetAttribute<ShieldGroundingKind?>(nameof(shieldGrounding));
        set => SetAttribute(nameof(shieldGrounding), value);
    }

    /// <summary>
    /// Транспозиция экрана (присутствует, если присвоено значение &#171;Истина&#187;).
    /// </summary>
    public bool? shieldIsTransposed
    {
        get => GetAttribute<bool?>(nameof(shieldIsTransposed));
        set => SetAttribute(nameof(shieldIsTransposed), value);
    }

    /// <summary>
    /// Материал экрана кабеля.
    /// </summary>
    public CableShieldMaterialKind? shieldMaterial
    {
        get => GetAttribute<CableShieldMaterialKind?>(nameof(shieldMaterial));
        set => SetAttribute(nameof(shieldMaterial), value);
    }

    /// <summary>
    /// Толщина полупроводящего покрытия по внутренней стороне экрана, м.
    /// </summary>
    public float? underShieldScreenThickness
    {
        get => GetAttribute<float?>(nameof(underShieldScreenThickness));
        set => SetAttribute(nameof(underShieldScreenThickness), value);
    }
}