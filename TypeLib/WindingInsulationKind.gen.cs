using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Тип изоляции обмотки.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#WindingInsulationKind")]
public enum WindingInsulationKind
{
    /// <summary>
    /// 
    /// </summary>
    paper,

    /// <summary>
    /// 
    /// </summary>
    nomex,

    /// <summary>
    /// 
    /// </summary>
    other,
}