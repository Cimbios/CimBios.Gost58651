using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Тип присоединения.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#BreakerConfiguration")]
public enum BreakerConfiguration
{
    /// <summary>
    /// 
    /// </summary>
    breakerAndAHalf,

    /// <summary>
    /// 
    /// </summary>
    doubleBreaker,

    /// <summary>
    /// 
    /// </summary>
    groundSwitchWithDisconnector,

    /// <summary>
    /// 
    /// </summary>
    noBreaker,

    /// <summary>
    /// 
    /// </summary>
    singleBreaker,
}