using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.House;

[Token(Token = "0x20004D1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildHouseUpdateEvent : IMessage<GuildHouseUpdateEvent>, IMessage, IEquatable<GuildHouseUpdateEvent>, IDeepCloneable<GuildHouseUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4001073")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildHouseUpdateEvent> _parser;

	[Token(Token = "0x4001074")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001075")]
	public const int HouseFieldNumber = 1;

	[Token(Token = "0x4001076")]
	[FieldOffset(Offset = "0x18")]
	private Com.Ankama.Dofus.Server.Game.Protocol.Common.House house_;

	[Token(Token = "0x17000ACD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildHouseUpdateEvent> Parser
	{
		[Token(Token = "0x60032DA")]
		[Address(RVA = "0x9F4420", Offset = "0x9F3820", VA = "0x1809F4420")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ACE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60032DB")]
		[Address(RVA = "0x9F4370", Offset = "0x9F3770", VA = "0x1809F4370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ACF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60032DC")]
		[Address(RVA = "0x9F4570", Offset = "0x9F3970", VA = "0x1809F4570", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Com.Ankama.Dofus.Server.Game.Protocol.Common.House House
	{
		[Token(Token = "0x60032E0")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60032E1")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x60032DD")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildHouseUpdateEvent()
	{
	}

	[Token(Token = "0x60032DE")]
	[Address(RVA = "0x9F4300", Offset = "0x9F3700", VA = "0x1809F4300")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildHouseUpdateEvent(GuildHouseUpdateEvent other)
	{
	}

	[Token(Token = "0x60032DF")]
	[Address(RVA = "0x9F3F80", Offset = "0x9F3380", VA = "0x1809F3F80", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildHouseUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60032E2")]
	[Address(RVA = "0x9F4020", Offset = "0x9F3420", VA = "0x1809F4020", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60032E3")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildHouseUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60032E4")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60032E5")]
	[Address(RVA = "0x9F41A0", Offset = "0x9F35A0", VA = "0x1809F41A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60032E6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60032E7")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60032E8")]
	[Address(RVA = "0x9F3EF0", Offset = "0x9F32F0", VA = "0x1809F3EF0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60032E9")]
	[Address(RVA = "0x9F40D0", Offset = "0x9F34D0", VA = "0x1809F40D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildHouseUpdateEvent other)
	{
	}

	[Token(Token = "0x60032EA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60032EB")]
	[Address(RVA = "0x9F4470", Offset = "0x9F3870", VA = "0x1809F4470", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
