using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Вид коэффициента услуг.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#ServiceMultiplierKind")]
public enum ServiceMultiplierKind
{
    /// <summary>
    /// 
    /// </summary>
    ctRatio,

    /// <summary>
    /// 
    /// </summary>
    ptRatio,

    /// <summary>
    /// 
    /// </summary>
    transformerRatio,
}