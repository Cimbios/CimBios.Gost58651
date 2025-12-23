using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Удельные электрические параметры фазы участка ЛЭП.
/// </summary>
[CimClass(ClassUri)]
public partial class PerLengthPhaseImpedance(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PerLengthImpedance(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#PerLengthPhaseImpedance";

    /// <summary>
    /// Ограничение количества элементов матрицы фазных удельных параметров.
    /// </summary>
    public int? conductorCount
    {
        get => GetAttribute<int?>(nameof(conductorCount));
        set => SetAttribute(nameof(conductorCount), value);
    }


    /// <summary>
    /// Элементы матрицы сопротивлений и проводимостей.
    /// </summary>
    public PhaseImpedanceData[] PhaseImpedanceData => GetAssoc1ToM<PhaseImpedanceData>(nameof(PhaseImpedanceData));

    public void AddToPhaseImpedanceData(PhaseImpedanceData assocObject) =>
        AddAssoc1ToM(nameof(PhaseImpedanceData), assocObject);

    public void RemoveFromPhaseImpedanceData(PhaseImpedanceData assocObject) =>
        RemoveAssoc1ToM(nameof(PhaseImpedanceData), assocObject);

    public void RemoveAllFromPhaseImpedanceData() => RemoveAllAssocs1ToM(nameof(PhaseImpedanceData));
}