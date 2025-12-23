using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Регулятор коэффициента трансформации.
/// </summary>
[CimClass(ClassUri)]
public partial class RatioTapChanger(IOIDDescriptor oid, ICimMetaClass metaClass)
    : TapChanger(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#RatioTapChanger";

    /// <summary>
    /// Процент изменения напряжения при изменении регулировочного ответвления, %.
    /// </summary>
    public float? stepVoltageIncrement
    {
        get => GetAttribute<float?>(nameof(stepVoltageIncrement));
        set => SetAttribute(nameof(stepVoltageIncrement), value);
    }

    /// <summary>
    /// Таблично заданная зависимость коэффициента трансформации и изменений проводимостей и сопротивлений в зависимости от номера регулировочного ответвления.
    /// </summary>
    public RatioTapChangerTable? RatioTapChangerTable
    {
        get => GetAssoc1To1<RatioTapChangerTable>(nameof(RatioTapChangerTable));
        set => SetAssoc1To1(nameof(RatioTapChangerTable), value);
    }

    /// <summary>
    /// Вывод силового трансформатора, к которому относится переключатель регулировочных ответвлений с продольным регулированием.
    /// </summary>
    public TransformerEnd? TransformerEnd
    {
        get => GetAssoc1To1<TransformerEnd>(nameof(TransformerEnd));
        set => SetAssoc1To1(nameof(TransformerEnd), value);
    }

    /// <summary>
    /// Таблично заданная зависимость эксплуатационного ограничения/предела от положения переключателя регулировочных ответвлений.
    /// </summary>
    public TapChangerDependentLimitTable? TapChangerDependentLimitTable
    {
        get => GetAssoc1To1<TapChangerDependentLimitTable>(nameof(TapChangerDependentLimitTable));
        set => SetAssoc1To1(nameof(TapChangerDependentLimitTable), value);
    }
}