using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Вид состояния пломбы.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#SealConditionKind")]
public enum SealConditionKind
{
    /// <summary>
    /// 
    /// </summary>
    broken,

    /// <summary>
    /// 
    /// </summary>
    locked,

    /// <summary>
    /// 
    /// </summary>
    missing,

    /// <summary>
    /// 
    /// </summary>
    open,

    /// <summary>
    /// 
    /// </summary>
    other,
}