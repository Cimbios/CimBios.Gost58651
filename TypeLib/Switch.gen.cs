using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Коммутационный аппарат.
/// </summary>
[CimClass(ClassUri)]
public partial class Switch(IOIDDescriptor oid, ICimMetaClass metaClass)
    : ConductingEquipment(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Switch";

    /// <summary>
    /// Разновременность замыкания контактов полюсов выключателя (только для выключателей с типом привода &#171;пофазный&#187;), с.
    /// </summary>
    public float? differenceInTransitTime
    {
        get => GetAttribute<float?>(nameof(differenceInTransitTime));
        set => SetAttribute(nameof(differenceInTransitTime), value);
    }

    /// <summary>
    /// Если присвоено значение &#171;Истина&#187;, нормальное состояние &#171;Отключено&#187;.
    /// </summary>
    public bool? normalOpen
    {
        get => GetAttribute<bool?>(nameof(normalOpen));
        set => SetAttribute(nameof(normalOpen), value);
    }

    /// <summary>
    /// Номинальный ток, А.
    /// </summary>
    public float? ratedCurrent
    {
        get => GetAttribute<float?>(nameof(ratedCurrent));
        set => SetAttribute(nameof(ratedCurrent), value);
    }
}