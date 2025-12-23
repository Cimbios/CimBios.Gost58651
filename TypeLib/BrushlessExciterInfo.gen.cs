using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры бесщеточного возбудителя.
/// </summary>
[CimClass(ClassUri)]
public partial class BrushlessExciterInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AssetInfo(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#BrushlessExciterInfo";

    /// <summary>
    /// Кратность расфорсировки по напряжению возбуждения возбудителя, о.е.
    /// </summary>
    public float? deexcitationRatio
    {
        get => GetAttribute<float?>(nameof(deexcitationRatio));
        set => SetAttribute(nameof(deexcitationRatio), value);
    }

    /// <summary>
    /// Кратность форсировки по напряжению возбуждения возбудителя, о.е.
    /// </summary>
    public float? forcingRatio
    {
        get => GetAttribute<float?>(nameof(forcingRatio));
        set => SetAttribute(nameof(forcingRatio), value);
    }

    /// <summary>
    /// Номинальная активная мощность возбудителя, МВт.
    /// </summary>
    public float? nominalP
    {
        get => GetAttribute<float?>(nameof(nominalP));
        set => SetAttribute(nameof(nominalP), value);
    }

    /// <summary>
    /// Сопротивление дополнительного резистора в обмотке возбуждения бесщеточного возбудителя, Ом.
    /// </summary>
    public float? rAdditionalResistor
    {
        get => GetAttribute<float?>(nameof(rAdditionalResistor));
        set => SetAttribute(nameof(rAdditionalResistor), value);
    }

    /// <summary>
    /// Номинальный ток, А.
    /// </summary>
    public float? ratedCurrent
    {
        get => GetAttribute<float?>(nameof(ratedCurrent));
        set => SetAttribute(nameof(ratedCurrent), value);
    }

    /// <summary>
    /// Номинальное напряжение, кВ.
    /// </summary>
    public float? ratedVoltage
    {
        get => GetAttribute<float?>(nameof(ratedVoltage));
        set => SetAttribute(nameof(ratedVoltage), value);
    }

    /// <summary>
    /// Активное сопротивление обмотки возбуждения, Ом.
    /// </summary>
    public float? rExcitationWinding
    {
        get => GetAttribute<float?>(nameof(rExcitationWinding));
        set => SetAttribute(nameof(rExcitationWinding), value);
    }

    /// <summary>
    /// Активное сопротивление ротора генератора, Ом.
    /// </summary>
    public float? rotorResistance
    {
        get => GetAttribute<float?>(nameof(rotorResistance));
        set => SetAttribute(nameof(rotorResistance), value);
    }

    /// <summary>
    /// Постоянная времени обмотки возбуждения возбудителя при разомкнутой обмотке якоря возбудителя, с.
    /// </summary>
    public float? td
    {
        get => GetAttribute<float?>(nameof(td));
        set => SetAttribute(nameof(td), value);
    }

    /// <summary>
    /// Сверхпереходное реактивное сопротивление по продольной оси X"dB (ненасыщенное), о.е.
    /// </summary>
    public float? xDirectSubtrans
    {
        get => GetAttribute<float?>(nameof(xDirectSubtrans));
        set => SetAttribute(nameof(xDirectSubtrans), value);
    }

    /// <summary>
    /// Синхронное реактивное сопротивление по продольной оси XdB, о.е.
    /// </summary>
    public float? xDirectSync
    {
        get => GetAttribute<float?>(nameof(xDirectSync));
        set => SetAttribute(nameof(xDirectSync), value);
    }

    /// <summary>
    /// Переходное реактивное сопротивление по продольной оси Х'dB, о.е.
    /// </summary>
    public float? xDirectTrans
    {
        get => GetAttribute<float?>(nameof(xDirectTrans));
        set => SetAttribute(nameof(xDirectTrans), value);
    }

    /// <summary>
    /// Сверхпереходное реактивное сопротивление по поперечной оси X"qB, о.е.
    /// </summary>
    public float? xQuadSubtrans
    {
        get => GetAttribute<float?>(nameof(xQuadSubtrans));
        set => SetAttribute(nameof(xQuadSubtrans), value);
    }

    /// <summary>
    /// Синхронное реактивное сопротивление по поперечной оси XqB, о.е.
    /// </summary>
    public float? xQuadSync
    {
        get => GetAttribute<float?>(nameof(xQuadSync));
        set => SetAttribute(nameof(xQuadSync), value);
    }

    /// <summary>
    /// Реактивное сопротивление рассеяния (ненасыщенное), о.е.
    /// </summary>
    public float? xs
    {
        get => GetAttribute<float?>(nameof(xs));
        set => SetAttribute(nameof(xs), value);
    }
}