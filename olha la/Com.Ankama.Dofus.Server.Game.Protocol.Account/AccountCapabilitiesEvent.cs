using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Account;

[Token(Token = "0x2000D3A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AccountCapabilitiesEvent : IMessage<AccountCapabilitiesEvent>, IMessage, IEquatable<AccountCapabilitiesEvent>, IDeepCloneable<AccountCapabilitiesEvent>, IBufferMessage
{
	[Token(Token = "0x4003073")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AccountCapabilitiesEvent> _parser;

	[Token(Token = "0x4003074")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4003075")]
	public const int AccountIdFieldNumber = 1;

	[Token(Token = "0x4003076")]
	[FieldOffset(Offset = "0x18")]
	private long accountId_;

	[Token(Token = "0x4003077")]
	public const int TutorialAvailableFieldNumber = 2;

	[Token(Token = "0x4003078")]
	[FieldOffset(Offset = "0x20")]
	private bool tutorialAvailable_;

	[Token(Token = "0x4003079")]
	public const int StatusFieldNumber = 3;

	[Token(Token = "0x400307A")]
	[FieldOffset(Offset = "0x24")]
	private Hierarchy status_;

	[Token(Token = "0x400307B")]
	public const int CanCreateNewCharacterFieldNumber = 4;

	[Token(Token = "0x400307C")]
	[FieldOffset(Offset = "0x28")]
	private bool canCreateNewCharacter_;

	[Token(Token = "0x17001E64")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AccountCapabilitiesEvent> Parser
	{
		[Token(Token = "0x6008B45")]
		[Address(RVA = "0xCB89A0", Offset = "0xCB7DA0", VA = "0x180CB89A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E65")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008B46")]
		[Address(RVA = "0xCB88F0", Offset = "0xCB7CF0", VA = "0x180CB88F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E66")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008B47")]
		[Address(RVA = "0xCB8BB0", Offset = "0xCB7FB0", VA = "0x180CB8BB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E67")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long AccountId
	{
		[Token(Token = "0x6008B4B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6008B4C")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001E68")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool TutorialAvailable
	{
		[Token(Token = "0x6008B4D")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008B4E")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x17001E69")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Hierarchy Status
	{
		[Token(Token = "0x6008B4F")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(Hierarchy);
		}
		[Token(Token = "0x6008B50")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x17001E6A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CanCreateNewCharacter
	{
		[Token(Token = "0x6008B51")]
		[Address(RVA = "0x8529D0", Offset = "0x851DD0", VA = "0x1808529D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008B52")]
		[Address(RVA = "0x9A1E80", Offset = "0x9A1280", VA = "0x1809A1E80")]
		set
		{
		}
	}

	[Token(Token = "0x6008B48")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AccountCapabilitiesEvent()
	{
	}

	[Token(Token = "0x6008B49")]
	[Address(RVA = "0xCB8880", Offset = "0xCB7C80", VA = "0x180CB8880")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AccountCapabilitiesEvent(AccountCapabilitiesEvent other)
	{
	}

	[Token(Token = "0x6008B4A")]
	[Address(RVA = "0xCB8400", Offset = "0xCB7800", VA = "0x180CB8400", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AccountCapabilitiesEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008B53")]
	[Address(RVA = "0xCB84A0", Offset = "0xCB78A0", VA = "0x180CB84A0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008B54")]
	[Address(RVA = "0xCB8550", Offset = "0xCB7950", VA = "0x180CB8550", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AccountCapabilitiesEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008B55")]
	[Address(RVA = "0xCB85A0", Offset = "0xCB79A0", VA = "0x180CB85A0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008B56")]
	[Address(RVA = "0xCB8720", Offset = "0xCB7B20", VA = "0x180CB8720", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008B57")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008B58")]
	[Address(RVA = "0xCB8AF0", Offset = "0xCB7EF0", VA = "0x180CB8AF0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008B59")]
	[Address(RVA = "0xCB8330", Offset = "0xCB7730", VA = "0x180CB8330", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008B5A")]
	[Address(RVA = "0xCB86B0", Offset = "0xCB7AB0", VA = "0x180CB86B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AccountCapabilitiesEvent other)
	{
	}

	[Token(Token = "0x6008B5B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008B5C")]
	[Address(RVA = "0xCB89F0", Offset = "0xCB7DF0", VA = "0x180CB89F0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
