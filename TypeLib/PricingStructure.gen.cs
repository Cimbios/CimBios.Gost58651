using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Группировка компонентов ценообразования и цен, используемых при создании клиентских сборов, а также критерии приемлемости, в соответствии с которыми эти условия могут быть предложены клиенту.
/// </summary>
[CimClass(ClassUri)]
public partial class PricingStructure(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Document(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PricingStructure";

    /// <summary>
    /// Уникальный пользовательский ключ для ценовой структуры, используемый представителями компании для определения правильной ценовой структуры для распределения клиенту.
    /// </summary>
    public string? code
    {
        get => GetAttribute<string?>(nameof(code));
        set => SetAttribute(nameof(code), value);
    }


    /// <summary>
    /// Точки поставки для этой ценовой структуры.
    /// </summary>
    public UsagePoint[] UsagePoints => GetAssoc1ToM<UsagePoint>(nameof(UsagePoints));

    public void AddToUsagePoints(UsagePoint assocObject) => AddAssoc1ToM(nameof(UsagePoints), assocObject);
    public void RemoveFromUsagePoints(UsagePoint assocObject) => RemoveAssoc1ToM(nameof(UsagePoints), assocObject);
    public void RemoveAllFromUsagePoints() => RemoveAllAssocs1ToM(nameof(UsagePoints));
}