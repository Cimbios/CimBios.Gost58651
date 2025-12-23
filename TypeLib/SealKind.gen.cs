using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Вид пломбы.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#SealKind")]
public enum SealKind
{
    /// <summary>
    /// 
    /// </summary>
    lead,

    /// <summary>
    /// 
    /// </summary>
    @lock,

    /// <summary>
    /// 
    /// </summary>
    other,

    /// <summary>
    /// 
    /// </summary>
    steel,
}