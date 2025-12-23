using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Технические параметры проводников многофазного кабеля/ЛЭП.
/// </summary>
[CimClass(ClassUri)]
public partial class WireAssemblyInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AssetInfo(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#WireAssemblyInfo";


    /// <summary>
    /// Информация о фазах многожильного проводника.
    /// </summary>
    public WirePhaseInfo[] WirePhaseInfo => GetAssoc1ToM<WirePhaseInfo>(nameof(WirePhaseInfo));

    public void AddToWirePhaseInfo(WirePhaseInfo assocObject) => AddAssoc1ToM(nameof(WirePhaseInfo), assocObject);

    public void RemoveFromWirePhaseInfo(WirePhaseInfo assocObject) =>
        RemoveAssoc1ToM(nameof(WirePhaseInfo), assocObject);

    public void RemoveAllFromWirePhaseInfo() => RemoveAllAssocs1ToM(nameof(WirePhaseInfo));

    /// <summary>
    /// Удельные параметры ЛЭП, рассчитанные на основании WireAssemblyInfo.
    /// </summary>
    public PerLengthLineParameter[] PerLengthLineParameter =>
        GetAssoc1ToM<PerLengthLineParameter>(nameof(PerLengthLineParameter));

    public void AddToPerLengthLineParameter(PerLengthLineParameter assocObject) =>
        AddAssoc1ToM(nameof(PerLengthLineParameter), assocObject);

    public void RemoveFromPerLengthLineParameter(PerLengthLineParameter assocObject) =>
        RemoveAssoc1ToM(nameof(PerLengthLineParameter), assocObject);

    public void RemoveAllFromPerLengthLineParameter() => RemoveAllAssocs1ToM(nameof(PerLengthLineParameter));
}