using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Параметры опыта холостого хода обмотки трансформатора.
/// </summary>
[CimClass(ClassUri)]
public partial class NoLoadTest(IOIDDescriptor oid, ICimMetaClass metaClass)
    : TransformerTest(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#NoLoadTest";

    /// <summary>
    /// Напряжение первичной обмотки, кВ.
    /// </summary>
    public float? energisedEndVoltage
    {
        get => GetAttribute<float?>(nameof(energisedEndVoltage));
        set => SetAttribute(nameof(energisedEndVoltage), value);
    }

    /// <summary>
    /// Ток холостого хода, %.
    /// </summary>
    public float? excitingCurrent
    {
        get => GetAttribute<float?>(nameof(excitingCurrent));
        set => SetAttribute(nameof(excitingCurrent), value);
    }

    /// <summary>
    /// Потери холостого хода, кВт.
    /// </summary>
    public float? loss
    {
        get => GetAttribute<float?>(nameof(loss));
        set => SetAttribute(nameof(loss), value);
    }

    /// <summary>
    /// Вывод трансформатора, на который подается напряжение в опыте холостого хода.
    /// </summary>
    public TransformerEndInfo? EnergisedEnd
    {
        get => GetAssoc1To1<TransformerEndInfo>(nameof(EnergisedEnd));
        set => SetAssoc1To1(nameof(EnergisedEnd), value);
    }
}