using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Обозначение фаз.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#SinglePhaseKind")]
public enum SinglePhaseKind
{
    /// <summary>
    /// 
    /// </summary>
    A,

    /// <summary>
    /// 
    /// </summary>
    B,

    /// <summary>
    /// 
    /// </summary>
    C,

    /// <summary>
    /// 
    /// </summary>
    N,
}