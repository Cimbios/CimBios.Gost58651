using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Тип охлаждающего агента.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#CoolantType")]
public enum CoolantType
{
    /// <summary>
    /// 
    /// </summary>
    air,

    /// <summary>
    /// 
    /// </summary>
    hydrogenGas,

    /// <summary>
    /// 
    /// </summary>
    water,
}