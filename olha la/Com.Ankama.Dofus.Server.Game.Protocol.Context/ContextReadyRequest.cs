using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context;

[Token(Token = "0x2000783")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ContextReadyRequest : IMessage<ContextReadyRequest>, IMessage, IEquatable<ContextReadyRequest>, IDeepCloneable<ContextReadyRequest>, IBufferMessage
{
	[Token(Token = "0x4001A3D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ContextReadyRequest> _parser;

	[Token(Token = "0x4001A3E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001A3F")]
	public const int MapIdFieldNumber = 1;

	[Token(Token = "0x4001A40")]
	[FieldOffset(Offset = "0x18")]
	private long mapId_;

	[Token(Token = "0x1700111C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ContextReadyRequest> Parser
	{
		[Token(Token = "0x6005002")]
		[Address(RVA = "0xAD2420", Offset = "0xAD1820", VA = "0x180AD2420")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700111D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005003")]
		[Address(RVA = "0xAD2370", Offset = "0xAD1770", VA = "0x180AD2370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700111E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005004")]
		[Address(RVA = "0xAD2470", Offset = "0xAD1870", VA = "0x180AD2470", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700111F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long MapId
	{
		[Token(Token = "0x6005008")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005009")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6005005")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContextReadyRequest()
	{
	}

	[Token(Token = "0x6005006")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContextReadyRequest(ContextReadyRequest other)
	{
	}

	[Token(Token = "0x6005007")]
	[Address(RVA = "0xAD2100", Offset = "0xAD1500", VA = "0x180AD2100", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContextReadyRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600500A")]
	[Address(RVA = "0xAD2180", Offset = "0xAD1580", VA = "0x180AD2180", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600500B")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContextReadyRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600500C")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600500D")]
	[Address(RVA = "0xAD2210", Offset = "0xAD1610", VA = "0x180AD2210", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600500E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600500F")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005010")]
	[Address(RVA = "0xAD2070", Offset = "0xAD1470", VA = "0x180AD2070", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005011")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ContextReadyRequest other)
	{
	}

	[Token(Token = "0x6005012")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005013")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
