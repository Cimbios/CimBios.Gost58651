using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Роль организации � поставщик услуг по передаче электрической энергии.
/// </summary>
[CimClass(ClassUri)]
public partial class ServiceSupplier(IOIDDescriptor oid, ICimMetaClass metaClass)
    : OrganisationRole(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ServiceSupplier";

    /// <summary>
    /// Уникальный ссылочный префиксный номер транзакции, выдаваемый организации Международной организацией по стандартизации с целью добавления тегов к электронным финансовым транзакциям (см. [2] и [3]).
    /// </summary>
    public string? issuerIdentificationNumber
    {
        get => GetAttribute<string?>(nameof(issuerIdentificationNumber));
        set => SetAttribute(nameof(issuerIdentificationNumber), value);
    }

    /// <summary>
    /// Вид поставщика.
    /// </summary>
    public SupplierKind? kind
    {
        get => GetAttribute<SupplierKind?>(nameof(kind));
        set => SetAttribute(nameof(kind), value);
    }


    /// <summary>
    /// Точки поставки, используемые поставщиком услуг.
    /// </summary>
    public UsagePoint[] UsagePoints => GetAssoc1ToM<UsagePoint>(nameof(UsagePoints));

    public void AddToUsagePoints(UsagePoint assocObject) => AddAssoc1ToM(nameof(UsagePoints), assocObject);
    public void RemoveFromUsagePoints(UsagePoint assocObject) => RemoveAssoc1ToM(nameof(UsagePoints), assocObject);
    public void RemoveAllFromUsagePoints() => RemoveAllAssocs1ToM(nameof(UsagePoints));
}