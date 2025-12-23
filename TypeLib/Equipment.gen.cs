using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Оборудование.
/// </summary>
[CimClass(ClassUri)]
public partial class Equipment(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PowerSystemResource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Equipment";

    /// <summary>
    /// Если присвоено значение &#171;Истина&#187;, оборудование находится в работе.
    /// </summary>
    public bool? normallyInService
    {
        get => GetAttribute<bool?>(nameof(normallyInService));
        set => SetAttribute(nameof(normallyInService), value);
    }

    /// <summary>
    /// Контейнер оборудования, к которому относится единица оборудования.
    /// </summary>
    public EquipmentContainer? EquipmentContainer
    {
        get => GetAssoc1To1<EquipmentContainer>(nameof(EquipmentContainer));
        set => SetAssoc1To1(nameof(EquipmentContainer), value);
    }

    /// <summary>
    /// Допустимая длительность значения напряжения в зависимости от его диапазона.
    /// </summary>
    public VoltageLimitDurationCurve? VoltageLimitDurationCurve
    {
        get => GetAssoc1To1<VoltageLimitDurationCurve>(nameof(VoltageLimitDurationCurve));
        set => SetAssoc1To1(nameof(VoltageLimitDurationCurve), value);
    }

    /// <summary>
    /// Зависимости эксплуатационных  ограничений/пределов.
    /// </summary>
    public LimitDependency[] LimitDependencyModel => GetAssoc1ToM<LimitDependency>(nameof(LimitDependencyModel));

    public void AddToLimitDependencyModel(LimitDependency assocObject) =>
        AddAssoc1ToM(nameof(LimitDependencyModel), assocObject);

    public void RemoveFromLimitDependencyModel(LimitDependency assocObject) =>
        RemoveAssoc1ToM(nameof(LimitDependencyModel), assocObject);

    public void RemoveAllFromLimitDependencyModel() => RemoveAllAssocs1ToM(nameof(LimitDependencyModel));

    /// <summary>
    /// Дополнительная ассоциация оборудования с другим контейнером.
    /// </summary>
    public EquipmentContainer[] AdditionalEquipmentContainer =>
        GetAssoc1ToM<EquipmentContainer>(nameof(AdditionalEquipmentContainer));

    public void AddToAdditionalEquipmentContainer(EquipmentContainer assocObject) =>
        AddAssoc1ToM(nameof(AdditionalEquipmentContainer), assocObject);

    public void RemoveFromAdditionalEquipmentContainer(EquipmentContainer assocObject) =>
        RemoveAssoc1ToM(nameof(AdditionalEquipmentContainer), assocObject);

    public void RemoveAllFromAdditionalEquipmentContainer() =>
        RemoveAllAssocs1ToM(nameof(AdditionalEquipmentContainer));

    /// <summary>
    /// Точки учета, относящиеся к данному оборудованию.
    /// </summary>
    public UsagePoint[] UsagePoints => GetAssoc1ToM<UsagePoint>(nameof(UsagePoints));

    public void AddToUsagePoints(UsagePoint assocObject) => AddAssoc1ToM(nameof(UsagePoints), assocObject);
    public void RemoveFromUsagePoints(UsagePoint assocObject) => RemoveAssoc1ToM(nameof(UsagePoints), assocObject);
    public void RemoveAllFromUsagePoints() => RemoveAllAssocs1ToM(nameof(UsagePoints));

    /// <summary>
    /// Набор эксплуатационных ограничений/пределов оборудования.
    /// </summary>
    public OperationalLimitSet[] OperationalLimitSet => GetAssoc1ToM<OperationalLimitSet>(nameof(OperationalLimitSet));

    public void AddToOperationalLimitSet(OperationalLimitSet assocObject) =>
        AddAssoc1ToM(nameof(OperationalLimitSet), assocObject);

    public void RemoveFromOperationalLimitSet(OperationalLimitSet assocObject) =>
        RemoveAssoc1ToM(nameof(OperationalLimitSet), assocObject);

    public void RemoveAllFromOperationalLimitSet() => RemoveAllAssocs1ToM(nameof(OperationalLimitSet));
}