using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x200061D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightOptionToggleRequest : IMessage<FightOptionToggleRequest>, IMessage, IEquatable<FightOptionToggleRequest>, IDeepCloneable<FightOptionToggleRequest>, IBufferMessage
{
	[Token(Token = "0x400157B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightOptionToggleRequest> _parser;

	[Token(Token = "0x400157C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400157D")]
	public const int OptionFieldNumber = 1;

	[Token(Token = "0x400157E")]
	[FieldOffset(Offset = "0x18")]
	private FightOption option_;

	[Token(Token = "0x17000E07")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightOptionToggleRequest> Parser
	{
		[Token(Token = "0x6004157")]
		[Address(RVA = "0xA7DC90", Offset = "0xA7D090", VA = "0x180A7DC90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E08")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004158")]
		[Address(RVA = "0xA7DBE0", Offset = "0xA7CFE0", VA = "0x180A7DBE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E09")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004159")]
		[Address(RVA = "0xA7DCE0", Offset = "0xA7D0E0", VA = "0x180A7DCE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E0A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightOption Option
	{
		[Token(Token = "0x600415D")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(FightOption);
		}
		[Token(Token = "0x600415E")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600415A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightOptionToggleRequest()
	{
	}

	[Token(Token = "0x600415B")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightOptionToggleRequest(FightOptionToggleRequest other)
	{
	}

	[Token(Token = "0x600415C")]
	[Address(RVA = "0xA7D970", Offset = "0xA7CD70", VA = "0x180A7D970", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightOptionToggleRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600415F")]
	[Address(RVA = "0xA7D9F0", Offset = "0xA7CDF0", VA = "0x180A7D9F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004160")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightOptionToggleRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004161")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004162")]
	[Address(RVA = "0xA7DA80", Offset = "0xA7CE80", VA = "0x180A7DA80", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004163")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004164")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004165")]
	[Address(RVA = "0xA7D8E0", Offset = "0xA7CCE0", VA = "0x180A7D8E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004166")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightOptionToggleRequest other)
	{
	}

	[Token(Token = "0x6004167")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004168")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
