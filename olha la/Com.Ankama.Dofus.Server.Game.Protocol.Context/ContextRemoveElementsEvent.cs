using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context;

[Token(Token = "0x2000793")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ContextRemoveElementsEvent : IMessage<ContextRemoveElementsEvent>, IMessage, IEquatable<ContextRemoveElementsEvent>, IDeepCloneable<ContextRemoveElementsEvent>, IBufferMessage
{
	[Token(Token = "0x4001A5F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ContextRemoveElementsEvent> _parser;

	[Token(Token = "0x4001A60")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001A61")]
	public const int ElementIdFieldNumber = 1;

	[Token(Token = "0x4001A62")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<long> _repeated_elementId_codec;

	[Token(Token = "0x4001A63")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<long> elementId_;

	[Token(Token = "0x17001136")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ContextRemoveElementsEvent> Parser
	{
		[Token(Token = "0x6005098")]
		[Address(RVA = "0xAD4FF0", Offset = "0xAD43F0", VA = "0x180AD4FF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001137")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005099")]
		[Address(RVA = "0xAD4F40", Offset = "0xAD4340", VA = "0x180AD4F40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001138")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600509A")]
		[Address(RVA = "0xAD5210", Offset = "0xAD4610", VA = "0x180AD5210", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001139")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<long> ElementId
	{
		[Token(Token = "0x600509E")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600509B")]
	[Address(RVA = "0xAD4EC0", Offset = "0xAD42C0", VA = "0x180AD4EC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContextRemoveElementsEvent()
	{
	}

	[Token(Token = "0x600509C")]
	[Address(RVA = "0xAD4E30", Offset = "0xAD4230", VA = "0x180AD4E30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContextRemoveElementsEvent(ContextRemoveElementsEvent other)
	{
	}

	[Token(Token = "0x600509D")]
	[Address(RVA = "0xAD49F0", Offset = "0xAD3DF0", VA = "0x180AD49F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContextRemoveElementsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600509F")]
	[Address(RVA = "0xAD4AB0", Offset = "0xAD3EB0", VA = "0x180AD4AB0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60050A0")]
	[Address(RVA = "0xAD4B90", Offset = "0xAD3F90", VA = "0x180AD4B90", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ContextRemoveElementsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60050A1")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60050A2")]
	[Address(RVA = "0xAD4CA0", Offset = "0xAD40A0", VA = "0x180AD4CA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60050A3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60050A4")]
	[Address(RVA = "0xAD5160", Offset = "0xAD4560", VA = "0x180AD5160", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60050A5")]
	[Address(RVA = "0xAD4950", Offset = "0xAD3D50", VA = "0x180AD4950", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60050A6")]
	[Address(RVA = "0xAD4C20", Offset = "0xAD4020", VA = "0x180AD4C20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ContextRemoveElementsEvent other)
	{
	}

	[Token(Token = "0x60050A7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60050A8")]
	[Address(RVA = "0xAD5040", Offset = "0xAD4440", VA = "0x180AD5040", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
