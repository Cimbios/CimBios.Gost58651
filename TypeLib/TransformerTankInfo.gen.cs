using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Общие технические параметры конструкции трансформатора.
/// </summary>
[CimClass(ClassUri)]
public partial class TransformerTankInfo(IOIDDescriptor oid, ICimMetaClass metaClass)
    : AssetInfo(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#TransformerTankInfo";

    /// <summary>
    /// Тип системы охлаждения.
    /// </summary>
    public CoolingKind? coolingKind
    {
        get => GetAttribute<CoolingKind?>(nameof(coolingKind));
        set => SetAttribute(nameof(coolingKind), value);
    }


    /// <summary>
    /// Информация о технических параметрах выводов трансформатора.
    /// </summary>
    public TransformerEndInfo[] TransformerEndInfos => GetAssoc1ToM<TransformerEndInfo>(nameof(TransformerEndInfos));

    public void AddToTransformerEndInfos(TransformerEndInfo assocObject) =>
        AddAssoc1ToM(nameof(TransformerEndInfos), assocObject);

    public void RemoveFromTransformerEndInfos(TransformerEndInfo assocObject) =>
        RemoveAssoc1ToM(nameof(TransformerEndInfos), assocObject);

    public void RemoveAllFromTransformerEndInfos() => RemoveAllAssocs1ToM(nameof(TransformerEndInfos));
}