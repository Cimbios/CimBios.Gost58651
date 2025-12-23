using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Приставки кратности-дольности для единиц измерения.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#UnitMultiplier")]
public enum UnitMultiplier
{
    /// <summary>
    /// 
    /// </summary>
    k,

    /// <summary>
    /// 
    /// </summary>
    none,

    /// <summary>
    /// 
    /// </summary>
    micro,

    /// <summary>
    /// 
    /// </summary>
    m,

    /// <summary>
    /// 
    /// </summary>
    M,
}