using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application;

[Token(Token = "0x200050B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildApplicationAnswerEvent : IMessage<GuildApplicationAnswerEvent>, IMessage, IEquatable<GuildApplicationAnswerEvent>, IDeepCloneable<GuildApplicationAnswerEvent>, IBufferMessage
{
	[Token(Token = "0x4001125")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildApplicationAnswerEvent> _parser;

	[Token(Token = "0x4001126")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001127")]
	public const int AcceptedFieldNumber = 1;

	[Token(Token = "0x4001128")]
	[FieldOffset(Offset = "0x18")]
	private bool accepted_;

	[Token(Token = "0x4001129")]
	public const int GuildInformationFieldNumber = 2;

	[Token(Token = "0x400112A")]
	[FieldOffset(Offset = "0x20")]
	private GuildInformation guildInformation_;

	[Token(Token = "0x17000B4E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildApplicationAnswerEvent> Parser
	{
		[Token(Token = "0x6003553")]
		[Address(RVA = "0x9FF0B0", Offset = "0x9FE4B0", VA = "0x1809FF0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B4F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003554")]
		[Address(RVA = "0x9FF000", Offset = "0x9FE400", VA = "0x1809FF000")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B50")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003555")]
		[Address(RVA = "0x9FF230", Offset = "0x9FE630", VA = "0x1809FF230", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B51")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Accepted
	{
		[Token(Token = "0x6003559")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600355A")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x17000B52")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInformation GuildInformation
	{
		[Token(Token = "0x600355B")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x600355C")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6003556")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationAnswerEvent()
	{
	}

	[Token(Token = "0x6003557")]
	[Address(RVA = "0x9FEF90", Offset = "0x9FE390", VA = "0x1809FEF90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationAnswerEvent(GuildApplicationAnswerEvent other)
	{
	}

	[Token(Token = "0x6003558")]
	[Address(RVA = "0x9FEB40", Offset = "0x9FDF40", VA = "0x1809FEB40", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationAnswerEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600355D")]
	[Address(RVA = "0x9FEBE0", Offset = "0x9FDFE0", VA = "0x1809FEBE0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600355E")]
	[Address(RVA = "0x9742A0", Offset = "0x9736A0", VA = "0x1809742A0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildApplicationAnswerEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600355F")]
	[Address(RVA = "0x9FEC90", Offset = "0x9FE090", VA = "0x1809FEC90", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003560")]
	[Address(RVA = "0x9FEE30", Offset = "0x9FE230", VA = "0x1809FEE30", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003561")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003562")]
	[Address(RVA = "0x9749C0", Offset = "0x973DC0", VA = "0x1809749C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003563")]
	[Address(RVA = "0x9FEAA0", Offset = "0x9FDEA0", VA = "0x1809FEAA0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003564")]
	[Address(RVA = "0x9FED50", Offset = "0x9FE150", VA = "0x1809FED50", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildApplicationAnswerEvent other)
	{
	}

	[Token(Token = "0x6003565")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003566")]
	[Address(RVA = "0x9FF100", Offset = "0x9FE500", VA = "0x1809FF100", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
