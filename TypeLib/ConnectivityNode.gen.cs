using CimBios.Core.CimModel.DatatypeLib;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.Schema;

namespace CimBios.Gost58651.TypeLib;

/// <summary>
/// Соединительный узел.
/// </summary>
[CimClass(ClassUri)]
public partial class ConnectivityNode(IOIDDescriptor oid, ICimMetaClass metaClass)
    : IdentifiedObject(oid, metaClass)
{
    public new const string ClassUri = "http://iec.ch/TC57/CIM100#ConnectivityNode";


    /// <summary>
    /// Контейнер соединительных узлов.
    /// </summary>
    public ConnectivityNodeContainer? ConnectivityNodeContainer
    {
        get => GetAssoc1To1<ConnectivityNodeContainer>(nameof(ConnectivityNodeContainer));
        set => SetAssoc1To1(nameof(ConnectivityNodeContainer), value);
    }

    /// <summary>
    /// Соединенные полюса.
    /// </summary>
    public Terminal[] Terminals => GetAssoc1ToM<Terminal>(nameof(Terminals));

    public void AddToTerminals(Terminal assocObject) => AddAssoc1ToM(nameof(Terminals), assocObject);
    public void RemoveFromTerminals(Terminal assocObject) => RemoveAssoc1ToM(nameof(Terminals), assocObject);
    public void RemoveAllFromTerminals() => RemoveAllAssocs1ToM(nameof(Terminals));
}