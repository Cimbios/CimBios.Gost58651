using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Корпус силового трансформатора.
/// </summary>
[CimClass(ClassUri)]
public partial class TransformerTank(IOIDDescriptor oid, ICimMetaClass metaClass)
    : Equipment(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#TransformerTank";


    /// <summary>
    /// Силовой трансформатор, к которому относится корпус.
    /// </summary>
    public PowerTransformer? PowerTransformer
    {
        get => GetAssoc1To1<PowerTransformer>(nameof(PowerTransformer));
        set => SetAssoc1To1(nameof(PowerTransformer), value);
    }
}