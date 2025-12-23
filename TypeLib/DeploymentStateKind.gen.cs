using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Состояния внедрения.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#DeploymentStateKind")]
public enum DeploymentStateKind
{
    /// <summary>
    /// 
    /// </summary>
    notYetInstalled,

    /// <summary>
    /// 
    /// </summary>
    installed,

    /// <summary>
    /// 
    /// </summary>
    inService,

    /// <summary>
    /// 
    /// </summary>
    outOfService,

    /// <summary>
    /// 
    /// </summary>
    removed,
}