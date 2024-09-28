using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context;

[Token(Token = "0x2000787")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ContextKickRequest : IMessage<ContextKickRequest>, IMessage, IEquatable<ContextKickRequest>, IDeepCloneable<ContextKickRequest>, IBufferMessage
{
	[Token(Token = "0x4001A45")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ContextKickRequest> _parser;

	[Token(Token = "0x4001A46")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001A47")]
	public const int TargetIdFieldNumber = 1;

	[Token(Token = "0x4001A48")]
	[FieldOffset(Offset = "0x18")]
	private long targetId_;

	[Token(Token = "0x17001123")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ContextKickRequest> Parser
	{
		[Token(Token = "0x600502C")]
		[Address(RVA = "0xAD1B00", Offset = "0xAD0F00", VA = "0x180AD1B00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001124")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600502D")]
		[Address(RVA = "0xAD1A50", Offset = "0xAD0E50", VA = "0x180AD1A50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001125")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600502E")]
		[Address(RVA = "0xAD1B50", Offset = "0xAD0F50", VA = "0x180AD1B50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001126")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long TargetId
	{
		[Token(Token = "0x6005032")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005033")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x600502F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContextKickRequest()
	{
	}

	[Token(Token = "0x6005030")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContextKickRequest(ContextKickRequest other)
	{
	}

	[Token(Token = "0x6005031")]
	[Address(RVA = "0xAD17E0", Offset = "0xAD0BE0", VA = "0x180AD17E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContextKickRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005034")]
	[Address(RVA = "0xAD1860", Offset = "0xAD0C60", VA = "0x180AD1860", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005035")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContextKickRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005036")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005037")]
	[Address(RVA = "0xAD18F0", Offset = "0xAD0CF0", VA = "0x180AD18F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005038")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005039")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600503A")]
	[Address(RVA = "0xAD1750", Offset = "0xAD0B50", VA = "0x180AD1750", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600503B")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ContextKickRequest other)
	{
	}

	[Token(Token = "0x600503C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600503D")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
