using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Вид функции конечного устройства.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#EndDeviceFunctionKind")]
public enum EndDeviceFunctionKind
{
    /// <summary>
    /// 
    /// </summary>
    autonomousDst,

    /// <summary>
    /// 
    /// </summary>
    demandResponse,

    /// <summary>
    /// 
    /// </summary>
    electricMetering,

    /// <summary>
    /// 
    /// </summary>
    gasMetering,

    /// <summary>
    /// 
    /// </summary>
    metrology,

    /// <summary>
    /// 
    /// </summary>
    onRequestRead,

    /// <summary>
    /// 
    /// </summary>
    outageHistory,

    /// <summary>
    /// 
    /// </summary>
    relaysProgramming,

    /// <summary>
    /// 
    /// </summary>
    reverseFlow,

    /// <summary>
    /// 
    /// </summary>
    waterMetering,
}