using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Тип проводника кабеля.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#CableConstructionKind")]
public enum CableConstructionKind
{
    /// <summary>
    /// 
    /// </summary>
    compacted,

    /// <summary>
    /// 
    /// </summary>
    compressed,

    /// <summary>
    /// 
    /// </summary>
    sector,

    /// <summary>
    /// 
    /// </summary>
    segmental,

    /// <summary>
    /// 
    /// </summary>
    solid,

    /// <summary>
    /// 
    /// </summary>
    stranded,

    /// <summary>
    /// 
    /// </summary>
    other,
}