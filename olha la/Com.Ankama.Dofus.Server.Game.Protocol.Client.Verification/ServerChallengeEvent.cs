using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Client.Verification;

[Token(Token = "0x2000830")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ServerChallengeEvent : IMessage<ServerChallengeEvent>, IMessage, IEquatable<ServerChallengeEvent>, IDeepCloneable<ServerChallengeEvent>, IBufferMessage
{
	[Token(Token = "0x4001C35")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ServerChallengeEvent> _parser;

	[Token(Token = "0x4001C36")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001C37")]
	public const int ValueFieldNumber = 1;

	[Token(Token = "0x4001C38")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string ValueDefaultValue;

	[Token(Token = "0x4001C39")]
	[FieldOffset(Offset = "0x18")]
	private string value_;

	[Token(Token = "0x1700127E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ServerChallengeEvent> Parser
	{
		[Token(Token = "0x60056F4")]
		[Address(RVA = "0xB10B50", Offset = "0xB0FF50", VA = "0x180B10B50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700127F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60056F5")]
		[Address(RVA = "0xB10A90", Offset = "0xB0FE90", VA = "0x180B10A90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001280")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60056F6")]
		[Address(RVA = "0xB10D60", Offset = "0xB10160", VA = "0x180B10D60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001281")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Value
	{
		[Token(Token = "0x60056FA")]
		[Address(RVA = "0xB10BA0", Offset = "0xB0FFA0", VA = "0x180B10BA0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60056FB")]
		[Address(RVA = "0xB10E40", Offset = "0xB10240", VA = "0x180B10E40")]
		set
		{
		}
	}

	[Token(Token = "0x17001282")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasValue
	{
		[Token(Token = "0x60056FC")]
		[Address(RVA = "0xB10B40", Offset = "0xB0FF40", VA = "0x180B10B40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60056F7")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerChallengeEvent()
	{
	}

	[Token(Token = "0x60056F8")]
	[Address(RVA = "0xB10A30", Offset = "0xB0FE30", VA = "0x180B10A30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerChallengeEvent(ServerChallengeEvent other)
	{
	}

	[Token(Token = "0x60056F9")]
	[Address(RVA = "0xB105A0", Offset = "0xB0F9A0", VA = "0x180B105A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerChallengeEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60056FD")]
	[Address(RVA = "0x8A14B0", Offset = "0x8A08B0", VA = "0x1808A14B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearValue()
	{
	}

	[Token(Token = "0x60056FE")]
	[Address(RVA = "0xB106B0", Offset = "0xB0FAB0", VA = "0x180B106B0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60056FF")]
	[Address(RVA = "0xB10630", Offset = "0xB0FA30", VA = "0x180B10630", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ServerChallengeEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005700")]
	[Address(RVA = "0xB10770", Offset = "0xB0FB70", VA = "0x180B10770", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005701")]
	[Address(RVA = "0xB10890", Offset = "0xB0FC90", VA = "0x180B10890", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005702")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005703")]
	[Address(RVA = "0xB10CC0", Offset = "0xB100C0", VA = "0x180B10CC0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005704")]
	[Address(RVA = "0xB104D0", Offset = "0xB0F8D0", VA = "0x180B104D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005705")]
	[Address(RVA = "0xB10830", Offset = "0xB0FC30", VA = "0x180B10830", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ServerChallengeEvent other)
	{
	}

	[Token(Token = "0x6005706")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005707")]
	[Address(RVA = "0xB10C00", Offset = "0xB10000", VA = "0x180B10C00", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
