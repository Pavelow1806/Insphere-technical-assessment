// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PathDrift.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Insphere.Protos {
  public static partial class Reader
  {
    static readonly string __ServiceName = "PathDrift.Reader";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Insphere.Protos.PathDriftCoordinatesRequest> __Marshaller_PathDrift_PathDriftCoordinatesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Insphere.Protos.PathDriftCoordinatesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Insphere.Protos.PathDriftCoordinatesResponse> __Marshaller_PathDrift_PathDriftCoordinatesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Insphere.Protos.PathDriftCoordinatesResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Insphere.Protos.PathDriftCoordinatesRequest, global::Insphere.Protos.PathDriftCoordinatesResponse> __Method_GetCoordinates = new grpc::Method<global::Insphere.Protos.PathDriftCoordinatesRequest, global::Insphere.Protos.PathDriftCoordinatesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCoordinates",
        __Marshaller_PathDrift_PathDriftCoordinatesRequest,
        __Marshaller_PathDrift_PathDriftCoordinatesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Insphere.Protos.PathDriftReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Reader</summary>
    [grpc::BindServiceMethod(typeof(Reader), "BindService")]
    public abstract partial class ReaderBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Insphere.Protos.PathDriftCoordinatesResponse> GetCoordinates(global::Insphere.Protos.PathDriftCoordinatesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ReaderBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCoordinates, serviceImpl.GetCoordinates).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ReaderBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCoordinates, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Insphere.Protos.PathDriftCoordinatesRequest, global::Insphere.Protos.PathDriftCoordinatesResponse>(serviceImpl.GetCoordinates));
    }

  }
}
#endregion