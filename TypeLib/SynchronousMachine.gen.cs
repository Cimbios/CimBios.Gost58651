using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Синхронная машина.
/// </summary>
[CimClass(ClassUri)]
public partial class SynchronousMachine(IOIDDescriptor oid, ICimMetaClass metaClass)
    : RotatingMachine(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#SynchronousMachine";

    /// <summary>
    /// Активная мощность, потребляемая в режиме синхронного компенсатора, МВт.
    /// </summary>
    public float? condenserP
    {
        get => GetAttribute<float?>(nameof(condenserP));
        set => SetAttribute(nameof(condenserP), value);
    }

    /// <summary>
    /// Тип охлаждающего агента.
    /// </summary>
    public CoolantType? coolantType
    {
        get => GetAttribute<CoolantType?>(nameof(coolantType));
        set => SetAttribute(nameof(coolantType), value);
    }

    /// <summary>
    /// Нейтраль заземлена (если присвоено значение &#171;Истина&#187;).
    /// </summary>
    public bool? earthing
    {
        get => GetAttribute<bool?>(nameof(earthing));
        set => SetAttribute(nameof(earthing), value);
    }

    /// <summary>
    /// Активное сопротивление заземления нейтральной точки генератора в схеме &#171;звезда&#187;, Ом.
    /// </summary>
    public float? earthingStarPointR
    {
        get => GetAttribute<float?>(nameof(earthingStarPointR));
        set => SetAttribute(nameof(earthingStarPointR), value);
    }

    /// <summary>
    /// Реактивное сопротивление заземления нейтральной точки генератора в схеме &#171;звезда&#187;, Ом.
    /// </summary>
    public float? earthingStarPointX
    {
        get => GetAttribute<float?>(nameof(earthingStarPointX));
        set => SetAttribute(nameof(earthingStarPointX), value);
    }

    /// <summary>
    /// Верхний предел по реактивной мощности (паспортный параметр), Мвар.
    /// </summary>
    public float? maxQ
    {
        get => GetAttribute<float?>(nameof(maxQ));
        set => SetAttribute(nameof(maxQ), value);
    }

    /// <summary>
    /// Ограничение по максимальному напряжению, кВ.
    /// </summary>
    public float? maxU
    {
        get => GetAttribute<float?>(nameof(maxU));
        set => SetAttribute(nameof(maxU), value);
    }

    /// <summary>
    /// Нижний предел по реактивной мощности, Мвар.
    /// </summary>
    public float? minQ
    {
        get => GetAttribute<float?>(nameof(minQ));
        set => SetAttribute(nameof(minQ), value);
    }

    /// <summary>
    /// Ограничение по минимальному напряжению, кВ.
    /// </summary>
    public float? minU
    {
        get => GetAttribute<float?>(nameof(minU));
        set => SetAttribute(nameof(minU), value);
    }

    /// <summary>
    /// Текущий режим работы синхронной машины.
    /// </summary>
    public SynchronousMachineOperatingMode? operatingMode
    {
        get => GetAttribute<SynchronousMachineOperatingMode?>(nameof(operatingMode));
        set => SetAttribute(nameof(operatingMode), value);
    }

    /// <summary>
    /// Активное сопротивление статора, Ом.
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
    /// Активное сопротивление обратной последовательности, Ом.
    /// </summary>
    public float? r2
    {
        get => GetAttribute<float?>(nameof(r2));
        set => SetAttribute(nameof(r2), value);
    }

    /// <summary>
    /// Реактивное насыщенное сверхпереходное сопротивление по продольной оси Xd'', о.е.
    /// </summary>
    public float? satDirectSubtransX
    {
        get => GetAttribute<float?>(nameof(satDirectSubtransX));
        set => SetAttribute(nameof(satDirectSubtransX), value);
    }

    /// <summary>
    /// Режимы работы, в которых синхронная машина способна работать.
    /// </summary>
    public SynchronousMachineKind? type
    {
        get => GetAttribute<SynchronousMachineKind?>(nameof(type));
        set => SetAttribute(nameof(type), value);
    }

    /// <summary>
    /// Реактивное сопротивление прямой последовательности схемы замещения для расчета токов короткого замыкания, Ом.
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
    /// Реактивное сопротивление обратной последовательности, Ом.
    /// </summary>
    public float? x2
    {
        get => GetAttribute<float?>(nameof(x2));
        set => SetAttribute(nameof(x2), value);
    }

    /// <summary>
    /// P-Q диаграмма синхронной машины по умолчанию.
    /// </summary>
    public ReactiveCapabilityCurve? InitialReactiveCapabilityCurve
    {
        get => GetAssoc1To1<ReactiveCapabilityCurve>(nameof(InitialReactiveCapabilityCurve));
        set => SetAssoc1To1(nameof(InitialReactiveCapabilityCurve), value);
    }

    /// <summary>
    /// Динамические параметры синхронной машины.
    /// </summary>
    public SynchronousMachineDynamics? SynchronousMachineDynamics
    {
        get => GetAssoc1To1<SynchronousMachineDynamics>(nameof(SynchronousMachineDynamics));
        set => SetAssoc1To1(nameof(SynchronousMachineDynamics), value);
    }

    /// <summary>
    /// P-Q диаграммы синхронной машины.
    /// </summary>
    public ReactiveCapabilityCurve[] ReactiveCapabilityCurves =>
        GetAssoc1ToM<ReactiveCapabilityCurve>(nameof(ReactiveCapabilityCurves));

    public void AddToReactiveCapabilityCurves(ReactiveCapabilityCurve assocObject) =>
        AddAssoc1ToM(nameof(ReactiveCapabilityCurves), assocObject);

    public void RemoveFromReactiveCapabilityCurves(ReactiveCapabilityCurve assocObject) =>
        RemoveAssoc1ToM(nameof(ReactiveCapabilityCurves), assocObject);

    public void RemoveAllFromReactiveCapabilityCurves() => RemoveAllAssocs1ToM(nameof(ReactiveCapabilityCurves));

    /// <summary>
    /// Первичный двигатель синхронного генератора.
    /// </summary>
    public PrimeMover[] PrimeMovers => GetAssoc1ToM<PrimeMover>(nameof(PrimeMovers));

    public void AddToPrimeMovers(PrimeMover assocObject) => AddAssoc1ToM(nameof(PrimeMovers), assocObject);
    public void RemoveFromPrimeMovers(PrimeMover assocObject) => RemoveAssoc1ToM(nameof(PrimeMovers), assocObject);
    public void RemoveAllFromPrimeMovers() => RemoveAllAssocs1ToM(nameof(PrimeMovers));

    /// <summary>
    /// Система возбуждения синхронной машины.
    /// </summary>
    public ExcitationSystem[] ExcitationSystem => GetAssoc1ToM<ExcitationSystem>(nameof(ExcitationSystem));

    public void AddToExcitationSystem(ExcitationSystem assocObject) =>
        AddAssoc1ToM(nameof(ExcitationSystem), assocObject);

    public void RemoveFromExcitationSystem(ExcitationSystem assocObject) =>
        RemoveAssoc1ToM(nameof(ExcitationSystem), assocObject);

    public void RemoveAllFromExcitationSystem() => RemoveAllAssocs1ToM(nameof(ExcitationSystem));
}