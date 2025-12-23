using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Документ.
/// </summary>
[CimClass(ClassUri)]
public partial class Document(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Document";

    /// <summary>
    /// Дата и время создания документа.
    /// </summary>
    public DateTime? createdDateTime
    {
        get => GetAttribute<DateTime?>(nameof(createdDateTime));
        set => SetAttribute(nameof(createdDateTime), value);
    }

    /// <summary>
    /// Электронный адрес документа.
    /// </summary>
    public ElectronicAddress? electronicAddress
    {
        get => GetAttribute<ElectronicAddress?>(nameof(electronicAddress));
        set => SetAttribute(nameof(electronicAddress), value);
    }

    /// <summary>
    /// Дата и время последнего изменения документа.
    /// </summary>
    public DateTime? lastModifiedDateTime
    {
        get => GetAttribute<DateTime?>(nameof(lastModifiedDateTime));
        set => SetAttribute(nameof(lastModifiedDateTime), value);
    }


    /// <summary>
    /// События конфигурирования документа.
    /// </summary>
    public ConfigurationEvent[] ConfigurationEvents => GetAssoc1ToM<ConfigurationEvent>(nameof(ConfigurationEvents));

    public void AddToConfigurationEvents(ConfigurationEvent assocObject) =>
        AddAssoc1ToM(nameof(ConfigurationEvents), assocObject);

    public void RemoveFromConfigurationEvents(ConfigurationEvent assocObject) =>
        RemoveAssoc1ToM(nameof(ConfigurationEvents), assocObject);

    public void RemoveAllFromConfigurationEvents() => RemoveAllAssocs1ToM(nameof(ConfigurationEvents));
}