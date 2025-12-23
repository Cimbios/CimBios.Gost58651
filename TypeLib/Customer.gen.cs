using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Роль организации � покупатель электроэнергии.
/// </summary>
[CimClass(ClassUri)]
public partial class Customer(IOIDDescriptor oid, ICimMetaClass metaClass)
    : OrganisationRole(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Customer";

    /// <summary>
    /// Вид клиента.
    /// </summary>
    public CustomerKind? kind
    {
        get => GetAttribute<CustomerKind?>(nameof(kind));
        set => SetAttribute(nameof(kind), value);
    }

    /// <summary>
    /// Язык общения с клиентом.
    /// </summary>
    public string? locale
    {
        get => GetAttribute<string?>(nameof(locale));
        set => SetAttribute(nameof(locale), value);
    }

    /// <summary>
    /// Идентификационный номер органа исполнительной власти субъекта Российской Федерации в области государственного регулирования тарифов и цен (PUC).
    /// </summary>
    public string? pucNumber
    {
        get => GetAttribute<string?>(nameof(pucNumber));
        set => SetAttribute(nameof(pucNumber), value);
    }

    /// <summary>
    /// TRUE, если потребитель относится к категории потребителей, ограничение режима потребления электрической энергии (мощности) которого может привести к экономическим, экологическим, социальным последствиям, например жизнеобеспечение больницы.
    /// </summary>
    public string? specialNeed
    {
        get => GetAttribute<string?>(nameof(specialNeed));
        set => SetAttribute(nameof(specialNeed), value);
    }

    /// <summary>
    /// Состояние потребителя.
    /// </summary>
    public Status? status
    {
        get => GetAttribute<Status?>(nameof(status));
        set => SetAttribute(nameof(status), value);
    }

    /// <summary>
    /// TRUE, если потребитель относится к первой категории надежности электроснабжения.
    /// </summary>
    public bool? vip
    {
        get => GetAttribute<bool?>(nameof(vip));
        set => SetAttribute(nameof(vip), value);
    }


    /// <summary>
    /// Оконечные устройства клиента.
    /// </summary>
    public EndDevice[] EndDevices => GetAssoc1ToM<EndDevice>(nameof(EndDevices));

    public void AddToEndDevices(EndDevice assocObject) => AddAssoc1ToM(nameof(EndDevices), assocObject);
    public void RemoveFromEndDevices(EndDevice assocObject) => RemoveAssoc1ToM(nameof(EndDevices), assocObject);
    public void RemoveAllFromEndDevices() => RemoveAllAssocs1ToM(nameof(EndDevices));

    /// <summary>
    /// Все договоры с потребителем электрической энергии.
    /// </summary>
    public CustomerAgreement[] CustomerAgreements => GetAssoc1ToM<CustomerAgreement>(nameof(CustomerAgreements));

    public void AddToCustomerAgreements(CustomerAgreement assocObject) =>
        AddAssoc1ToM(nameof(CustomerAgreements), assocObject);

    public void RemoveFromCustomerAgreements(CustomerAgreement assocObject) =>
        RemoveAssoc1ToM(nameof(CustomerAgreements), assocObject);

    public void RemoveAllFromCustomerAgreements() => RemoveAllAssocs1ToM(nameof(CustomerAgreements));
}