using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Контейнер соединительных узлов.
/// </summary>
[CimClass(ClassUri)]
public partial class ConnectivityNodeContainer(IOIDDescriptor oid, ICimMetaClass metaClass)
    : PowerSystemResource(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ConnectivityNodeContainer";


    /// <summary>
    /// Соединительные узлы, входящие в контейнер соединительных узлов.
    /// </summary>
    public ConnectivityNode[] ConnectivityNodes => GetAssoc1ToM<ConnectivityNode>(nameof(ConnectivityNodes));

    public void AddToConnectivityNodes(ConnectivityNode assocObject) =>
        AddAssoc1ToM(nameof(ConnectivityNodes), assocObject);

    public void RemoveFromConnectivityNodes(ConnectivityNode assocObject) =>
        RemoveAssoc1ToM(nameof(ConnectivityNodes), assocObject);

    public void RemoveAllFromConnectivityNodes() => RemoveAllAssocs1ToM(nameof(ConnectivityNodes));
}