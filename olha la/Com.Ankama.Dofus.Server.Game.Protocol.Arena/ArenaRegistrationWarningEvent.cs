using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000BA8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ArenaRegistrationWarningEvent : IMessage<ArenaRegistrationWarningEvent>, IMessage, IEquatable<ArenaRegistrationWarningEvent>, IDeepCloneable<ArenaRegistrationWarningEvent>, IBufferMessage
{
	[Token(Token = "0x4002B8A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ArenaRegistrationWarningEvent> _parser;

	[Token(Token = "0x4002B8B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002B8C")]
	public const int BattleModeFieldNumber = 1;

	[Token(Token = "0x4002B8D")]
	[FieldOffset(Offset = "0x18")]
	private ArenaType battleMode_;

	[Token(Token = "0x17001B03")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ArenaRegistrationWarningEvent> Parser
	{
		[Token(Token = "0x6007AA0")]
		[Address(RVA = "0xC33040", Offset = "0xC32440", VA = "0x180C33040")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B04")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007AA1")]
		[Address(RVA = "0xC32F90", Offset = "0xC32390", VA = "0x180C32F90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B05")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007AA2")]
		[Address(RVA = "0xC33090", Offset = "0xC32490", VA = "0x180C33090", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B06")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaType BattleMode
	{
		[Token(Token = "0x6007AA6")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ArenaType);
		}
		[Token(Token = "0x6007AA7")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6007AA3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaRegistrationWarningEvent()
	{
	}

	[Token(Token = "0x6007AA4")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaRegistrationWarningEvent(ArenaRegistrationWarningEvent other)
	{
	}

	[Token(Token = "0x6007AA5")]
	[Address(RVA = "0xC32D20", Offset = "0xC32120", VA = "0x180C32D20", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaRegistrationWarningEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007AA8")]
	[Address(RVA = "0xC32DA0", Offset = "0xC321A0", VA = "0x180C32DA0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007AA9")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ArenaRegistrationWarningEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007AAA")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007AAB")]
	[Address(RVA = "0xC32E30", Offset = "0xC32230", VA = "0x180C32E30", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007AAC")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007AAD")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007AAE")]
	[Address(RVA = "0xC32C90", Offset = "0xC32090", VA = "0x180C32C90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007AAF")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ArenaRegistrationWarningEvent other)
	{
	}

	[Token(Token = "0x6007AB0")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007AB1")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
