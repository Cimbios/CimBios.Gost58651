using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Параметры внедрения оборудования.
/// </summary>
[CimClass(ClassUri)]
public partial class AssetDeployment(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#AssetDeployment";

    /// <summary>
    /// Даты изменения состояния объекта.
    /// </summary>
    public DeploymentDate? deploymentDate
    {
        get => GetAttribute<DeploymentDate?>(nameof(deploymentDate));
        set => SetAttribute(nameof(deploymentDate), value);
    }

    /// <summary>
    /// Текущее состояние объекта.
    /// </summary>
    public DeploymentStateKind? deploymentState
    {
        get => GetAttribute<DeploymentStateKind?>(nameof(deploymentState));
        set => SetAttribute(nameof(deploymentState), value);
    }

    /// <summary>
    /// Тип объекта размещения.
    /// </summary>
    public FacilityKind? facilityKind
    {
        get => GetAttribute<FacilityKind?>(nameof(facilityKind));
        set => SetAttribute(nameof(facilityKind), value);
    }

    /// <summary>
    /// Внедряемый объект.
    /// </summary>
    public Asset? Asset
    {
        get => GetAssoc1To1<Asset>(nameof(Asset));
        set => SetAssoc1To1(nameof(Asset), value);
    }

    /// <summary>
    /// Номинальное эксплуатационное напряжение внедряемого материального объекта.
    /// </summary>
    public BaseVoltage? BaseVoltage
    {
        get => GetAssoc1To1<BaseVoltage>(nameof(BaseVoltage));
        set => SetAssoc1To1(nameof(BaseVoltage), value);
    }
}