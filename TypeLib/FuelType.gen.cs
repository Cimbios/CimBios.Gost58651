using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Вид органического топлива.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#FuelType")]
public enum FuelType
{
    /// <summary>
    /// 
    /// </summary>
    coal,

    /// <summary>
    /// 
    /// </summary>
    gas,

    /// <summary>
    /// 
    /// </summary>
    hardCoal,

    /// <summary>
    /// 
    /// </summary>
    lignite,

    /// <summary>
    /// 
    /// </summary>
    oil,

    /// <summary>
    /// 
    /// </summary>
    oilShale,

    /// <summary>
    /// 
    /// </summary>
    peat,

    /// <summary>
    /// 
    /// </summary>
    other,
}