using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Группа генерирующих установок, предназначенных для выработки электроэнергии и технологического пара.
/// </summary>
[CimClass(ClassUri)]
public partial class CogenerationPlant(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PowerSystemResource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#CogenerationPlant";

    /// <summary>
    /// Установленная мощность группы генерирующих установок, предназначенных для выработки электроэнергии и технологического пара, МВт.
    /// </summary>
    public float? ratedP
    {
        get => GetAttribute<float?>(nameof(ratedP));
        set => SetAttribute(nameof(ratedP), value);
    }


    /// <summary>
    /// Тепловые энергоблоки, входящие в группу генерирующих установок, предназначенных для выработки электроэнергии и технологического пара.
    /// </summary>
    public ThermalGeneratingUnit[] ThermalGeneratingUnits =>
        GetAssoc1ToM<ThermalGeneratingUnit>(nameof(ThermalGeneratingUnits));

    public void AddToThermalGeneratingUnits(ThermalGeneratingUnit assocObject) =>
        AddAssoc1ToM(nameof(ThermalGeneratingUnits), assocObject);

    public void RemoveFromThermalGeneratingUnits(ThermalGeneratingUnit assocObject) =>
        RemoveAssoc1ToM(nameof(ThermalGeneratingUnits), assocObject);

    public void RemoveAllFromThermalGeneratingUnits() => RemoveAllAssocs1ToM(nameof(ThermalGeneratingUnits));
}