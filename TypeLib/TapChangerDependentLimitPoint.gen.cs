using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.DatatypeLib.TypeLib;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Строка таблицы зависимости эксплуатационных ограничений/пределов от положения переключателя регулировочных ответвлений.
/// </summary>
[CimClass(ClassUri)]
public partial class TapChangerDependentLimitPoint(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Resource(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#TapChangerDependentLimitPoint";

    /// <summary>
    /// Отношение значения эксплуатационного ограничения/предела для заданного положения переключателя регулировочных ответвлений к нормальному значению эксплуатационного ограничения/предела, %.
    /// </summary>
    public float? limitPercent
    {
        get => GetAttribute<float?>(nameof(limitPercent));
        set => SetAttribute(nameof(limitPercent), value);
    }

    /// <summary>
    /// Положение переключателя регулировочных ответвлений.
    /// </summary>
    public int? step
    {
        get => GetAttribute<int?>(nameof(step));
        set => SetAttribute(nameof(step), value);
    }

    /// <summary>
    /// Таблица зависимости эксплуатационных ограничений/пределов от положения переключателя регулировочных ответвлений.
    /// </summary>
    public TapChangerDependentLimitTable? TapChangerDependentLimitTable
    {
        get => GetAssoc1To1<TapChangerDependentLimitTable>(nameof(TapChangerDependentLimitTable));
        set => SetAssoc1To1(nameof(TapChangerDependentLimitTable), value);
    }
}