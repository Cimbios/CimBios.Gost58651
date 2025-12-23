using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Объект энергоснабжения (расположение).
/// </summary>
[CimClass(ClassUri)]
public partial class ServiceLocation(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Location(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ServiceLocation";

    /// <summary>
    /// Способ доступа обслуживающего лица к объекту энергоснабжения.
    /// </summary>
    public string? accessMethod
    {
        get => GetAttribute<string?>(nameof(accessMethod));
        set => SetAttribute(nameof(accessMethod), value);
    }

    /// <summary>
    /// TRUE, если требуется проверка оборудования в объекте энергоснабжения.
    /// </summary>
    public bool? needsInspection
    {
        get => GetAttribute<bool?>(nameof(needsInspection));
        set => SetAttribute(nameof(needsInspection), value);
    }

    /// <summary>
    /// Проблемы (недопуска к средствам измерений), с которыми ранее сталкивались при посещении или выполнении работ на объекте энергоснабжения.
    /// </summary>
    public string? siteAccessProblem
    {
        get => GetAttribute<string?>(nameof(siteAccessProblem));
        set => SetAttribute(nameof(siteAccessProblem), value);
    }


    /// <summary>
    /// Точки поставки, обслуживающие объект энергоснабжения.
    /// </summary>
    public UsagePoint[] UsagePoints => GetAssoc1ToM<UsagePoint>(nameof(UsagePoints));

    public void AddToUsagePoints(UsagePoint assocObject) => AddAssoc1ToM(nameof(UsagePoints), assocObject);
    public void RemoveFromUsagePoints(UsagePoint assocObject) => RemoveAssoc1ToM(nameof(UsagePoints), assocObject);
    public void RemoveAllFromUsagePoints() => RemoveAllAssocs1ToM(nameof(UsagePoints));
}