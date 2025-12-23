# CimBios.Gost58651

**CimBios.Gost58651** is a ready-to-use type library (*CIM classes C# implementatio*n) based on the `GOST 58651` (IEC 61970/61968 extensions) series of standards and the canonical model disclosed by the SO UPS. The base class is the `ModelObject` described in the [CimBios library core](https://github.com/Cimbios/CimBios.Core).

## Getting Started

### 1. Create a New DotNET Project

If you don't already have a dotnet project, create one in Visual Studio.

### 2: Install NuGet Package
Inatall `CimBios.Gost58651` NuGet package to your app with your preferred method. Here is the one using NuGet Package Manager:

```bash
Install-Package CimBios.Gost58651
```
### 3.1 Use to create typed CIM objects

```csharp
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Gost58651.Factory;
using CimBios.Gost58651.TypeLib;

var lib = new Gost58651Factory().Create();
var substation = lib.CreateInstance<Substation>(new UuidDescriptor());
substation.name = "New substation";
var voltageLevel = lib.CreateInstance<VoltageLevel>(new UuidDescriptor());
voltageLevel.name = "Voltage level";
voltageLevel.Substation = substation;
```

### 3.2 Use to (de)serialize CIM exhange model

```csharp
using CimBios.Core.CimModel.DataModel;
using CimBios.Core.CimModel.DataModel.Document;
using CimBios.Core.CimModel.DatatypeLib.ModelObject;
using CimBios.Core.CimModel.DatatypeLib.OID;
using CimBios.Core.CimModel.RdfSerializer;
using CimBios.Gost58651.Factory;
using CimBios.Gost58651.TypeLib;

var lib = new Gost58651Factory().Create();
var model = new CimDocument(lib.Schema, lib, new UuidDescriptorFactory());
model.Load("model.xml", new RdfXmlSerializerFactory());

var allCurrentTransformers = model.GetObjects<CurrentTransformer>();
```

### 3.3 Use only schema

Library contains RDF schema.

```csharp
using CimBios.Gost58651.Factory;

var lib = new Gost58651Factory().Create();
var schema = lib.Schema;
```

## Contributing

Contributions are welcome from the community! If you find any issues or have suggestions for improvements, please submit them through the GitHub issue tracker or consider making a pull request.

## License

This project is licensed under the [GPL 3.0 License](https://github.com/all-licenses/GNU-General-Public-License-v3.0).