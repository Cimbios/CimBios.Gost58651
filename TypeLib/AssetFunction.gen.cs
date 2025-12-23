using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Функция, выполняемая материальным объектом.
/// </summary>
[CimClass(ClassUri)]
public partial class AssetFunction(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#AssetFunction";

    /// <summary>
    /// Конфигурация, указанная для функции.
    /// </summary>
    public string? configID
    {
        get => GetAttribute<string?>(nameof(configID));
        set => SetAttribute(nameof(configID), value);
    }

    /// <summary>
    /// Версия прошивки устройства.
    /// </summary>
    public string? firmwareID
    {
        get => GetAttribute<string?>(nameof(firmwareID));
        set => SetAttribute(nameof(firmwareID), value);
    }

    /// <summary>
    /// Аппаратная версия устройства.
    /// </summary>
    public string? hardwareID
    {
        get => GetAttribute<string?>(nameof(hardwareID));
        set => SetAttribute(nameof(hardwareID), value);
    }

    /// <summary>
    /// Пароль, необходимый для доступа к функции.
    /// </summary>
    public string? password
    {
        get => GetAttribute<string?>(nameof(password));
        set => SetAttribute(nameof(password), value);
    }

    /// <summary>
    /// Название программы.
    /// </summary>
    public string? programID
    {
        get => GetAttribute<string?>(nameof(programID));
        set => SetAttribute(nameof(programID), value);
    }
}