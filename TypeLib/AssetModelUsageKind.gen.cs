using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Вид использования модели материального объекта.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#AssetModelUsageKind")]
public enum AssetModelUsageKind
{
    /// <summary>
    /// 
    /// </summary>
    customerSubstation,

    /// <summary>
    /// 
    /// </summary>
    distributionOverhead,

    /// <summary>
    /// 
    /// </summary>
    distributionUnderground,

    /// <summary>
    /// 
    /// </summary>
    other,

    /// <summary>
    /// 
    /// </summary>
    streetlight,

    /// <summary>
    /// 
    /// </summary>
    substation,

    /// <summary>
    /// 
    /// </summary>
    transmission,

    /// <summary>
    /// 
    /// </summary>
    unknown,
}