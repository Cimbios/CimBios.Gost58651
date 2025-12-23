using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Электронный адрес.
/// </summary>
[CimClass(ClassUri)]
public partial class ElectronicAddress(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ElectronicAddress";

    /// <summary>
    /// Почтовый адрес 1.
    /// </summary>
    public string? email1
    {
        get => GetAttribute<string?>(nameof(email1));
        set => SetAttribute(nameof(email1), value);
    }

    /// <summary>
    /// Почтовый адрес 2.
    /// </summary>
    public string? email2
    {
        get => GetAttribute<string?>(nameof(email2));
        set => SetAttribute(nameof(email2), value);
    }

    /// <summary>
    /// Адрес сети.
    /// </summary>
    public string? lan
    {
        get => GetAttribute<string?>(nameof(lan));
        set => SetAttribute(nameof(lan), value);
    }

    /// <summary>
    /// MAC (Media Access Control) адрес.
    /// </summary>
    public string? mac
    {
        get => GetAttribute<string?>(nameof(mac));
        set => SetAttribute(nameof(mac), value);
    }

    /// <summary>
    /// Пароль.
    /// </summary>
    public string? password
    {
        get => GetAttribute<string?>(nameof(password));
        set => SetAttribute(nameof(password), value);
    }

    /// <summary>
    /// Радио адрес.
    /// </summary>
    public string? radio
    {
        get => GetAttribute<string?>(nameof(radio));
        set => SetAttribute(nameof(radio), value);
    }

    /// <summary>
    /// Идентификатор.
    /// </summary>
    public string? userID
    {
        get => GetAttribute<string?>(nameof(userID));
        set => SetAttribute(nameof(userID), value);
    }

    /// <summary>
    /// Интернет адрес.
    /// </summary>
    public string? web
    {
        get => GetAttribute<string?>(nameof(web));
        set => SetAttribute(nameof(web), value);
    }
}