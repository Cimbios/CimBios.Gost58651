using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Базовый класс для эксплуатационных ограничений/пределов.
/// </summary>
[CimClass(ClassUri)]
public partial class OperationalLimit(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#OperationalLimit";


    /// <summary>
    /// Набор эксплуатационных ограничений/пределов
    /// </summary>
    public OperationalLimitSet? OperationalLimitSet
    {
        get => GetAssoc1To1<OperationalLimitSet>(nameof(OperationalLimitSet));
        set => SetAssoc1To1(nameof(OperationalLimitSet), value);
    }

    /// <summary>
    /// Тип эксплуатационного ограничения/предела.
    /// </summary>
    public OperationalLimitType? OperationalLimitType
    {
        get => GetAssoc1To1<OperationalLimitType>(nameof(OperationalLimitType));
        set => SetAssoc1To1(nameof(OperationalLimitType), value);
    }

    /// <summary>
    /// Модель зависимости эксплуатационного ограничения/предела.
    /// </summary>
    public LimitDependency[] LimitDependencyModel => GetAssoc1ToM<LimitDependency>(nameof(LimitDependencyModel));

    public void AddToLimitDependencyModel(LimitDependency assocObject) =>
        AddAssoc1ToM(nameof(LimitDependencyModel), assocObject);

    public void RemoveFromLimitDependencyModel(LimitDependency assocObject) =>
        RemoveAssoc1ToM(nameof(LimitDependencyModel), assocObject);

    public void RemoveAllFromLimitDependencyModel() => RemoveAllAssocs1ToM(nameof(LimitDependencyModel));

    /// <summary>
    /// Пропорциональные зависимости других эксплуатационных пределов.
    /// </summary>
    public LimitScalingLimit[] LimitScalingLimit => GetAssoc1ToM<LimitScalingLimit>(nameof(LimitScalingLimit));

    public void AddToLimitScalingLimit(LimitScalingLimit assocObject) =>
        AddAssoc1ToM(nameof(LimitScalingLimit), assocObject);

    public void RemoveFromLimitScalingLimit(LimitScalingLimit assocObject) =>
        RemoveAssoc1ToM(nameof(LimitScalingLimit), assocObject);

    public void RemoveAllFromLimitScalingLimit() => RemoveAllAssocs1ToM(nameof(LimitScalingLimit));
}