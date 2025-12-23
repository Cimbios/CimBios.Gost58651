using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Конфигурация шины присоединения.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#BusbarConfiguration")]
public enum BusbarConfiguration
{
    /// <summary>
    /// 
    /// </summary>
    doubleBus,

    /// <summary>
    /// 
    /// </summary>
    mainWithTransfer,

    /// <summary>
    /// 
    /// </summary>
    ringBus,

    /// <summary>
    /// 
    /// </summary>
    singleBus,

    /// <summary>
    /// 
    /// </summary>
    doubleMainWithTransfer,

    /// <summary>
    /// 
    /// </summary>
    noBus,
}