using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Режимы работы, в которых синхронная машина способна работать.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#SynchronousMachineKind")]
public enum SynchronousMachineKind
{
    /// <summary>
    /// 
    /// </summary>
    condenser,

    /// <summary>
    /// 
    /// </summary>
    generator,

    /// <summary>
    /// 
    /// </summary>
    generatorOrCondenser,

    /// <summary>
    /// 
    /// </summary>
    generatorOrCondenserOrMotor,

    /// <summary>
    /// 
    /// </summary>
    generatorOrMotor,

    /// <summary>
    /// 
    /// </summary>
    motor,

    /// <summary>
    /// 
    /// </summary>
    motorOrCondenser,
}