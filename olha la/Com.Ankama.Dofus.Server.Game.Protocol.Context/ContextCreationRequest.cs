using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context;

[Token(Token = "0x2000781")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ContextCreationRequest : IMessage<ContextCreationRequest>, IMessage, IEquatable<ContextCreationRequest>, IDeepCloneable<ContextCreationRequest>, IBufferMessage
{
	[Token(Token = "0x4001A3A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ContextCreationRequest> _parser;

	[Token(Token = "0x4001A3B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001119")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ContextCreationRequest> Parser
	{
		[Token(Token = "0x6004FEE")]
		[Address(RVA = "0xAD11E0", Offset = "0xAD05E0", VA = "0x180AD11E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700111A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004FEF")]
		[Address(RVA = "0xAD1130", Offset = "0xAD0530", VA = "0x180AD1130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700111B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004FF0")]
		[Address(RVA = "0xAD1230", Offset = "0xAD0630", VA = "0x180AD1230", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004FF1")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContextCreationRequest()
	{
	}

	[Token(Token = "0x6004FF2")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContextCreationRequest(ContextCreationRequest other)
	{
	}

	[Token(Token = "0x6004FF3")]
	[Address(RVA = "0xAD0ED0", Offset = "0xAD02D0", VA = "0x180AD0ED0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContextCreationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004FF4")]
	[Address(RVA = "0xAD0F50", Offset = "0xAD0350", VA = "0x180AD0F50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004FF5")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContextCreationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004FF6")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004FF7")]
	[Address(RVA = "0xAD0FD0", Offset = "0xAD03D0", VA = "0x180AD0FD0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004FF8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004FF9")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004FFA")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004FFB")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ContextCreationRequest other)
	{
	}

	[Token(Token = "0x6004FFC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004FFD")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
