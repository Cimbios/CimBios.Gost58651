using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Типы регулирования.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#RegulatingControlModeKind")]
public enum RegulatingControlModeKind
{
    /// <summary>
    /// 
    /// </summary>
    activePower,

    /// <summary>
    /// 
    /// </summary>
    admittance,

    /// <summary>
    /// 
    /// </summary>
    currentFlow,

    /// <summary>
    /// 
    /// </summary>
    powerFactor,

    /// <summary>
    /// 
    /// </summary>
    reactivePower,

    /// <summary>
    /// 
    /// </summary>
    temperature,

    /// <summary>
    /// 
    /// </summary>
    timeScheduled,

    /// <summary>
    /// 
    /// </summary>
    voltage,
}