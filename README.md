# GrpcMultiplyService

This .NET gRPC service performs basic arithmetic operations with methods to add and multiply two integers.

## Prerequisites

- [.NET 6 SDK or later](https://dotnet.microsoft.com/download)
- Visual Studio 2022 or Visual Studio Code
- gRPC-related NuGet packages: `Grpc.AspNetCore` and `Grpc.Tools` for code generation

## Getting Started

1. **Clone and Install Dependencies**:
   - Clone the repository and install required NuGet packages:
     ```bash
     dotnet add package Grpc.AspNetCore
     dotnet add package Grpc.Tools
     ```

2. **Configure `.proto` File**:
   - Ensure `calculator.proto` is referenced in the project file (`.csproj`) under `<Protobuf>` for gRPC code generation.

3. **Run the Service**:
   - Use `dotnet run` to start the server on `https://localhost:5001`.

## Usage

- **Methods**: 
  - `Add`: Adds two integers
  - `Multiply`: Multiplies two integers
- **Example Client**: Call methods using a gRPC client to pass in two numbers and receive the calculation result.

## Testing

- **grpcurl**: Test the service with `grpcurl` or any gRPC client by specifying inputs and target method.

## License
Nooooooooo License 
