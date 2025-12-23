using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Таблица зависимости эксплуатационных ограничений/пределов от положения переключателя регулировочных ответвлений.
/// </summary>
[CimClass(ClassUri)]
public partial class TapChangerDependentLimitTable(IOIDDescriptor oid, ICimMetaClass metaClass)
    : LimitDependency(oid, metaClass)
{
    public new const string ClassUri = "http://gost.ru/2019/schema-cim01#TapChangerDependentLimitTable";


    /// <summary>
    /// Строка таблицы зависимости эксплуатационных ограничений/пределов от положения переключателя регулировочных ответвлений.
    /// </summary>
    public TapChangerDependentLimitPoint[] TapChangerDependentLimitPoints =>
        GetAssoc1ToM<TapChangerDependentLimitPoint>(nameof(TapChangerDependentLimitPoints));

    public void AddToTapChangerDependentLimitPoints(TapChangerDependentLimitPoint assocObject) =>
        AddAssoc1ToM(nameof(TapChangerDependentLimitPoints), assocObject);

    public void RemoveFromTapChangerDependentLimitPoints(TapChangerDependentLimitPoint assocObject) =>
        RemoveAssoc1ToM(nameof(TapChangerDependentLimitPoints), assocObject);

    public void RemoveAllFromTapChangerDependentLimitPoints() =>
        RemoveAllAssocs1ToM(nameof(TapChangerDependentLimitPoints));

    /// <summary>
    /// Переключатель регулировочных ответвлений обмотки, к которому относится таблица зависимости эксплуатационных ограничений/пределов.
    /// </summary>
    public RatioTapChanger[] RatioTapChanger => GetAssoc1ToM<RatioTapChanger>(nameof(RatioTapChanger));

    public void AddToRatioTapChanger(RatioTapChanger assocObject) => AddAssoc1ToM(nameof(RatioTapChanger), assocObject);

    public void RemoveFromRatioTapChanger(RatioTapChanger assocObject) =>
        RemoveAssoc1ToM(nameof(RatioTapChanger), assocObject);

    public void RemoveAllFromRatioTapChanger() => RemoveAllAssocs1ToM(nameof(RatioTapChanger));
}