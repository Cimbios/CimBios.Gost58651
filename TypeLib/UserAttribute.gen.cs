using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// 
/// </summary>
[CimClass(ClassUri)]
public partial class UserAttribute(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#UserAttribute";

    /// <summary>
    /// Наименование атрибута.
    /// </summary>
    public string? name
    {
        get => GetAttribute<string?>(nameof(name));
        set => SetAttribute(nameof(name), value);
    }

    /// <summary>
    /// Порядковый номер атрибута в списке атрибутов.
    /// </summary>
    public int? sequenceNumber
    {
        get => GetAttribute<int?>(nameof(sequenceNumber));
        set => SetAttribute(nameof(sequenceNumber), value);
    }

    /// <summary>
    /// Значение атрибута.
    /// </summary>
    public StringQuantity? value
    {
        get => GetAttribute<StringQuantity?>(nameof(value));
        set => SetAttribute(nameof(value), value);
    }

    /// <summary>
    /// Объект, использующий специализированный атрибут.
    /// </summary>
    public IdentifiedObject? Object
    {
        get => GetAssoc1To1<IdentifiedObject>(nameof(Object));
        set => SetAssoc1To1(nameof(Object), value);
    }
}