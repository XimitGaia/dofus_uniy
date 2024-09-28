using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Member;

[Token(Token = "0x2000C8E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceKickRequest : IMessage<AllianceKickRequest>, IMessage, IEquatable<AllianceKickRequest>, IDeepCloneable<AllianceKickRequest>, IBufferMessage
{
	[Token(Token = "0x4002E55")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceKickRequest> _parser;

	[Token(Token = "0x4002E56")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E57")]
	public const int KickedIdFieldNumber = 1;

	[Token(Token = "0x4002E58")]
	[FieldOffset(Offset = "0x18")]
	private long kickedId_;

	[Token(Token = "0x17001CF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceKickRequest> Parser
	{
		[Token(Token = "0x600842B")]
		[Address(RVA = "0xC96800", Offset = "0xC95C00", VA = "0x180C96800")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CF1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600842C")]
		[Address(RVA = "0xC96750", Offset = "0xC95B50", VA = "0x180C96750")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CF2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600842D")]
		[Address(RVA = "0xC96850", Offset = "0xC95C50", VA = "0x180C96850", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CF3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long KickedId
	{
		[Token(Token = "0x6008431")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6008432")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x600842E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceKickRequest()
	{
	}

	[Token(Token = "0x600842F")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceKickRequest(AllianceKickRequest other)
	{
	}

	[Token(Token = "0x6008430")]
	[Address(RVA = "0xC964E0", Offset = "0xC958E0", VA = "0x180C964E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceKickRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008433")]
	[Address(RVA = "0xC96560", Offset = "0xC95960", VA = "0x180C96560", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008434")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceKickRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008435")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008436")]
	[Address(RVA = "0xC965F0", Offset = "0xC959F0", VA = "0x180C965F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008437")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008438")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008439")]
	[Address(RVA = "0xC96450", Offset = "0xC95850", VA = "0x180C96450", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600843A")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceKickRequest other)
	{
	}

	[Token(Token = "0x600843B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600843C")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
