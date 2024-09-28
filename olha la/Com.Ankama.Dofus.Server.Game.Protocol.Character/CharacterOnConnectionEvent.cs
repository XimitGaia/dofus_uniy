using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character;

[Token(Token = "0x2000883")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterOnConnectionEvent : IMessage<CharacterOnConnectionEvent>, IMessage, IEquatable<CharacterOnConnectionEvent>, IDeepCloneable<CharacterOnConnectionEvent>, IBufferMessage
{
	[Token(Token = "0x2000884")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000885")]
		public enum ConnectionEvent
		{
			[Token(Token = "0x4001D7F")]
			[OriginalName("FIRST_ACCOUNT_CONNECTION_EVER")]
			FirstAccountConnectionEver,
			[Token(Token = "0x4001D80")]
			[OriginalName("FIRST_ACCOUNT_CONNECTION_ON_SERVER")]
			FirstAccountConnectionOnServer,
			[Token(Token = "0x4001D81")]
			[OriginalName("FIRST_ACCOUNT_CONNECTION_SINCE_REBOOT")]
			FirstAccountConnectionSinceReboot,
			[Token(Token = "0x4001D82")]
			[OriginalName("FIRST_CHARACTER_CONNECTION")]
			FirstCharacterConnection,
			[Token(Token = "0x4001D83")]
			[OriginalName("FIRST_CHARACTER_CONNECTION_SINCE_REBOOT")]
			FirstCharacterConnectionSinceReboot
		}
	}

	[Token(Token = "0x4001D7A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterOnConnectionEvent> _parser;

	[Token(Token = "0x4001D7B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001D7C")]
	public const int ConnectionEventFieldNumber = 1;

	[Token(Token = "0x4001D7D")]
	[FieldOffset(Offset = "0x18")]
	private Types.ConnectionEvent connectionEvent_;

	[Token(Token = "0x1700133E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterOnConnectionEvent> Parser
	{
		[Token(Token = "0x6005A68")]
		[Address(RVA = "0xB22EE0", Offset = "0xB222E0", VA = "0x180B22EE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700133F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005A69")]
		[Address(RVA = "0xB22E30", Offset = "0xB22230", VA = "0x180B22E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001340")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005A6A")]
		[Address(RVA = "0xB22F30", Offset = "0xB22330", VA = "0x180B22F30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001341")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.ConnectionEvent ConnectionEvent
	{
		[Token(Token = "0x6005A6E")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.ConnectionEvent);
		}
		[Token(Token = "0x6005A6F")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6005A6B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterOnConnectionEvent()
	{
	}

	[Token(Token = "0x6005A6C")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterOnConnectionEvent(CharacterOnConnectionEvent other)
	{
	}

	[Token(Token = "0x6005A6D")]
	[Address(RVA = "0xB22BC0", Offset = "0xB21FC0", VA = "0x180B22BC0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterOnConnectionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005A70")]
	[Address(RVA = "0xB22C40", Offset = "0xB22040", VA = "0x180B22C40", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005A71")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterOnConnectionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005A72")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005A73")]
	[Address(RVA = "0xB22CD0", Offset = "0xB220D0", VA = "0x180B22CD0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005A74")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005A75")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005A76")]
	[Address(RVA = "0xB22B30", Offset = "0xB21F30", VA = "0x180B22B30", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005A77")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterOnConnectionEvent other)
	{
	}

	[Token(Token = "0x6005A78")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005A79")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
