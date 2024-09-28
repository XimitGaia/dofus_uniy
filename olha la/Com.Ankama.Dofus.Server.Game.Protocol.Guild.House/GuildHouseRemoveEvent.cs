using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.House;

[Token(Token = "0x20004D3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildHouseRemoveEvent : IMessage<GuildHouseRemoveEvent>, IMessage, IEquatable<GuildHouseRemoveEvent>, IDeepCloneable<GuildHouseRemoveEvent>, IBufferMessage
{
	[Token(Token = "0x4001078")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildHouseRemoveEvent> _parser;

	[Token(Token = "0x4001079")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400107A")]
	public const int HouseIdFieldNumber = 1;

	[Token(Token = "0x400107B")]
	[FieldOffset(Offset = "0x18")]
	private int houseId_;

	[Token(Token = "0x400107C")]
	public const int InstanceIdFieldNumber = 2;

	[Token(Token = "0x400107D")]
	[FieldOffset(Offset = "0x1C")]
	private int instanceId_;

	[Token(Token = "0x400107E")]
	public const int SecondHandFieldNumber = 3;

	[Token(Token = "0x400107F")]
	[FieldOffset(Offset = "0x20")]
	private bool secondHand_;

	[Token(Token = "0x17000AD1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildHouseRemoveEvent> Parser
	{
		[Token(Token = "0x60032F0")]
		[Address(RVA = "0x9F3DC0", Offset = "0x9F31C0", VA = "0x1809F3DC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AD2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60032F1")]
		[Address(RVA = "0x9F3D10", Offset = "0x9F3110", VA = "0x1809F3D10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AD3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60032F2")]
		[Address(RVA = "0x9F3E10", Offset = "0x9F3210", VA = "0x1809F3E10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AD4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HouseId
	{
		[Token(Token = "0x60032F6")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60032F7")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000AD5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int InstanceId
	{
		[Token(Token = "0x60032F8")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60032F9")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000AD6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool SecondHand
	{
		[Token(Token = "0x60032FA")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60032FB")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x60032F3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildHouseRemoveEvent()
	{
	}

	[Token(Token = "0x60032F4")]
	[Address(RVA = "0x92C240", Offset = "0x92B640", VA = "0x18092C240")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildHouseRemoveEvent(GuildHouseRemoveEvent other)
	{
	}

	[Token(Token = "0x60032F5")]
	[Address(RVA = "0x9F39A0", Offset = "0x9F2DA0", VA = "0x1809F39A0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildHouseRemoveEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60032FC")]
	[Address(RVA = "0x9F3A30", Offset = "0x9F2E30", VA = "0x1809F3A30", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60032FD")]
	[Address(RVA = "0x92BF50", Offset = "0x92B350", VA = "0x18092BF50", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildHouseRemoveEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60032FE")]
	[Address(RVA = "0x9F3AD0", Offset = "0x9F2ED0", VA = "0x1809F3AD0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60032FF")]
	[Address(RVA = "0x9F3BB0", Offset = "0x9F2FB0", VA = "0x1809F3BB0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003300")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003301")]
	[Address(RVA = "0x98A3B0", Offset = "0x9897B0", VA = "0x18098A3B0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003302")]
	[Address(RVA = "0x9F38E0", Offset = "0x9F2CE0", VA = "0x1809F38E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003303")]
	[Address(RVA = "0x92C070", Offset = "0x92B470", VA = "0x18092C070", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildHouseRemoveEvent other)
	{
	}

	[Token(Token = "0x6003304")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003305")]
	[Address(RVA = "0x92C3A0", Offset = "0x92B7A0", VA = "0x18092C3A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
