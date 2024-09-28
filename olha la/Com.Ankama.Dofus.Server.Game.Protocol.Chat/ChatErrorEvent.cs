using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Chat;

[Token(Token = "0x2000856")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChatErrorEvent : IMessage<ChatErrorEvent>, IMessage, IEquatable<ChatErrorEvent>, IDeepCloneable<ChatErrorEvent>, IBufferMessage
{
	[Token(Token = "0x2000857")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000858")]
		public enum Error
		{
			[Token(Token = "0x4001CE8")]
			[OriginalName("UNKNOWN")]
			Unknown,
			[Token(Token = "0x4001CE9")]
			[OriginalName("RECEIVER_NOT_FOUND")]
			ReceiverNotFound,
			[Token(Token = "0x4001CEA")]
			[OriginalName("INTERIOR_MONOLOGUE")]
			InteriorMonologue,
			[Token(Token = "0x4001CEB")]
			[OriginalName("NO_GUILD")]
			NoGuild,
			[Token(Token = "0x4001CEC")]
			[OriginalName("NO_PARTY")]
			NoParty,
			[Token(Token = "0x4001CED")]
			[OriginalName("ALLIANCE")]
			Alliance,
			[Token(Token = "0x4001CEE")]
			[OriginalName("INVALID_MAP")]
			InvalidMap,
			[Token(Token = "0x4001CEF")]
			[OriginalName("NO_PARTY_ARENA")]
			NoPartyArena,
			[Token(Token = "0x4001CF0")]
			[OriginalName("NO_TEAM")]
			NoTeam,
			[Token(Token = "0x4001CF1")]
			[OriginalName("MALFORMED_CONTENT")]
			MalformedContent,
			[Token(Token = "0x4001CF2")]
			[OriginalName("NO_EXCHANGE")]
			NoExchange
		}
	}

	[Token(Token = "0x4001CE3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChatErrorEvent> _parser;

	[Token(Token = "0x4001CE4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001CE5")]
	public const int ErrorFieldNumber = 1;

	[Token(Token = "0x4001CE6")]
	[FieldOffset(Offset = "0x18")]
	private Types.Error error_;

	[Token(Token = "0x170012E3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ChatErrorEvent> Parser
	{
		[Token(Token = "0x60058A3")]
		[Address(RVA = "0xB00ED0", Offset = "0xB002D0", VA = "0x180B00ED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012E4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60058A4")]
		[Address(RVA = "0xB00E20", Offset = "0xB00220", VA = "0x180B00E20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012E5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60058A5")]
		[Address(RVA = "0xB00F20", Offset = "0xB00320", VA = "0x180B00F20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012E6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.Error Error
	{
		[Token(Token = "0x60058A9")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.Error);
		}
		[Token(Token = "0x60058AA")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60058A6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatErrorEvent()
	{
	}

	[Token(Token = "0x60058A7")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChatErrorEvent(ChatErrorEvent other)
	{
	}

	[Token(Token = "0x60058A8")]
	[Address(RVA = "0xB00BB0", Offset = "0xAFFFB0", VA = "0x180B00BB0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChatErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60058AB")]
	[Address(RVA = "0xB00C30", Offset = "0xB00030", VA = "0x180B00C30", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60058AC")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChatErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60058AD")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60058AE")]
	[Address(RVA = "0xB00CC0", Offset = "0xB000C0", VA = "0x180B00CC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60058AF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60058B0")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60058B1")]
	[Address(RVA = "0xB00B20", Offset = "0xAFFF20", VA = "0x180B00B20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60058B2")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChatErrorEvent other)
	{
	}

	[Token(Token = "0x60058B3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60058B4")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
