using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Вид технологии коммуникации.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#ComTechnologyKind")]
public enum ComTechnologyKind
{
    /// <summary>
    /// 
    /// </summary>
    cellular,

    /// <summary>
    /// 
    /// </summary>
    ethernet,

    /// <summary>
    /// 
    /// </summary>
    homePlug,

    /// <summary>
    /// 
    /// </summary>
    pager,

    /// <summary>
    /// 
    /// </summary>
    phone,

    /// <summary>
    /// 
    /// </summary>
    plc,

    /// <summary>
    /// 
    /// </summary>
    rf,

    /// <summary>
    /// 
    /// </summary>
    rfMesh,

    /// <summary>
    /// 
    /// </summary>
    zigbee,
}