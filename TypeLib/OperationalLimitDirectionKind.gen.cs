using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Вид эксплуатационного ограничения/предела.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#OperationalLimitDirectionKind")]
public enum OperationalLimitDirectionKind
{
    /// <summary>
    /// 
    /// </summary>
    absoluteValue,

    /// <summary>
    /// 
    /// </summary>
    high,

    /// <summary>
    /// 
    /// </summary>
    low,
}