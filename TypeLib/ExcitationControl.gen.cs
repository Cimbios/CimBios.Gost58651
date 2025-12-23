using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Автоматический регулятор возбуждения.
/// </summary>
[CimClass(ClassUri)]
public partial class ExcitationControl(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Equipment(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#ExcitationControl";

    /// <summary>
    /// Тип системного стабилизатора.
    /// </summary>
    public string? stabilizerType
    {
        get => GetAttribute<string?>(nameof(stabilizerType));
        set => SetAttribute(nameof(stabilizerType), value);
    }

    /// <summary>
    /// Тип регулятора напряжения.
    /// </summary>
    public string? voltageControlType
    {
        get => GetAttribute<string?>(nameof(voltageControlType));
        set => SetAttribute(nameof(voltageControlType), value);
    }

    /// <summary>
    /// Система возбуждения.
    /// </summary>
    public ExcitationSystem? ExcitationSystem
    {
        get => GetAssoc1To1<ExcitationSystem>(nameof(ExcitationSystem));
        set => SetAssoc1To1(nameof(ExcitationSystem), value);
    }
}