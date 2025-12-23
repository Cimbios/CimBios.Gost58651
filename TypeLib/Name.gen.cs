using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Типизированное дополнительное наименование.
/// </summary>
[CimClass(ClassUri)]
public partial class Name(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Name";

    /// <summary>
    /// Типизированное дополнительное наименование объекта информационной модели.
    /// </summary>
    public string? name
    {
        get => GetAttribute<string?>(nameof(name));
        set => SetAttribute(nameof(name), value);
    }

    /// <summary>
    /// Объект, имеющий типизированное наименование
    /// </summary>
    public IdentifiedObject? IdentifiedObject
    {
        get => GetAssoc1To1<IdentifiedObject>(nameof(IdentifiedObject));
        set => SetAssoc1To1(nameof(IdentifiedObject), value);
    }

    /// <summary>
    /// Тип наименования.
    /// </summary>
    public NameType? NameType
    {
        get => GetAssoc1To1<NameType>(nameof(NameType));
        set => SetAssoc1To1(nameof(NameType), value);
    }
}