using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Параметры подробной динамической модели синхронной машины.
/// </summary>
[CimClass(ClassUri)]
public partial class SynchronousMachineTimeConstantReactance(IOIDDescriptor oid, ICimMetaClass metaClass)
    : SynchronousMachineDetailed(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#SynchronousMachineTimeConstantReactance";

    /// <summary>
    /// Тип ротора синхронной машины.
    /// </summary>
    public RotorKind? rotorType
    {
        get => GetAttribute<RotorKind?>(nameof(rotorType));
        set => SetAttribute(nameof(rotorType), value);
    }

    /// <summary>
    /// Постоянная времени обмотки возбуждения при разомкнутой обмотке якоря <i>T</i><i><sub>d0</sub></i>, с.
    /// </summary>
    public float? tdo
    {
        get => GetAttribute<float?>(nameof(tdo));
        set => SetAttribute(nameof(tdo), value);
    }

    /// <summary>
    /// Постоянная времени обмотки возбуждения при короткозамкнутой обмотке якоря <i>T'</i><i><sub>d</sub></i>, с.
    /// </summary>
    public float? tpd
    {
        get => GetAttribute<float?>(nameof(tpd));
        set => SetAttribute(nameof(tpd), value);
    }

    /// <summary>
    /// Постоянная времени (переходная) обмотки возбуждения при разомкнутой обмотке якоря по продольной оси <i>T'</i><i><sub>d0</sub></i>, с.
    /// </summary>
    public float? tpdo
    {
        get => GetAttribute<float?>(nameof(tpdo));
        set => SetAttribute(nameof(tpdo), value);
    }

    /// <summary>
    /// Постоянная времени демпферной обмотки при короткозамкнутых обмотках якоря и возбуждения по продольной оси <i>T"</i><i><sub>d</sub></i>, с.
    /// </summary>
    public float? tppd
    {
        get => GetAttribute<float?>(nameof(tppd));
        set => SetAttribute(nameof(tppd), value);
    }

    /// <summary>
    /// Постоянная времени демпферной обмотки при разомкнутых обмотках якоря и возбуждения по продольной оси <i>T"</i><i><sub>d0</sub></i>, с.
    /// </summary>
    public float? tppdo
    {
        get => GetAttribute<float?>(nameof(tppdo));
        set => SetAttribute(nameof(tppdo), value);
    }

    /// <summary>
    /// Постоянная времени демпферной обмотки при короткозамкнутых обмотках якоря и возбуждения по поперечной оси <i>T"</i><i><sub>q</sub></i>, с.
    /// </summary>
    public float? tppq
    {
        get => GetAttribute<float?>(nameof(tppq));
        set => SetAttribute(nameof(tppq), value);
    }

    /// <summary>
    /// Постоянная времени демпферной обмотки при разомкнутых обмотках якоря и возбуждения по поперечной оси <i>T"</i><i><sub>q0</sub></i>, с.
    /// </summary>
    public float? tppqo
    {
        get => GetAttribute<float?>(nameof(tppqo));
        set => SetAttribute(nameof(tppqo), value);
    }

    /// <summary>
    /// Постоянная времени (переходная) обмотки возбуждения при разомкнутой обмотке якоря по поперечной оси <i>T'</i><i><sub>q0</sub></i>, с.
    /// </summary>
    public float? tpqo
    {
        get => GetAttribute<float?>(nameof(tpqo));
        set => SetAttribute(nameof(tpqo), value);
    }

    /// <summary>
    /// Реактивное сверхпереходное сопротивление по продольной оси <i>X"</i><i><sub>d</sub></i>, о.е.
    /// </summary>
    public float? xDirectSubtrans
    {
        get => GetAttribute<float?>(nameof(xDirectSubtrans));
        set => SetAttribute(nameof(xDirectSubtrans), value);
    }

    /// <summary>
    /// Синхронное реактивное сопротивление по продольной оси <i>X</i><i><sub>d</sub></i>, о.е.
    /// </summary>
    public float? xDirectSync
    {
        get => GetAttribute<float?>(nameof(xDirectSync));
        set => SetAttribute(nameof(xDirectSync), value);
    }

    /// <summary>
    /// Переходное реактивное сопротивление по продольной оси <i>X�</i><i><sub>d</sub></i>, о.е.
    /// </summary>
    public float? xDirectTrans
    {
        get => GetAttribute<float?>(nameof(xDirectTrans));
        set => SetAttribute(nameof(xDirectTrans), value);
    }

    /// <summary>
    /// Сверхпереходное реактивное сопротивление по поперечной оси <i>X��</i><i><sub>q</sub></i>, о.е.
    /// </summary>
    public float? xQuadSubtrans
    {
        get => GetAttribute<float?>(nameof(xQuadSubtrans));
        set => SetAttribute(nameof(xQuadSubtrans), value);
    }

    /// <summary>
    /// Синхронное реактивное сопротивление по поперечной оси <i>X</i><i><sub>q</sub></i>, о.е.
    /// </summary>
    public float? xQuadSync
    {
        get => GetAttribute<float?>(nameof(xQuadSync));
        set => SetAttribute(nameof(xQuadSync), value);
    }

    /// <summary>
    /// Переходное реактивное сопротивление по поперечной оси <i>X'</i><i><sub>q</sub></i>, о.е.
    /// </summary>
    public float? xQuadTrans
    {
        get => GetAttribute<float?>(nameof(xQuadTrans));
        set => SetAttribute(nameof(xQuadTrans), value);
    }
}