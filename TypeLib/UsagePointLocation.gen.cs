using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Расположение точки учета.
/// </summary>
[CimClass(ClassUri)]
public partial class UsagePointLocation(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Location(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#UsagePointLocation";

    /// <summary>
    /// Способ доступа обслуживающего персонала к расположению точки поставки.
    /// </summary>
    public string? accessMethod
    {
        get => GetAttribute<string?>(nameof(accessMethod));
        set => SetAttribute(nameof(accessMethod), value);
    }

    /// <summary>
    /// Заметки о расположении точки поставки.
    /// </summary>
    public string? remark
    {
        get => GetAttribute<string?>(nameof(remark));
        set => SetAttribute(nameof(remark), value);
    }

    /// <summary>
    /// Проблемы (недопуска к средствам измерений), с которыми ранее сталкивались при посещении или выполнении работы в расположении точки поставки.
    /// </summary>
    public string? siteAccessProblem
    {
        get => GetAttribute<string?>(nameof(siteAccessProblem));
        set => SetAttribute(nameof(siteAccessProblem), value);
    }


    /// <summary>
    /// Точки учета, расположенные в данном месте.
    /// </summary>
    public UsagePoint[] UsagePoints => GetAssoc1ToM<UsagePoint>(nameof(UsagePoints));

    public void AddToUsagePoints(UsagePoint assocObject) => AddAssoc1ToM(nameof(UsagePoints), assocObject);
    public void RemoveFromUsagePoints(UsagePoint assocObject) => RemoveAssoc1ToM(nameof(UsagePoints), assocObject);
    public void RemoveAllFromUsagePoints() => RemoveAllAssocs1ToM(nameof(UsagePoints));
}