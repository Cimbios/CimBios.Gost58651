using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Строка таблицы зависимости коэффициента трансформации и изменений проводимостей и сопротивлений в зависимости от номера регулировочного ответвления.
/// </summary>
[CimClass(ClassUri)]
public partial class RatioTapChangerTablePoint(IOIDDescriptor oid, ICimMetaClass metaClass)
    : TapChangerTablePoint(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#RatioTapChangerTablePoint";


    /// <summary>
    /// Таблица переключателя регулировочных ответвлений обмотки трансформатора с продольным регулированием, к которой относится указанная строка таблицы.
    /// </summary>
    public RatioTapChangerTable? RatioTapChangerTable
    {
        get => GetAssoc1To1<RatioTapChangerTable>(nameof(RatioTapChangerTable));
        set => SetAssoc1To1(nameof(RatioTapChangerTable), value);
    }
}