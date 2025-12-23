using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Переключатель регулировочных ответвлений трансформатора.
/// </summary>
[CimClass(ClassUri)]
public partial class TapChanger(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PowerSystemResource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#TapChanger";

    /// <summary>
    /// Если присвоено значение &#171;Истина&#187;, есть возможность регулирования.
    /// </summary>
    public bool? controlEnabled
    {
        get => GetAttribute<bool?>(nameof(controlEnabled));
        set => SetAttribute(nameof(controlEnabled), value);
    }

    /// <summary>
    /// Номер максимального положения переключателя ответвлений обмоток.
    /// </summary>
    public int? highStep
    {
        get => GetAttribute<int?>(nameof(highStep));
        set => SetAttribute(nameof(highStep), value);
    }

    /// <summary>
    /// Номер минимального положения переключателя ответвлений обмоток.
    /// </summary>
    public int? lowStep
    {
        get => GetAttribute<int?>(nameof(lowStep));
        set => SetAttribute(nameof(lowStep), value);
    }

    /// <summary>
    /// Если присвоено значение &#171;Истина&#187;, возможно переключение под нагрузкой.
    /// </summary>
    public bool? ltcFlag
    {
        get => GetAttribute<bool?>(nameof(ltcFlag));
        set => SetAttribute(nameof(ltcFlag), value);
    }

    /// <summary>
    /// Номер нейтрального положения переключателя ответвлений обмоток.
    /// </summary>
    public int? neutralStep
    {
        get => GetAttribute<int?>(nameof(neutralStep));
        set => SetAttribute(nameof(neutralStep), value);
    }

    /// <summary>
    /// Количество нейтральных положений.
    /// </summary>
    public int? neutralStepCount
    {
        get => GetAttribute<int?>(nameof(neutralStepCount));
        set => SetAttribute(nameof(neutralStepCount), value);
    }

    /// <summary>
    /// Нормальное положение переключателя ответвлений обмоток.
    /// </summary>
    public int? normalStep
    {
        get => GetAttribute<int?>(nameof(normalStep));
        set => SetAttribute(nameof(normalStep), value);
    }

    /// <summary>
    /// Система управления переключателя регулировочных ответвлений трансформатора.
    /// </summary>
    public TapChangerControl? TapChangerControl
    {
        get => GetAssoc1To1<TapChangerControl>(nameof(TapChangerControl));
        set => SetAssoc1To1(nameof(TapChangerControl), value);
    }
}