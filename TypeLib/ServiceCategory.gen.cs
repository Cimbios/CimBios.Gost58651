using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Категория услуги, предоставляемой заказчику.
/// </summary>
[CimClass(ClassUri)]
public partial class ServiceCategory(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ServiceCategory";

    /// <summary>
    /// Вид услуги.
    /// </summary>
    public ServiceKind? kind
    {
        get => GetAttribute<ServiceKind?>(nameof(kind));
        set => SetAttribute(nameof(kind), value);
    }


    /// <summary>
    /// Договоры, которыми предумотрена эта категория услуг.
    /// </summary>
    public CustomerAgreement[] CustomerAgreements => GetAssoc1ToM<CustomerAgreement>(nameof(CustomerAgreements));

    public void AddToCustomerAgreements(CustomerAgreement assocObject) =>
        AddAssoc1ToM(nameof(CustomerAgreements), assocObject);

    public void RemoveFromCustomerAgreements(CustomerAgreement assocObject) =>
        RemoveAssoc1ToM(nameof(CustomerAgreements), assocObject);

    public void RemoveAllFromCustomerAgreements() => RemoveAllAssocs1ToM(nameof(CustomerAgreements));

    /// <summary>
    /// Точки поставки, предоставляющие эту категорию услуг.
    /// </summary>
    public UsagePoint[] UsagePoints => GetAssoc1ToM<UsagePoint>(nameof(UsagePoints));

    public void AddToUsagePoints(UsagePoint assocObject) => AddAssoc1ToM(nameof(UsagePoints), assocObject);
    public void RemoveFromUsagePoints(UsagePoint assocObject) => RemoveAssoc1ToM(nameof(UsagePoints), assocObject);
    public void RemoveAllFromUsagePoints() => RemoveAllAssocs1ToM(nameof(UsagePoints));
}