using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Система автоматического регулирования.
/// </summary>
[CimClass(ClassUri)]
public partial class RegulatingControl(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PowerSystemResource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#RegulatingControl";

    /// <summary>
    /// Регулятор выключен (если присвоено значение &#171;Ложь&#187;; по умолчанию &#171;включен&#187;).
    /// </summary>
    public bool? enabled
    {
        get => GetAttribute<bool?>(nameof(enabled));
        set => SetAttribute(nameof(enabled), value);
    }

    /// <summary>
    /// Режим регулирования из заданного списка.
    /// </summary>
    public RegulatingControlModeKind? mode
    {
        get => GetAttribute<RegulatingControlModeKind?>(nameof(mode));
        set => SetAttribute(nameof(mode), value);
    }

    /// <summary>
    /// Полюс оборудования, с которым ассоциируется система автоматического регулирования.
    /// </summary>
    public Terminal? Terminal
    {
        get => GetAssoc1To1<Terminal>(nameof(Terminal));
        set => SetAssoc1To1(nameof(Terminal), value);
    }

    /// <summary>
    /// Оборудование, к которому относится система автоматического регулирования.
    /// </summary>
    public RegulatingCondEq[] RegulatingCondEq => GetAssoc1ToM<RegulatingCondEq>(nameof(RegulatingCondEq));

    public void AddToRegulatingCondEq(RegulatingCondEq assocObject) =>
        AddAssoc1ToM(nameof(RegulatingCondEq), assocObject);

    public void RemoveFromRegulatingCondEq(RegulatingCondEq assocObject) =>
        RemoveAssoc1ToM(nameof(RegulatingCondEq), assocObject);

    public void RemoveAllFromRegulatingCondEq() => RemoveAllAssocs1ToM(nameof(RegulatingCondEq));
}