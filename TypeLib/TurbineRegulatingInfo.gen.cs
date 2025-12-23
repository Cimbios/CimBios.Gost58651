using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры регулятора скорости турбины.
/// </summary>
[CimClass(ClassUri)]
public partial class TurbineRegulatingInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AssetInfo(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#TurbineRegulatingInfo";

    /// <summary>
    /// Возможна импульсная (кратковременная) и длительная разгрузка под воздействием управляющего сигнала максимальной амплитуды через электрогидравлический преобразователь турбины (если присвоено значение &#171;Истина&#187;).
    /// </summary>
    public bool? fastValvingControl
    {
        get => GetAttribute<bool?>(nameof(fastValvingControl));
        set => SetAttribute(nameof(fastValvingControl), value);
    }

    /// <summary>
    /// Интервал времени по истечении которого блокируется прием последующих команд на реализацию КРТ, КРТ+ДРТ, с.
    /// </summary>
    public float? fastValvingControlBlockTime
    {
        get => GetAttribute<float?>(nameof(fastValvingControlBlockTime));
        set => SetAttribute(nameof(fastValvingControlBlockTime), value);
    }

    /// <summary>
    /// Время задержки от момента подачи управляющего воздействия на электрогидравлический преобразователь до начала снижения мощности турбины, с.
    /// </summary>
    public float? fastValvingControlDelay
    {
        get => GetAttribute<float?>(nameof(fastValvingControlDelay));
        set => SetAttribute(nameof(fastValvingControlDelay), value);
    }

    /// <summary>
    /// Скорость снижения мощности турбины при импульсной разгрузке, МВт/с.
    /// </summary>
    public float? fastValvingControlRampRate
    {
        get => GetAttribute<float?>(nameof(fastValvingControlRampRate));
        set => SetAttribute(nameof(fastValvingControlRampRate), value);
    }

    /// <summary>
    /// Максимальная величина снижения мощности турбины при импульсной разгрузке, %.
    /// </summary>
    public float? fastValvingControlRate
    {
        get => GetAttribute<float?>(nameof(fastValvingControlRate));
        set => SetAttribute(nameof(fastValvingControlRate), value);
    }

    /// <summary>
    /// Время восстановления мощности турбины после кратковременной разгрузки, с.
    /// </summary>
    public float? fastValvingControlRestoreTime
    {
        get => GetAttribute<float?>(nameof(fastValvingControlRestoreTime));
        set => SetAttribute(nameof(fastValvingControlRestoreTime), value);
    }

    /// <summary>
    /// Зона нечувствительности регулятора скорости, Гц.
    /// </summary>
    public float? freqControlDeadband
    {
        get => GetAttribute<float?>(nameof(freqControlDeadband));
        set => SetAttribute(nameof(freqControlDeadband), value);
    }

    /// <summary>
    /// Зона нечувствительности частотного корректора, Гц.
    /// </summary>
    public float? frequencyCorrectorDeadband
    {
        get => GetAttribute<float?>(nameof(frequencyCorrectorDeadband));
        set => SetAttribute(nameof(frequencyCorrectorDeadband), value);
    }

    /// <summary>
    /// Статизм частотного корректора, %.
    /// </summary>
    public float? frequencyCorrectorSCD
    {
        get => GetAttribute<float?>(nameof(frequencyCorrectorSCD));
        set => SetAttribute(nameof(frequencyCorrectorSCD), value);
    }

    /// <summary>
    /// Зона нечувствительности регулятора скорости, Гц.
    /// </summary>
    public float? governorDeadband
    {
        get => GetAttribute<float?>(nameof(governorDeadband));
        set => SetAttribute(nameof(governorDeadband), value);
    }

    /// <summary>
    /// Скорость снижения мощности турбины при ДРТ, МВт/с.
    /// </summary>
    public float? sustainedFastValvingControlRampRate
    {
        get => GetAttribute<float?>(nameof(sustainedFastValvingControlRampRate));
        set => SetAttribute(nameof(sustainedFastValvingControlRampRate), value);
    }

    /// <summary>
    /// Максимальная величина снижения мощности турбины при длительной разгрузке, %.
    /// </summary>
    public float? sustainedFastValvingControlRate
    {
        get => GetAttribute<float?>(nameof(sustainedFastValvingControlRate));
        set => SetAttribute(nameof(sustainedFastValvingControlRate), value);
    }
}