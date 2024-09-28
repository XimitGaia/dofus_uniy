using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x200062B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightPlacementSwapPositionsOfferEvent : IMessage<FightPlacementSwapPositionsOfferEvent>, IMessage, IEquatable<FightPlacementSwapPositionsOfferEvent>, IDeepCloneable<FightPlacementSwapPositionsOfferEvent>, IBufferMessage
{
	[Token(Token = "0x40015B6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightPlacementSwapPositionsOfferEvent> _parser;

	[Token(Token = "0x40015B7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40015B8")]
	public const int RequestIdFieldNumber = 1;

	[Token(Token = "0x40015B9")]
	[FieldOffset(Offset = "0x18")]
	private int requestId_;

	[Token(Token = "0x40015BA")]
	public const int RequesterIdFieldNumber = 2;

	[Token(Token = "0x40015BB")]
	[FieldOffset(Offset = "0x20")]
	private long requesterId_;

	[Token(Token = "0x40015BC")]
	public const int RequesterCellIdFieldNumber = 3;

	[Token(Token = "0x40015BD")]
	[FieldOffset(Offset = "0x28")]
	private int requesterCellId_;

	[Token(Token = "0x40015BE")]
	public const int TargetIdFieldNumber = 4;

	[Token(Token = "0x40015BF")]
	[FieldOffset(Offset = "0x30")]
	private long targetId_;

	[Token(Token = "0x40015C0")]
	public const int TargetCellIdFieldNumber = 5;

	[Token(Token = "0x40015C1")]
	[FieldOffset(Offset = "0x38")]
	private int targetCellId_;

	[Token(Token = "0x17000E2E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightPlacementSwapPositionsOfferEvent> Parser
	{
		[Token(Token = "0x6004205")]
		[Address(RVA = "0xA81810", Offset = "0xA80C10", VA = "0x180A81810")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E2F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004206")]
		[Address(RVA = "0xA81760", Offset = "0xA80B60", VA = "0x180A81760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E30")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004207")]
		[Address(RVA = "0xA81A60", Offset = "0xA80E60", VA = "0x180A81A60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E31")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RequestId
	{
		[Token(Token = "0x600420B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600420C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000E32")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long RequesterId
	{
		[Token(Token = "0x600420D")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600420E")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000E33")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int RequesterCellId
	{
		[Token(Token = "0x600420F")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004210")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17000E34")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long TargetId
	{
		[Token(Token = "0x6004211")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6004212")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000E35")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TargetCellId
	{
		[Token(Token = "0x6004213")]
		[Address(RVA = "0x8F8300", Offset = "0x8F7700", VA = "0x1808F8300")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004214")]
		[Address(RVA = "0x947110", Offset = "0x946510", VA = "0x180947110")]
		set
		{
		}
	}

	[Token(Token = "0x6004208")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPlacementSwapPositionsOfferEvent()
	{
	}

	[Token(Token = "0x6004209")]
	[Address(RVA = "0xA816F0", Offset = "0xA80AF0", VA = "0x180A816F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightPlacementSwapPositionsOfferEvent(FightPlacementSwapPositionsOfferEvent other)
	{
	}

	[Token(Token = "0x600420A")]
	[Address(RVA = "0xA81290", Offset = "0xA80690", VA = "0x180A81290", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPlacementSwapPositionsOfferEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004215")]
	[Address(RVA = "0xA81330", Offset = "0xA80730", VA = "0x180A81330", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004216")]
	[Address(RVA = "0xA813E0", Offset = "0xA807E0", VA = "0x180A813E0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightPlacementSwapPositionsOfferEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004217")]
	[Address(RVA = "0xA81430", Offset = "0xA80830", VA = "0x180A81430", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004218")]
	[Address(RVA = "0xA81590", Offset = "0xA80990", VA = "0x180A81590", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004219")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600421A")]
	[Address(RVA = "0xA81980", Offset = "0xA80D80", VA = "0x180A81980", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600421B")]
	[Address(RVA = "0xA81150", Offset = "0xA80550", VA = "0x180A81150", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600421C")]
	[Address(RVA = "0xA81510", Offset = "0xA80910", VA = "0x180A81510", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightPlacementSwapPositionsOfferEvent other)
	{
	}

	[Token(Token = "0x600421D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600421E")]
	[Address(RVA = "0xA81860", Offset = "0xA80C60", VA = "0x180A81860", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
