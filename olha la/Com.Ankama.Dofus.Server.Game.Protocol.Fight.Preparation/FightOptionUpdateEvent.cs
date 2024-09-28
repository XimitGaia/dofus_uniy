using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x2000631")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightOptionUpdateEvent : IMessage<FightOptionUpdateEvent>, IMessage, IEquatable<FightOptionUpdateEvent>, IDeepCloneable<FightOptionUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x40015D0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightOptionUpdateEvent> _parser;

	[Token(Token = "0x40015D1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40015D2")]
	public const int FightIdFieldNumber = 1;

	[Token(Token = "0x40015D3")]
	[FieldOffset(Offset = "0x18")]
	private int fightId_;

	[Token(Token = "0x40015D4")]
	public const int TeamFieldNumber = 2;

	[Token(Token = "0x40015D5")]
	[FieldOffset(Offset = "0x1C")]
	private Team team_;

	[Token(Token = "0x40015D6")]
	public const int OptionFieldNumber = 3;

	[Token(Token = "0x40015D7")]
	[FieldOffset(Offset = "0x20")]
	private FightOption option_;

	[Token(Token = "0x40015D8")]
	public const int StateFieldNumber = 4;

	[Token(Token = "0x40015D9")]
	[FieldOffset(Offset = "0x24")]
	private bool state_;

	[Token(Token = "0x17000E3F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightOptionUpdateEvent> Parser
	{
		[Token(Token = "0x6004250")]
		[Address(RVA = "0xA7E410", Offset = "0xA7D810", VA = "0x180A7E410")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E40")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004251")]
		[Address(RVA = "0xA7E360", Offset = "0xA7D760", VA = "0x180A7E360")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E41")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004252")]
		[Address(RVA = "0xA7E630", Offset = "0xA7DA30", VA = "0x180A7E630", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E42")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FightId
	{
		[Token(Token = "0x6004256")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004257")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000E43")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Team Team
	{
		[Token(Token = "0x6004258")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Team);
		}
		[Token(Token = "0x6004259")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000E44")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightOption Option
	{
		[Token(Token = "0x600425A")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(FightOption);
		}
		[Token(Token = "0x600425B")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000E45")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool State
	{
		[Token(Token = "0x600425C")]
		[Address(RVA = "0xA7E460", Offset = "0xA7D860", VA = "0x180A7E460")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600425D")]
		[Address(RVA = "0xA7E710", Offset = "0xA7DB10", VA = "0x180A7E710")]
		set
		{
		}
	}

	[Token(Token = "0x6004253")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightOptionUpdateEvent()
	{
	}

	[Token(Token = "0x6004254")]
	[Address(RVA = "0xA7E300", Offset = "0xA7D700", VA = "0x180A7E300")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightOptionUpdateEvent(FightOptionUpdateEvent other)
	{
	}

	[Token(Token = "0x6004255")]
	[Address(RVA = "0xA7DEB0", Offset = "0xA7D2B0", VA = "0x180A7DEB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightOptionUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600425E")]
	[Address(RVA = "0xA7DF40", Offset = "0xA7D340", VA = "0x180A7DF40", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600425F")]
	[Address(RVA = "0xA7DFE0", Offset = "0xA7D3E0", VA = "0x180A7DFE0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightOptionUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004260")]
	[Address(RVA = "0xA7E030", Offset = "0xA7D430", VA = "0x180A7E030", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004261")]
	[Address(RVA = "0xA7E1A0", Offset = "0xA7D5A0", VA = "0x180A7E1A0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004262")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004263")]
	[Address(RVA = "0xA7E570", Offset = "0xA7D970", VA = "0x180A7E570", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004264")]
	[Address(RVA = "0xA7DDC0", Offset = "0xA7D1C0", VA = "0x180A7DDC0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004265")]
	[Address(RVA = "0xA7E130", Offset = "0xA7D530", VA = "0x180A7E130", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightOptionUpdateEvent other)
	{
	}

	[Token(Token = "0x6004266")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004267")]
	[Address(RVA = "0xA7E470", Offset = "0xA7D870", VA = "0x180A7E470", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
