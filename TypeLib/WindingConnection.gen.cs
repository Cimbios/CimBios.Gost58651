using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Способ соединения обмоток трансформатора.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#WindingConnection")]
public enum WindingConnection
{
    /// <summary>
    /// 
    /// </summary>
    A,

    /// <summary>
    /// 
    /// </summary>
    D,

    /// <summary>
    /// 
    /// </summary>
    I,

    /// <summary>
    /// 
    /// </summary>
    Y,

    /// <summary>
    /// 
    /// </summary>
    Yn,

    /// <summary>
    /// 
    /// </summary>
    Z,

    /// <summary>
    /// 
    /// </summary>
    Zn,
}