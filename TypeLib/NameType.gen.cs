using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Тип наименования.
/// </summary>
[CimClass(ClassUri)]
public partial class NameType(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#NameType";

    /// <summary>
    /// Описатель типа наименования.
    /// </summary>
    public string? description
    {
        get => GetAttribute<string?>(nameof(description));
        set => SetAttribute(nameof(description), value);
    }

    /// <summary>
    /// Тип наименования.
    /// </summary>
    public string? name
    {
        get => GetAttribute<string?>(nameof(name));
        set => SetAttribute(nameof(name), value);
    }


    /// <summary>
    /// Наименование заданного типа.
    /// </summary>
    public Name[] Names => GetAssoc1ToM<Name>(nameof(Names));

    public void AddToNames(Name assocObject) => AddAssoc1ToM(nameof(Names), assocObject);
    public void RemoveFromNames(Name assocObject) => RemoveAssoc1ToM(nameof(Names), assocObject);
    public void RemoveAllFromNames() => RemoveAllAssocs1ToM(nameof(Names));
}