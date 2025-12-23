using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Тип оболочки кабеля.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#CableOuterJacketKind")]
public enum CableOuterJacketKind
{
    /// <summary>
    /// 
    /// </summary>
    none,

    /// <summary>
    /// 
    /// </summary>
    linearLowDensityPolyethylene,

    /// <summary>
    /// 
    /// </summary>
    pvc,

    /// <summary>
    /// 
    /// </summary>
    polyethylene,

    /// <summary>
    /// 
    /// </summary>
    insulating,

    /// <summary>
    /// 
    /// </summary>
    semiconducting,

    /// <summary>
    /// 
    /// </summary>
    other,
}