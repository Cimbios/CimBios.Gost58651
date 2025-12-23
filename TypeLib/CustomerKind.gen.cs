using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Вид клиента.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#CustomerKind")]
public enum CustomerKind
{
    /// <summary>
    /// 
    /// </summary>
    commercialIndustrial,

    /// <summary>
    /// 
    /// </summary>
    energyServiceScheduler,

    /// <summary>
    /// 
    /// </summary>
    energyServiceSupplier,

    /// <summary>
    /// 
    /// </summary>
    internalUse,

    /// <summary>
    /// 
    /// </summary>
    other,

    /// <summary>
    /// 
    /// </summary>
    pumpingLoad,

    /// <summary>
    /// 
    /// </summary>
    residential,

    /// <summary>
    /// 
    /// </summary>
    residentialAndCommercial,

    /// <summary>
    /// 
    /// </summary>
    residentialAndStreetlight,

    /// <summary>
    /// 
    /// </summary>
    residentialFarmService,

    /// <summary>
    /// 
    /// </summary>
    residentialStreetlightOthers,

    /// <summary>
    /// 
    /// </summary>
    windMachine,
}