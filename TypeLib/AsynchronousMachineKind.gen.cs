using CimBios.Core.CimModel.DatatypeLib;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Режимы работы, в которых асинхронная машина способна работать.
/// </summary>
[CimClass("http://iec.ch/TC57/CIM100#AsynchronousMachineKind")]
public enum AsynchronousMachineKind
{
    /// <summary>
    /// 
    /// </summary>
    generator,

    /// <summary>
    /// 
    /// </summary>
    motor,

    /// <summary>
    /// 
    /// </summary>
    generatorOrMotor,
}