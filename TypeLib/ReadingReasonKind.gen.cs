using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Причина, по которой значение получено.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#ReadingReasonKind")]
public enum ReadingReasonKind
{
    /// <summary>
    /// 
    /// </summary>
    billing,

    /// <summary>
    /// 
    /// </summary>
    demandReset,

    /// <summary>
    /// 
    /// </summary>
    inquiry,

    /// <summary>
    /// 
    /// </summary>
    installation,

    /// <summary>
    /// 
    /// </summary>
    loadManagement,

    /// <summary>
    /// 
    /// </summary>
    loadResearch,

    /// <summary>
    /// 
    /// </summary>
    moveIn,

    /// <summary>
    /// 
    /// </summary>
    moveOut,

    /// <summary>
    /// 
    /// </summary>
    other,

    /// <summary>
    /// 
    /// </summary>
    removal,

    /// <summary>
    /// 
    /// </summary>
    serviceConnect,

    /// <summary>
    /// 
    /// </summary>
    serviceDisconnect,
}