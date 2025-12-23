using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Система возбуждения.
/// </summary>
[CimClass(ClassUri)]
public partial class ExcitationSystem(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Equipment(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#ExcitationSystem";

    /// <summary>
    /// Кратность форсировки возбуждения по току по отношению к номинальным параметрам возбуждения, о.е.
    /// </summary>
    public float? currentExcitationForcingRatio
    {
        get => GetAttribute<float?>(nameof(currentExcitationForcingRatio));
        set => SetAttribute(nameof(currentExcitationForcingRatio), value);
    }

    /// <summary>
    /// Запаздывание при форсировке, с.
    /// </summary>
    public float? excitationForcingDelay
    {
        get => GetAttribute<float?>(nameof(excitationForcingDelay));
        set => SetAttribute(nameof(excitationForcingDelay), value);
    }

    /// <summary>
    /// Длительность форсировки, с.
    /// </summary>
    public float? excitationForcingDuration
    {
        get => GetAttribute<float?>(nameof(excitationForcingDuration));
        set => SetAttribute(nameof(excitationForcingDuration), value);
    }

    /// <summary>
    /// Быстродействие системы возбуждения при форсировке, с.
    /// </summary>
    public float? excitationForcingRapidity
    {
        get => GetAttribute<float?>(nameof(excitationForcingRapidity));
        set => SetAttribute(nameof(excitationForcingRapidity), value);
    }

    /// <summary>
    /// Полное время расфорсировки, с.
    /// </summary>
    public float? fullDeexcitationTime
    {
        get => GetAttribute<float?>(nameof(fullDeexcitationTime));
        set => SetAttribute(nameof(fullDeexcitationTime), value);
    }

    /// <summary>
    /// Время допустимой перегрузки при двукратном номинальном токе возбуждения, с.
    /// </summary>
    public float? maxDoubleOverloadTime
    {
        get => GetAttribute<float?>(nameof(maxDoubleOverloadTime));
        set => SetAttribute(nameof(maxDoubleOverloadTime), value);
    }

    /// <summary>
    /// Время задержки на снятие релейной форсировки, с.
    /// </summary>
    public float? relayExcitationReleaseDelay
    {
        get => GetAttribute<float?>(nameof(relayExcitationReleaseDelay));
        set => SetAttribute(nameof(relayExcitationReleaseDelay), value);
    }

    /// <summary>
    /// Напряжение возврата (снятия) релейной форсировки, кВ.
    /// </summary>
    public float? relayExcitationReleaseVoltage
    {
        get => GetAttribute<float?>(nameof(relayExcitationReleaseVoltage));
        set => SetAttribute(nameof(relayExcitationReleaseVoltage), value);
    }

    /// <summary>
    /// Напряжение срабатывания (ввода) релейной форсировки, кВ.
    /// </summary>
    public float? relayExcitationTriggerVoltage
    {
        get => GetAttribute<float?>(nameof(relayExcitationTriggerVoltage));
        set => SetAttribute(nameof(relayExcitationTriggerVoltage), value);
    }

    /// <summary>
    /// Маховой момент возбудителя (за исключением статических тиристорных систем возбуждения), т&#183;м<sup>2</sup>.
    /// </summary>
    public float? rotorGD2
    {
        get => GetAttribute<float?>(nameof(rotorGD2));
        set => SetAttribute(nameof(rotorGD2), value);
    }

    /// <summary>
    /// Эквивалентная постоянная времени возбудителя для высокочастотной и электромашинной системы возбуждения, с.
    /// </summary>
    public float? timeConstant
    {
        get => GetAttribute<float?>(nameof(timeConstant));
        set => SetAttribute(nameof(timeConstant), value);
    }

    /// <summary>
    /// Время допустимой перегрузки при двукратном номинальном токе возбуждения, с.
    /// </summary>
    public float? timeDoubleCurrentOverload
    {
        get => GetAttribute<float?>(nameof(timeDoubleCurrentOverload));
        set => SetAttribute(nameof(timeDoubleCurrentOverload), value);
    }

    /// <summary>
    /// Кратность расфорсировки возбуждения по напряжению по отношению к номинальным параметрам возбуждения, о.е.
    /// </summary>
    public float? voltageDeexcitationRatio
    {
        get => GetAttribute<float?>(nameof(voltageDeexcitationRatio));
        set => SetAttribute(nameof(voltageDeexcitationRatio), value);
    }

    /// <summary>
    /// Кратность форсировки возбуждения по напряжению по отношению к номинальным параметрам возбуждения, о.е./с.
    /// </summary>
    public float? voltageExcitationForcingRatio
    {
        get => GetAttribute<float?>(nameof(voltageExcitationForcingRatio));
        set => SetAttribute(nameof(voltageExcitationForcingRatio), value);
    }

    /// <summary>
    /// Номинальная скорость нарастания напряжения возбуждения, о.е./с.
    /// </summary>
    public float? voltageExcitationRampRate
    {
        get => GetAttribute<float?>(nameof(voltageExcitationRampRate));
        set => SetAttribute(nameof(voltageExcitationRampRate), value);
    }

    /// <summary>
    /// Автоматический регулятор возбуждения.
    /// </summary>
    public ExcitationControl? ExcitationControl
    {
        get => GetAssoc1To1<ExcitationControl>(nameof(ExcitationControl));
        set => SetAssoc1To1(nameof(ExcitationControl), value);
    }

    /// <summary>
    /// Генератор, к которому относится система возбуждения.
    /// </summary>
    public SynchronousMachine[] SynchronousMachine => GetAssoc1ToM<SynchronousMachine>(nameof(SynchronousMachine));

    public void AddToSynchronousMachine(SynchronousMachine assocObject) =>
        AddAssoc1ToM(nameof(SynchronousMachine), assocObject);

    public void RemoveFromSynchronousMachine(SynchronousMachine assocObject) =>
        RemoveAssoc1ToM(nameof(SynchronousMachine), assocObject);

    public void RemoveAllFromSynchronousMachine() => RemoveAllAssocs1ToM(nameof(SynchronousMachine));
}