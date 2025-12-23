using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Типизированная роль организации по отношению к другим объектам информационной модели.
/// </summary>
[CimClass(ClassUri)]
public partial class OrganisationRole(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#OrganisationRole";


    /// <summary>
    /// Организации, имеющие заданную роль.
    /// </summary>
    public Organisation? Organisation
    {
        get => GetAssoc1To1<Organisation>(nameof(Organisation));
        set => SetAssoc1To1(nameof(Organisation), value);
    }

    /// <summary>
    /// События конфигурирования роли организации.
    /// </summary>
    public ConfigurationEvent[] ConfigurationEvents => GetAssoc1ToM<ConfigurationEvent>(nameof(ConfigurationEvents));

    public void AddToConfigurationEvents(ConfigurationEvent assocObject) =>
        AddAssoc1ToM(nameof(ConfigurationEvents), assocObject);

    public void RemoveFromConfigurationEvents(ConfigurationEvent assocObject) =>
        RemoveAssoc1ToM(nameof(ConfigurationEvents), assocObject);

    public void RemoveAllFromConfigurationEvents() => RemoveAllAssocs1ToM(nameof(ConfigurationEvents));

    /// <summary>
    /// Объекты информационной модели, связанные с ролью организации.
    /// </summary>
    public IdentifiedObject[] Objects => GetAssoc1ToM<IdentifiedObject>(nameof(Objects));

    public void AddToObjects(IdentifiedObject assocObject) => AddAssoc1ToM(nameof(Objects), assocObject);
    public void RemoveFromObjects(IdentifiedObject assocObject) => RemoveAssoc1ToM(nameof(Objects), assocObject);
    public void RemoveAllFromObjects() => RemoveAllAssocs1ToM(nameof(Objects));
}