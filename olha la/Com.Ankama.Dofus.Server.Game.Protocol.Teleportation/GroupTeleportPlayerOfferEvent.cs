using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation;

[Token(Token = "0x2000085")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GroupTeleportPlayerOfferEvent : IMessage<GroupTeleportPlayerOfferEvent>, IMessage, IEquatable<GroupTeleportPlayerOfferEvent>, IDeepCloneable<GroupTeleportPlayerOfferEvent>, IBufferMessage
{
	[Token(Token = "0x40001B2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GroupTeleportPlayerOfferEvent> _parser;

	[Token(Token = "0x40001B3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40001B4")]
	public const int MapIdFieldNumber = 1;

	[Token(Token = "0x40001B5")]
	[FieldOffset(Offset = "0x18")]
	private long mapId_;

	[Token(Token = "0x40001B6")]
	public const int WorldXFieldNumber = 2;

	[Token(Token = "0x40001B7")]
	[FieldOffset(Offset = "0x20")]
	private int worldX_;

	[Token(Token = "0x40001B8")]
	public const int WorldYFieldNumber = 3;

	[Token(Token = "0x40001B9")]
	[FieldOffset(Offset = "0x24")]
	private int worldY_;

	[Token(Token = "0x40001BA")]
	public const int TimeLeftFieldNumber = 4;

	[Token(Token = "0x40001BB")]
	[FieldOffset(Offset = "0x28")]
	private int timeLeft_;

	[Token(Token = "0x40001BC")]
	public const int RequesterIdFieldNumber = 5;

	[Token(Token = "0x40001BD")]
	[FieldOffset(Offset = "0x30")]
	private long requesterId_;

	[Token(Token = "0x40001BE")]
	public const int RequesterNameFieldNumber = 6;

	[Token(Token = "0x40001BF")]
	[FieldOffset(Offset = "0x38")]
	private string requesterName_;

	[Token(Token = "0x17000100")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GroupTeleportPlayerOfferEvent> Parser
	{
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x952820", Offset = "0x951C20", VA = "0x180952820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000101")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x952770", Offset = "0x951B70", VA = "0x180952770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000102")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x952AD0", Offset = "0x951ED0", VA = "0x180952AD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000103")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MapId
	{
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17000104")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int WorldX
	{
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000105")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int WorldY
	{
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000106")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TimeLeft
	{
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17000107")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long RequesterId
	{
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000108")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string RequesterName
	{
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x952BC0", Offset = "0x951FC0", VA = "0x180952BC0")]
		set
		{
		}
	}

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x952720", Offset = "0x951B20", VA = "0x180952720")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupTeleportPlayerOfferEvent()
	{
	}

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x952660", Offset = "0x951A60", VA = "0x180952660")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GroupTeleportPlayerOfferEvent(GroupTeleportPlayerOfferEvent other)
	{
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x952100", Offset = "0x951500", VA = "0x180952100", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupTeleportPlayerOfferEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x9521F0", Offset = "0x9515F0", VA = "0x1809521F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x9522D0", Offset = "0x9516D0", VA = "0x1809522D0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GroupTeleportPlayerOfferEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x952360", Offset = "0x951760", VA = "0x180952360", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x952500", Offset = "0x951900", VA = "0x180952500", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x9529C0", Offset = "0x951DC0", VA = "0x1809529C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x951FA0", Offset = "0x9513A0", VA = "0x180951FA0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x952460", Offset = "0x951860", VA = "0x180952460", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GroupTeleportPlayerOfferEvent other)
	{
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x952870", Offset = "0x951C70", VA = "0x180952870", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
