using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Тип конструкции КЛ.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#UndergroundStructureKind")]
public enum UndergroundStructureKind
{
    /// <summary>
    /// 
    /// </summary>
    burd,

    /// <summary>
    /// 
    /// </summary>
    enclosure,

    /// <summary>
    /// 
    /// </summary>
    manhole,

    /// <summary>
    /// 
    /// </summary>
    pad,

    /// <summary>
    /// 
    /// </summary>
    subsurfaceEnclosure,

    /// <summary>
    /// 
    /// </summary>
    trench,

    /// <summary>
    /// 
    /// </summary>
    tunnel,

    /// <summary>
    /// 
    /// </summary>
    vault,

    /// <summary>
    /// 
    /// </summary>
    pullbox,
}