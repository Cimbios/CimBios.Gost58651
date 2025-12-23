using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Система управления переключателем регулировочных ответвлений трансформатора.
/// </summary>
[CimClass(ClassUri)]
public partial class TapChangerControl(IOIDDescriptor oid, ICimMetaClass metaClass)
    : RegulatingControl(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#TapChangerControl";


    /// <summary>
    /// Переключатель регулировочных ответвлений обмотки, на которые воздействует система управления.
    /// </summary>
    public TapChanger[] TapChanger => GetAssoc1ToM<TapChanger>(nameof(TapChanger));

    public void AddToTapChanger(TapChanger assocObject) => AddAssoc1ToM(nameof(TapChanger), assocObject);
    public void RemoveFromTapChanger(TapChanger assocObject) => RemoveAssoc1ToM(nameof(TapChanger), assocObject);
    public void RemoveAllFromTapChanger() => RemoveAllAssocs1ToM(nameof(TapChanger));
}