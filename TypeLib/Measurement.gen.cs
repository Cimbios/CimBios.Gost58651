using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Измеряемый параметр.
/// </summary>
[CimClass(ClassUri)]
public partial class Measurement(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#Measurement";

    /// <summary>
    /// Тип измерения.
    /// </summary>
    public string? measurementType
    {
        get => GetAttribute<string?>(nameof(measurementType));
        set => SetAttribute(nameof(measurementType), value);
    }

    /// <summary>
    /// Фазы измерения.
    /// </summary>
    public PhaseCode? phases
    {
        get => GetAttribute<PhaseCode?>(nameof(phases));
        set => SetAttribute(nameof(phases), value);
    }

    /// <summary>
    /// Множитель измерения.
    /// </summary>
    public UnitMultiplier? unitMultiplier
    {
        get => GetAttribute<UnitMultiplier?>(nameof(unitMultiplier));
        set => SetAttribute(nameof(unitMultiplier), value);
    }

    /// <summary>
    /// Единица измерения.
    /// </summary>
    public UnitSymbol? unitSymbol
    {
        get => GetAttribute<UnitSymbol?>(nameof(unitSymbol));
        set => SetAttribute(nameof(unitSymbol), value);
    }

    /// <summary>
    /// Полюс электропроводящего оборудования, к которому относится измеряемый параметр.
    /// </summary>
    public ACDCTerminal? Terminal
    {
        get => GetAssoc1To1<ACDCTerminal>(nameof(Terminal));
        set => SetAssoc1To1(nameof(Terminal), value);
    }

    /// <summary>
    /// Обобщенный объект энергосистемы, к которому относится измеряемый параметр.
    /// </summary>
    public PowerSystemResource? PowerSystemResource
    {
        get => GetAssoc1To1<PowerSystemResource>(nameof(PowerSystemResource));
        set => SetAssoc1To1(nameof(PowerSystemResource), value);
    }
}