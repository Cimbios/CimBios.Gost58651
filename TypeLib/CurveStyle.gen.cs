using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Тип отображения кривой.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#CurveStyle")]
public enum CurveStyle
{
    /// <summary>
    /// 
    /// </summary>
    constantYValue,

    /// <summary>
    /// 
    /// </summary>
    straightLineYValues,
}