using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Договор с потребителем электрической энергии.
/// </summary>
[CimClass(ClassUri)]
public partial class CustomerAgreement(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Agreement(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#CustomerAgreement";

    /// <summary>
    /// Код управления нагрузкой.
    /// </summary>
    public string? loadMgmt
    {
        get => GetAttribute<string?>(nameof(loadMgmt));
        set => SetAttribute(nameof(loadMgmt), value);
    }

    /// <summary>
    /// Потребитель электроэнергии, к которому относится соглашение.
    /// </summary>
    public Customer? Customer
    {
        get => GetAssoc1To1<Customer>(nameof(Customer));
        set => SetAssoc1To1(nameof(Customer), value);
    }

    /// <summary>
    /// Категория услуг по договору.
    /// </summary>
    public ServiceCategory? ServiceCategory
    {
        get => GetAssoc1To1<ServiceCategory>(nameof(ServiceCategory));
        set => SetAssoc1To1(nameof(ServiceCategory), value);
    }

    /// <summary>
    /// Точки поставки, относящиеся к договору с потребителем.
    /// </summary>
    public UsagePoint[] UsagePoints => GetAssoc1ToM<UsagePoint>(nameof(UsagePoints));

    public void AddToUsagePoints(UsagePoint assocObject) => AddAssoc1ToM(nameof(UsagePoints), assocObject);
    public void RemoveFromUsagePoints(UsagePoint assocObject) => RemoveAssoc1ToM(nameof(UsagePoints), assocObject);
    public void RemoveAllFromUsagePoints() => RemoveAllAssocs1ToM(nameof(UsagePoints));
}