using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Ячейка распределительного устройства.
/// </summary>
[CimClass(ClassUri)]
public partial class Bay(IOIDDescriptor oid, ICimMetaClass metaClass)
    : EquipmentContainer(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Bay";

    /// <summary>
    /// Конфигурация соединения выключателей.
    /// </summary>
    public BreakerConfiguration? breakerConfiguration
    {
        get => GetAttribute<BreakerConfiguration?>(nameof(breakerConfiguration));
        set => SetAttribute(nameof(breakerConfiguration), value);
    }

    /// <summary>
    /// Конфигурация шин присоединения.
    /// </summary>
    public BusbarConfiguration? busBarConfiguration
    {
        get => GetAttribute<BusbarConfiguration?>(nameof(busBarConfiguration));
        set => SetAttribute(nameof(busBarConfiguration), value);
    }

    /// <summary>
    /// Распределительное устройство, к которому относится присоединение.
    /// </summary>
    public VoltageLevel? VoltageLevel
    {
        get => GetAssoc1To1<VoltageLevel>(nameof(VoltageLevel));
        set => SetAssoc1To1(nameof(VoltageLevel), value);
    }
}