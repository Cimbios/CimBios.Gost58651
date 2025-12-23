using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Вид корпоративного стандарта.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#CorporateStandardKind")]
public enum CorporateStandardKind
{
    /// <summary>
    /// 
    /// </summary>
    experimental,

    /// <summary>
    /// 
    /// </summary>
    other,

    /// <summary>
    /// 
    /// </summary>
    standard,

    /// <summary>
    /// 
    /// </summary>
    underEvaluation,
}