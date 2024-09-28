using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004CC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildCardEvent : IMessage<GuildCardEvent>, IMessage, IEquatable<GuildCardEvent>, IDeepCloneable<GuildCardEvent>, IBufferMessage
{
	[Token(Token = "0x4001062")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildCardEvent> _parser;

	[Token(Token = "0x4001063")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001064")]
	public const int InfoFieldNumber = 1;

	[Token(Token = "0x4001065")]
	[FieldOffset(Offset = "0x18")]
	private GuildInformation info_;

	[Token(Token = "0x4001066")]
	public const int CreationDateFieldNumber = 2;

	[Token(Token = "0x4001067")]
	[FieldOffset(Offset = "0x20")]
	private int creationDate_;

	[Token(Token = "0x4001068")]
	public const int MembersFieldNumber = 3;

	[Token(Token = "0x4001069")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> _repeated_members_codec;

	[Token(Token = "0x400106A")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> members_;

	[Token(Token = "0x17000AC2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildCardEvent> Parser
	{
		[Token(Token = "0x60032AA")]
		[Address(RVA = "0x9EB030", Offset = "0x9EA430", VA = "0x1809EB030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AC3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60032AB")]
		[Address(RVA = "0x9EAF80", Offset = "0x9EA380", VA = "0x1809EAF80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AC4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60032AC")]
		[Address(RVA = "0x9EB310", Offset = "0x9EA710", VA = "0x1809EB310", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AC5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildInformation Info
	{
		[Token(Token = "0x60032B0")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60032B1")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000AC6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CreationDate
	{
		[Token(Token = "0x60032B2")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60032B3")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000AC7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> Members
	{
		[Token(Token = "0x60032B4")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60032AD")]
	[Address(RVA = "0x9EAE40", Offset = "0x9EA240", VA = "0x1809EAE40")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildCardEvent()
	{
	}

	[Token(Token = "0x60032AE")]
	[Address(RVA = "0x9EAEC0", Offset = "0x9EA2C0", VA = "0x1809EAEC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildCardEvent(GuildCardEvent other)
	{
	}

	[Token(Token = "0x60032AF")]
	[Address(RVA = "0x9EA8B0", Offset = "0x9E9CB0", VA = "0x1809EA8B0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildCardEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60032B5")]
	[Address(RVA = "0x9EAA50", Offset = "0x9E9E50", VA = "0x1809EAA50", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60032B6")]
	[Address(RVA = "0x9EA9A0", Offset = "0x9E9DA0", VA = "0x1809EA9A0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildCardEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60032B7")]
	[Address(RVA = "0x92A820", Offset = "0x929C20", VA = "0x18092A820", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60032B8")]
	[Address(RVA = "0x9EAC40", Offset = "0x9EA040", VA = "0x1809EAC40", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60032B9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60032BA")]
	[Address(RVA = "0x9EB210", Offset = "0x9EA610", VA = "0x1809EB210", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60032BB")]
	[Address(RVA = "0x9EA7A0", Offset = "0x9E9BA0", VA = "0x1809EA7A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60032BC")]
	[Address(RVA = "0x9EAB40", Offset = "0x9E9F40", VA = "0x1809EAB40", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildCardEvent other)
	{
	}

	[Token(Token = "0x60032BD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60032BE")]
	[Address(RVA = "0x9EB080", Offset = "0x9EA480", VA = "0x1809EB080", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
