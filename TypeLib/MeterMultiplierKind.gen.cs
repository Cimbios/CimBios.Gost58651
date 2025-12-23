using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Вид коэффициента прибора учета.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#MeterMultiplierKind")]
public enum MeterMultiplierKind
{
    /// <summary>
    /// 
    /// </summary>
    ctRatio,

    /// <summary>
    /// 
    /// </summary>
    kE,

    /// <summary>
    /// 
    /// </summary>
    kH,

    /// <summary>
    /// 
    /// </summary>
    kR,

    /// <summary>
    /// 
    /// </summary>
    ptRatio,

    /// <summary>
    /// 
    /// </summary>
    transformerRatio,
}