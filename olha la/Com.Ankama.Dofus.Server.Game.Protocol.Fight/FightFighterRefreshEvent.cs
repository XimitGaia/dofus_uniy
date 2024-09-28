using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x2000608")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightFighterRefreshEvent : IMessage<FightFighterRefreshEvent>, IMessage, IEquatable<FightFighterRefreshEvent>, IDeepCloneable<FightFighterRefreshEvent>, IBufferMessage
{
	[Token(Token = "0x4001522")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightFighterRefreshEvent> _parser;

	[Token(Token = "0x4001523")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001524")]
	public const int InformationFieldNumber = 1;

	[Token(Token = "0x4001525")]
	[FieldOffset(Offset = "0x18")]
	private ActorPositionInformation information_;

	[Token(Token = "0x17000DDA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightFighterRefreshEvent> Parser
	{
		[Token(Token = "0x6004081")]
		[Address(RVA = "0xA3DF80", Offset = "0xA3D380", VA = "0x180A3DF80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DDB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004082")]
		[Address(RVA = "0xA3DED0", Offset = "0xA3D2D0", VA = "0x180A3DED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DDC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004083")]
		[Address(RVA = "0xA3E0D0", Offset = "0xA3D4D0", VA = "0x180A3E0D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DDD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ActorPositionInformation Information
	{
		[Token(Token = "0x6004087")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004088")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6004084")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightFighterRefreshEvent()
	{
	}

	[Token(Token = "0x6004085")]
	[Address(RVA = "0xA3DE60", Offset = "0xA3D260", VA = "0x180A3DE60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightFighterRefreshEvent(FightFighterRefreshEvent other)
	{
	}

	[Token(Token = "0x6004086")]
	[Address(RVA = "0xA3DAE0", Offset = "0xA3CEE0", VA = "0x180A3DAE0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightFighterRefreshEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004089")]
	[Address(RVA = "0xA3DB80", Offset = "0xA3CF80", VA = "0x180A3DB80", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600408A")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightFighterRefreshEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600408B")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600408C")]
	[Address(RVA = "0xA3DD00", Offset = "0xA3D100", VA = "0x180A3DD00", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600408D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600408E")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600408F")]
	[Address(RVA = "0xA3DA50", Offset = "0xA3CE50", VA = "0x180A3DA50", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004090")]
	[Address(RVA = "0xA3DC30", Offset = "0xA3D030", VA = "0x180A3DC30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightFighterRefreshEvent other)
	{
	}

	[Token(Token = "0x6004091")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004092")]
	[Address(RVA = "0xA3DFD0", Offset = "0xA3D3D0", VA = "0x180A3DFD0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
