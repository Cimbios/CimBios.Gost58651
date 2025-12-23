using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Организация.
/// </summary>
[CimClass(ClassUri)]
public partial class Organisation(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Organisation";

    /// <summary>
    /// Электронный адрес.
    /// </summary>
    public ElectronicAddress? electronicAddress
    {
        get => GetAttribute<ElectronicAddress?>(nameof(electronicAddress));
        set => SetAttribute(nameof(electronicAddress), value);
    }

    /// <summary>
    /// Номер телефона.
    /// </summary>
    public TelephoneNumber? phone1
    {
        get => GetAttribute<TelephoneNumber?>(nameof(phone1));
        set => SetAttribute(nameof(phone1), value);
    }

    /// <summary>
    /// Дополнительный номер телефона.
    /// </summary>
    public TelephoneNumber? phone2
    {
        get => GetAttribute<TelephoneNumber?>(nameof(phone2));
        set => SetAttribute(nameof(phone2), value);
    }

    /// <summary>
    /// Почтовый адрес, потенциально отличный от streetAddress (например, другой город).
    /// </summary>
    public StreetAddress? postalAddress
    {
        get => GetAttribute<StreetAddress?>(nameof(postalAddress));
        set => SetAttribute(nameof(postalAddress), value);
    }

    /// <summary>
    /// Адрес улицы.
    /// </summary>
    public StreetAddress? streetAddress
    {
        get => GetAttribute<StreetAddress?>(nameof(streetAddress));
        set => SetAttribute(nameof(streetAddress), value);
    }

    /// <summary>
    /// Вышестоящая организация, филиал.
    /// </summary>
    public Organisation? ParentOrganisation
    {
        get => GetAssoc1To1<Organisation>(nameof(ParentOrganisation));
        set => SetAssoc1To1(nameof(ParentOrganisation), value);
    }

    /// <summary>
    /// Дочерние и зависимые организации, филиалы.
    /// </summary>
    public Organisation[] ChildOrganisations => GetAssoc1ToM<Organisation>(nameof(ChildOrganisations));

    public void AddToChildOrganisations(Organisation assocObject) =>
        AddAssoc1ToM(nameof(ChildOrganisations), assocObject);

    public void RemoveFromChildOrganisations(Organisation assocObject) =>
        RemoveAssoc1ToM(nameof(ChildOrganisations), assocObject);

    public void RemoveAllFromChildOrganisations() => RemoveAllAssocs1ToM(nameof(ChildOrganisations));

    /// <summary>
    /// Роли, выполняемые организацией.
    /// </summary>
    public OrganisationRole[] Roles => GetAssoc1ToM<OrganisationRole>(nameof(Roles));

    public void AddToRoles(OrganisationRole assocObject) => AddAssoc1ToM(nameof(Roles), assocObject);
    public void RemoveFromRoles(OrganisationRole assocObject) => RemoveAssoc1ToM(nameof(Roles), assocObject);
    public void RemoveAllFromRoles() => RemoveAllAssocs1ToM(nameof(Roles));
}