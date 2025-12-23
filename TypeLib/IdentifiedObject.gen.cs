using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Идентифицирующий  класс � обеспечивает идентификацию и набор наименований для наследуемых классов.
/// </summary>
[CimClass(ClassUri)]
public partial class IdentifiedObject(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#IdentifiedObject";

    /// <summary>
    /// Дополнительное наименование идентифицируемого объекта.
    /// </summary>
    public string? aliasName
    {
        get => GetAttribute<string?>(nameof(aliasName));
        set => SetAttribute(nameof(aliasName), value);
    }

    /// <summary>
    /// Описание объекта информационной модели.
    /// </summary>
    public string? description
    {
        get => GetAttribute<string?>(nameof(description));
        set => SetAttribute(nameof(description), value);
    }
    
    /// <summary>
    /// Наименование объекта информационной модели.
    /// </summary>
    public string? name
    {
        get => GetAttribute<string?>(nameof(name));
        set => SetAttribute(nameof(name), value);
    }


    /// <summary>
    /// Роли организаций по отношению к объекту информационной модели.
    /// </summary>
    public OrganisationRole[] OrganisationRoles => GetAssoc1ToM<OrganisationRole>(nameof(OrganisationRoles));

    public void AddToOrganisationRoles(OrganisationRole assocObject) =>
        AddAssoc1ToM(nameof(OrganisationRoles), assocObject);

    public void RemoveFromOrganisationRoles(OrganisationRole assocObject) =>
        RemoveAssoc1ToM(nameof(OrganisationRoles), assocObject);

    public void RemoveAllFromOrganisationRoles() => RemoveAllAssocs1ToM(nameof(OrganisationRoles));

    /// <summary>
    /// Набор специализированных атрибутов.
    /// </summary>
    public UserAttribute[] CustomAttributes => GetAssoc1ToM<UserAttribute>(nameof(CustomAttributes));

    public void AddToCustomAttributes(UserAttribute assocObject) => AddAssoc1ToM(nameof(CustomAttributes), assocObject);

    public void RemoveFromCustomAttributes(UserAttribute assocObject) =>
        RemoveAssoc1ToM(nameof(CustomAttributes), assocObject);

    public void RemoveAllFromCustomAttributes() => RemoveAllAssocs1ToM(nameof(CustomAttributes));

    /// <summary>
    /// Набор типизированных наименований.
    /// </summary>
    public Name[] Names => GetAssoc1ToM<Name>(nameof(Names));

    public void AddToNames(Name assocObject) => AddAssoc1ToM(nameof(Names), assocObject);
    public void RemoveFromNames(Name assocObject) => RemoveAssoc1ToM(nameof(Names), assocObject);
    public void RemoveAllFromNames() => RemoveAllAssocs1ToM(nameof(Names));
}