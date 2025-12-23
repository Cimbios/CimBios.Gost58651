using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Параметры электромагнитной связи нулевой последовательности для участков линии переменного тока.
/// </summary>
[CimClass(ClassUri)]
public partial class MutualCoupling(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#MutualCoupling";

    /// <summary>
    /// Взаимная емкостная поперечная (зарядная) проводимость нулевой последовательности, См.
    /// </summary>
    public float? b0ch
    {
        get => GetAttribute<float?>(nameof(b0ch));
        set => SetAttribute(nameof(b0ch), value);
    }

    /// <summary>
    /// Расстояние от первого полюса первого участка ЛЭП до начала сближения со вторым участком ЛЭП, м.
    /// </summary>
    public float? distance11
    {
        get => GetAttribute<float?>(nameof(distance11));
        set => SetAttribute(nameof(distance11), value);
    }

    /// <summary>
    /// Расстояние от первого полюса первого участка ЛЭП до конца сближения со вторым участком ЛЭП, м.
    /// </summary>
    public float? distance12
    {
        get => GetAttribute<float?>(nameof(distance12));
        set => SetAttribute(nameof(distance12), value);
    }

    /// <summary>
    /// Расстояние от второго полюса первого участка ЛЭП до начала сближения со вторым участком ЛЭП, м.
    /// </summary>
    public float? distance21
    {
        get => GetAttribute<float?>(nameof(distance21));
        set => SetAttribute(nameof(distance21), value);
    }

    /// <summary>
    /// Расстояние от второго полюса первого участка ЛЭП до конца сближения со вторым участком ЛЭП, м.
    /// </summary>
    public float? distance22
    {
        get => GetAttribute<float?>(nameof(distance22));
        set => SetAttribute(nameof(distance22), value);
    }

    /// <summary>
    /// Взаимная активная поперечная (зарядная) проводимость нулевой последовательности, См.
    /// </summary>
    public float? g0ch
    {
        get => GetAttribute<float?>(nameof(g0ch));
        set => SetAttribute(nameof(g0ch), value);
    }

    /// <summary>
    /// Взаимное активное сопротивление нулевой последовательности, Ом.
    /// </summary>
    public float? r0
    {
        get => GetAttribute<float?>(nameof(r0));
        set => SetAttribute(nameof(r0), value);
    }

    /// <summary>
    /// Взаимное индуктивное сопротивление нулевой последовательности, Ом.
    /// </summary>
    public float? x0
    {
        get => GetAttribute<float?>(nameof(x0));
        set => SetAttribute(nameof(x0), value);
    }

    /// <summary>
    /// Полюс, относительно которого измеряется расстояние вдоль первого участка взаимосвязанной пары.
    /// </summary>
    public Terminal? First_Terminal
    {
        get => GetAssoc1To1<Terminal>(nameof(First_Terminal));
        set => SetAssoc1To1(nameof(First_Terminal), value);
    }

    /// <summary>
    /// Полюс, относительно которого измеряется расстояние вдоль второго участка взаимосвязанной пары.
    /// </summary>
    public Terminal? Second_Terminal
    {
        get => GetAssoc1To1<Terminal>(nameof(Second_Terminal));
        set => SetAssoc1To1(nameof(Second_Terminal), value);
    }
}