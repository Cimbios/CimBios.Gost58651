using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Тип гидротурбины.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#HydroTurbineKind")]
public enum HydroTurbineKind
{
    /// <summary>
    /// 
    /// </summary>
    francis,

    /// <summary>
    /// 
    /// </summary>
    kaplan,

    /// <summary>
    /// 
    /// </summary>
    pelton,

    /// <summary>
    /// 
    /// </summary>
    kaplanRBdiagonal,

    /// <summary>
    /// 
    /// </summary>
    francisReversible,

    /// <summary>
    /// 
    /// </summary>
    kaplanRB,

    /// <summary>
    /// 
    /// </summary>
    horizontalRB,

    /// <summary>
    /// 
    /// </summary>
    orthogonal,
}