using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004A8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildLogbookEvent : IMessage<GuildLogbookEvent>, IMessage, IEquatable<GuildLogbookEvent>, IDeepCloneable<GuildLogbookEvent>, IBufferMessage
{
	[Token(Token = "0x4000FE8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildLogbookEvent> _parser;

	[Token(Token = "0x4000FE9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000FEA")]
	public const int GlobalActivitiesFieldNumber = 1;

	[Token(Token = "0x4000FEB")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<GuildLogbookEntry> _repeated_globalActivities_codec;

	[Token(Token = "0x4000FEC")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<GuildLogbookEntry> globalActivities_;

	[Token(Token = "0x4000FED")]
	public const int ChestActivitiesFieldNumber = 2;

	[Token(Token = "0x4000FEE")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<GuildLogbookEntry> _repeated_chestActivities_codec;

	[Token(Token = "0x4000FEF")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<GuildLogbookEntry> chestActivities_;

	[Token(Token = "0x17000A6C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildLogbookEvent> Parser
	{
		[Token(Token = "0x6003106")]
		[Address(RVA = "0x9D36A0", Offset = "0x9D2AA0", VA = "0x1809D36A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A6D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003107")]
		[Address(RVA = "0x9D35F0", Offset = "0x9D29F0", VA = "0x1809D35F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A6E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003108")]
		[Address(RVA = "0x9D3930", Offset = "0x9D2D30", VA = "0x1809D3930", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A6F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<GuildLogbookEntry> GlobalActivities
	{
		[Token(Token = "0x600310C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A70")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GuildLogbookEntry> ChestActivities
	{
		[Token(Token = "0x600310D")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003109")]
	[Address(RVA = "0x9D3490", Offset = "0x9D2890", VA = "0x1809D3490")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildLogbookEvent()
	{
	}

	[Token(Token = "0x600310A")]
	[Address(RVA = "0x9D3540", Offset = "0x9D2940", VA = "0x1809D3540")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildLogbookEvent(GuildLogbookEvent other)
	{
	}

	[Token(Token = "0x600310B")]
	[Address(RVA = "0x9D2EF0", Offset = "0x9D22F0", VA = "0x1809D2EF0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildLogbookEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600310E")]
	[Address(RVA = "0x9D2FD0", Offset = "0x9D23D0", VA = "0x1809D2FD0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600310F")]
	[Address(RVA = "0x9D30C0", Offset = "0x9D24C0", VA = "0x1809D30C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildLogbookEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003110")]
	[Address(RVA = "0x943E20", Offset = "0x943220", VA = "0x180943E20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003111")]
	[Address(RVA = "0x9D3210", Offset = "0x9D2610", VA = "0x1809D3210", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003112")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003113")]
	[Address(RVA = "0x9D3850", Offset = "0x9D2C50", VA = "0x1809D3850", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003114")]
	[Address(RVA = "0x9D2E10", Offset = "0x9D2210", VA = "0x1809D2E10", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003115")]
	[Address(RVA = "0x9D3170", Offset = "0x9D2570", VA = "0x1809D3170", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildLogbookEvent other)
	{
	}

	[Token(Token = "0x6003116")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003117")]
	[Address(RVA = "0x9D36F0", Offset = "0x9D2AF0", VA = "0x1809D36F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
