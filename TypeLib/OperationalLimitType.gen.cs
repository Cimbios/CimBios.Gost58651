using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Тип эксплуатационного ограничения/предела.
/// </summary>
[CimClass(ClassUri)]
public partial class OperationalLimitType(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#OperationalLimitType";

    /// <summary>
    /// Допустимая длительность нарушения эксплуатационного ограничения/предела, с.
    /// </summary>
    public float? acceptableDuration
    {
        get => GetAttribute<float?>(nameof(acceptableDuration));
        set => SetAttribute(nameof(acceptableDuration), value);
    }

    /// <summary>
    /// Направление нарушения эксплуатационного ограничения/предела.
    /// </summary>
    public OperationalLimitDirectionKind? direction
    {
        get => GetAttribute<OperationalLimitDirectionKind?>(nameof(direction));
        set => SetAttribute(nameof(direction), value);
    }


    /// <summary>
    /// Эксплуатационные ограничения/пределы данного типа.
    /// </summary>
    public OperationalLimit[] OperationalLimit => GetAssoc1ToM<OperationalLimit>(nameof(OperationalLimit));

    public void AddToOperationalLimit(OperationalLimit assocObject) =>
        AddAssoc1ToM(nameof(OperationalLimit), assocObject);

    public void RemoveFromOperationalLimit(OperationalLimit assocObject) =>
        RemoveAssoc1ToM(nameof(OperationalLimit), assocObject);

    public void RemoveAllFromOperationalLimit() => RemoveAllAssocs1ToM(nameof(OperationalLimit));
}