using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Жизненный цикл системы считывания показаний в точке поставки в отношении готовности к выставлению счетов с помощью расширенной инфраструктуры считываний показаний.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#AmiBillingReadyKind")]
public enum AmiBillingReadyKind
{
    /// <summary>
    /// 
    /// </summary>
    amiCapable,

    /// <summary>
    /// 
    /// </summary>
    amiDisabled,

    /// <summary>
    /// 
    /// </summary>
    billingApproved,

    /// <summary>
    /// 
    /// </summary>
    enabled,

    /// <summary>
    /// 
    /// </summary>
    nonAmi,

    /// <summary>
    /// 
    /// </summary>
    nonMetered,

    /// <summary>
    /// 
    /// </summary>
    operable,
}