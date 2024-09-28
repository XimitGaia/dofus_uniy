using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application;

[Token(Token = "0x2000511")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildApplicationReceivedEvent : IMessage<GuildApplicationReceivedEvent>, IMessage, IEquatable<GuildApplicationReceivedEvent>, IDeepCloneable<GuildApplicationReceivedEvent>, IBufferMessage
{
	[Token(Token = "0x4001141")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildApplicationReceivedEvent> _parser;

	[Token(Token = "0x4001142")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001143")]
	public const int PlayerNameFieldNumber = 1;

	[Token(Token = "0x4001144")]
	[FieldOffset(Offset = "0x18")]
	private string playerName_;

	[Token(Token = "0x4001145")]
	public const int PlayerIdFieldNumber = 2;

	[Token(Token = "0x4001146")]
	[FieldOffset(Offset = "0x20")]
	private long playerId_;

	[Token(Token = "0x17000B60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildApplicationReceivedEvent> Parser
	{
		[Token(Token = "0x60035A0")]
		[Address(RVA = "0xA008E0", Offset = "0x9FFCE0", VA = "0x180A008E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B61")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60035A1")]
		[Address(RVA = "0xA00830", Offset = "0x9FFC30", VA = "0x180A00830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B62")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60035A2")]
		[Address(RVA = "0xA00AA0", Offset = "0x9FFEA0", VA = "0x180A00AA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B63")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string PlayerName
	{
		[Token(Token = "0x60035A6")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60035A7")]
		[Address(RVA = "0xA00B80", Offset = "0x9FFF80", VA = "0x180A00B80")]
		set
		{
		}
	}

	[Token(Token = "0x17000B64")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long PlayerId
	{
		[Token(Token = "0x60035A8")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60035A9")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x60035A3")]
	[Address(RVA = "0xA00730", Offset = "0x9FFB30", VA = "0x180A00730")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationReceivedEvent()
	{
	}

	[Token(Token = "0x60035A4")]
	[Address(RVA = "0xA00780", Offset = "0x9FFB80", VA = "0x180A00780")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationReceivedEvent(GuildApplicationReceivedEvent other)
	{
	}

	[Token(Token = "0x60035A5")]
	[Address(RVA = "0xA002D0", Offset = "0x9FF6D0", VA = "0x180A002D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationReceivedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60035AA")]
	[Address(RVA = "0xA003A0", Offset = "0x9FF7A0", VA = "0x180A003A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60035AB")]
	[Address(RVA = "0xA00460", Offset = "0x9FF860", VA = "0x180A00460", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildApplicationReceivedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60035AC")]
	[Address(RVA = "0xA004D0", Offset = "0x9FF8D0", VA = "0x180A004D0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60035AD")]
	[Address(RVA = "0xA005D0", Offset = "0x9FF9D0", VA = "0x180A005D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60035AE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60035AF")]
	[Address(RVA = "0xA00A10", Offset = "0x9FFE10", VA = "0x180A00A10", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60035B0")]
	[Address(RVA = "0xA00210", Offset = "0x9FF610", VA = "0x180A00210", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60035B1")]
	[Address(RVA = "0xA00560", Offset = "0x9FF960", VA = "0x180A00560", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildApplicationReceivedEvent other)
	{
	}

	[Token(Token = "0x60035B2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60035B3")]
	[Address(RVA = "0xA00930", Offset = "0x9FFD30", VA = "0x180A00930", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
