using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Таблично заданная зависимость коэффициента трансформации и изменений проводимостей и сопротивлений в зависимости от номера регулировочного ответвления.
/// </summary>
[CimClass(ClassUri)]
public partial class RatioTapChangerTable(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#RatioTapChangerTable";


    /// <summary>
    /// Переключатель регулировочных ответвленийобмотки трансформатора с продольным регулированием, к которому относитсятаблица переключений.
    /// </summary>
    public RatioTapChanger[] RatioTapChanger => GetAssoc1ToM<RatioTapChanger>(nameof(RatioTapChanger));

    public void AddToRatioTapChanger(RatioTapChanger assocObject) => AddAssoc1ToM(nameof(RatioTapChanger), assocObject);

    public void RemoveFromRatioTapChanger(RatioTapChanger assocObject) =>
        RemoveAssoc1ToM(nameof(RatioTapChanger), assocObject);

    public void RemoveAllFromRatioTapChanger() => RemoveAllAssocs1ToM(nameof(RatioTapChanger));

    /// <summary>
    /// Точка таблицы переключателя регулировочных ответвлений обмотки трансформатора с продольным регулированием.
    /// </summary>
    public RatioTapChangerTablePoint[] RatioTapChangerTablePoint =>
        GetAssoc1ToM<RatioTapChangerTablePoint>(nameof(RatioTapChangerTablePoint));

    public void AddToRatioTapChangerTablePoint(RatioTapChangerTablePoint assocObject) =>
        AddAssoc1ToM(nameof(RatioTapChangerTablePoint), assocObject);

    public void RemoveFromRatioTapChangerTablePoint(RatioTapChangerTablePoint assocObject) =>
        RemoveAssoc1ToM(nameof(RatioTapChangerTablePoint), assocObject);

    public void RemoveAllFromRatioTapChangerTablePoint() => RemoveAllAssocs1ToM(nameof(RatioTapChangerTablePoint));
}