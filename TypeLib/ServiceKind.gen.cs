using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Вид услуги.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#ServiceKind")]
public enum ServiceKind
{
    /// <summary>
    /// 
    /// </summary>
    electricity,

    /// <summary>
    /// 
    /// </summary>
    gas,

    /// <summary>
    /// 
    /// </summary>
    heat,

    /// <summary>
    /// 
    /// </summary>
    internet,

    /// <summary>
    /// 
    /// </summary>
    other,

    /// <summary>
    /// 
    /// </summary>
    rates,

    /// <summary>
    /// 
    /// </summary>
    refuse,

    /// <summary>
    /// 
    /// </summary>
    sewerage,

    /// <summary>
    /// 
    /// </summary>
    time,

    /// <summary>
    /// 
    /// </summary>
    tvLicence,

    /// <summary>
    /// 
    /// </summary>
    water,
}