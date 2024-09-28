using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x200053A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapRunningFightDetailsEvent : IMessage<MapRunningFightDetailsEvent>, IMessage, IEquatable<MapRunningFightDetailsEvent>, IDeepCloneable<MapRunningFightDetailsEvent>, IBufferMessage
{
	[Token(Token = "0x40011BB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapRunningFightDetailsEvent> _parser;

	[Token(Token = "0x40011BC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40011BD")]
	public const int FightIdFieldNumber = 1;

	[Token(Token = "0x40011BE")]
	[FieldOffset(Offset = "0x18")]
	private int fightId_;

	[Token(Token = "0x40011BF")]
	public const int AttackersFieldNumber = 2;

	[Token(Token = "0x40011C0")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<FighterLightInformation> _repeated_attackers_codec;

	[Token(Token = "0x40011C1")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<FighterLightInformation> attackers_;

	[Token(Token = "0x40011C2")]
	public const int DefendersFieldNumber = 3;

	[Token(Token = "0x40011C3")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<FighterLightInformation> _repeated_defenders_codec;

	[Token(Token = "0x40011C4")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<FighterLightInformation> defenders_;

	[Token(Token = "0x17000BBA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MapRunningFightDetailsEvent> Parser
	{
		[Token(Token = "0x6003769")]
		[Address(RVA = "0xA0C690", Offset = "0xA0BA90", VA = "0x180A0C690")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BBB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600376A")]
		[Address(RVA = "0xA0C5E0", Offset = "0xA0B9E0", VA = "0x180A0C5E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BBC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600376B")]
		[Address(RVA = "0xA0C960", Offset = "0xA0BD60", VA = "0x180A0C960", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BBD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FightId
	{
		[Token(Token = "0x600376F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003770")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000BBE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<FighterLightInformation> Attackers
	{
		[Token(Token = "0x6003771")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BBF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<FighterLightInformation> Defenders
	{
		[Token(Token = "0x6003772")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600376C")]
	[Address(RVA = "0xA0C530", Offset = "0xA0B930", VA = "0x180A0C530")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRunningFightDetailsEvent()
	{
	}

	[Token(Token = "0x600376D")]
	[Address(RVA = "0xA0C470", Offset = "0xA0B870", VA = "0x180A0C470")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRunningFightDetailsEvent(MapRunningFightDetailsEvent other)
	{
	}

	[Token(Token = "0x600376E")]
	[Address(RVA = "0xA0BEB0", Offset = "0xA0B2B0", VA = "0x180A0BEB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRunningFightDetailsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003773")]
	[Address(RVA = "0xA0C050", Offset = "0xA0B450", VA = "0x180A0C050", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003774")]
	[Address(RVA = "0xA0BF90", Offset = "0xA0B390", VA = "0x180A0BF90", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapRunningFightDetailsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003775")]
	[Address(RVA = "0x9A8E80", Offset = "0x9A8280", VA = "0x1809A8E80", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003776")]
	[Address(RVA = "0xA0C1F0", Offset = "0xA0B5F0", VA = "0x180A0C1F0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003777")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003778")]
	[Address(RVA = "0xA0C860", Offset = "0xA0BC60", VA = "0x180A0C860", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003779")]
	[Address(RVA = "0xA0BDA0", Offset = "0xA0B1A0", VA = "0x180A0BDA0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600377A")]
	[Address(RVA = "0xA0C150", Offset = "0xA0B550", VA = "0x180A0C150", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapRunningFightDetailsEvent other)
	{
	}

	[Token(Token = "0x600377B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600377C")]
	[Address(RVA = "0xA0C6E0", Offset = "0xA0BAE0", VA = "0x180A0C6E0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
