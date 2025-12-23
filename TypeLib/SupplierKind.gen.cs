using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Вид поставщика услуг по передаче электрической энергии.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#SupplierKind")]
public enum SupplierKind
{
    /// <summary>
    /// 
    /// </summary>
    lse,

    /// <summary>
    /// 
    /// </summary>
    mdma,

    /// <summary>
    /// 
    /// </summary>
    msp,

    /// <summary>
    /// 
    /// </summary>
    other,

    /// <summary>
    /// 
    /// </summary>
    retailer,

    /// <summary>
    /// 
    /// </summary>
    utility,
}