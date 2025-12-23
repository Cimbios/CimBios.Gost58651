using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Тип охлаждения.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#CoolingKind")]
public enum CoolingKind
{
    /// <summary>
    /// 
    /// </summary>
    selfCooling,

    /// <summary>
    /// 
    /// </summary>
    forcedAir,

    /// <summary>
    /// 
    /// </summary>
    forcedOilAndAir,

    /// <summary>
    /// 
    /// </summary>
    forcedOil,

    /// <summary>
    /// 
    /// </summary>
    forcedOilAndWater,

    /// <summary>
    /// 
    /// </summary>
    other,
}