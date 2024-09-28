using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004AA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildSummaryEvent : IMessage<GuildSummaryEvent>, IMessage, IEquatable<GuildSummaryEvent>, IDeepCloneable<GuildSummaryEvent>, IBufferMessage
{
	[Token(Token = "0x4000FF1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildSummaryEvent> _parser;

	[Token(Token = "0x4000FF2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000FF3")]
	public const int OffsetFieldNumber = 1;

	[Token(Token = "0x4000FF4")]
	[FieldOffset(Offset = "0x18")]
	private long offset_;

	[Token(Token = "0x4000FF5")]
	public const int CountFieldNumber = 2;

	[Token(Token = "0x4000FF6")]
	[FieldOffset(Offset = "0x20")]
	private long count_;

	[Token(Token = "0x4000FF7")]
	public const int TotalFieldNumber = 3;

	[Token(Token = "0x4000FF8")]
	[FieldOffset(Offset = "0x28")]
	private long total_;

	[Token(Token = "0x4000FF9")]
	public const int GuildsFieldNumber = 4;

	[Token(Token = "0x4000FFA")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<GuildInformation> _repeated_guilds_codec;

	[Token(Token = "0x4000FFB")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<GuildInformation> guilds_;

	[Token(Token = "0x17000A71")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildSummaryEvent> Parser
	{
		[Token(Token = "0x600311C")]
		[Address(RVA = "0x9DDB40", Offset = "0x9DCF40", VA = "0x1809DDB40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A72")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600311D")]
		[Address(RVA = "0x9DDA90", Offset = "0x9DCE90", VA = "0x1809DDA90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A73")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600311E")]
		[Address(RVA = "0x9DDE20", Offset = "0x9DD220", VA = "0x1809DDE20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A74")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Offset
	{
		[Token(Token = "0x6003122")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003123")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000A75")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Count
	{
		[Token(Token = "0x6003124")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003125")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A76")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Total
	{
		[Token(Token = "0x6003126")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003127")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x17000A77")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GuildInformation> Guilds
	{
		[Token(Token = "0x6003128")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600311F")]
	[Address(RVA = "0x9DD960", Offset = "0x9DCD60", VA = "0x1809DD960")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildSummaryEvent()
	{
	}

	[Token(Token = "0x6003120")]
	[Address(RVA = "0x9DD9E0", Offset = "0x9DCDE0", VA = "0x1809DD9E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildSummaryEvent(GuildSummaryEvent other)
	{
	}

	[Token(Token = "0x6003121")]
	[Address(RVA = "0x9DD370", Offset = "0x9DC770", VA = "0x1809DD370", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildSummaryEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003129")]
	[Address(RVA = "0x9DD4F0", Offset = "0x9DC8F0", VA = "0x1809DD4F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600312A")]
	[Address(RVA = "0x9DD440", Offset = "0x9DC840", VA = "0x1809DD440", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildSummaryEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600312B")]
	[Address(RVA = "0x9DD5E0", Offset = "0x9DC9E0", VA = "0x1809DD5E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600312C")]
	[Address(RVA = "0x9DD760", Offset = "0x9DCB60", VA = "0x1809DD760", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600312D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600312E")]
	[Address(RVA = "0x9DDD00", Offset = "0x9DD100", VA = "0x1809DDD00", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600312F")]
	[Address(RVA = "0x9DD230", Offset = "0x9DC630", VA = "0x1809DD230", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003130")]
	[Address(RVA = "0x9DD6B0", Offset = "0x9DCAB0", VA = "0x1809DD6B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildSummaryEvent other)
	{
	}

	[Token(Token = "0x6003131")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003132")]
	[Address(RVA = "0x9DDB90", Offset = "0x9DCF90", VA = "0x1809DDB90", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
