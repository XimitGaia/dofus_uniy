using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x200060E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightResume : IMessage<FightResume>, IMessage, IEquatable<FightResume>, IDeepCloneable<FightResume>, IBufferMessage
{
	[Token(Token = "0x4001547")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightResume> _parser;

	[Token(Token = "0x4001548")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001549")]
	public const int SpellsCoolDownFieldNumber = 1;

	[Token(Token = "0x400154A")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<FightSpellCoolDown> _repeated_spellsCoolDown_codec;

	[Token(Token = "0x400154B")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<FightSpellCoolDown> spellsCoolDown_;

	[Token(Token = "0x400154C")]
	public const int SummonCountFieldNumber = 2;

	[Token(Token = "0x400154D")]
	[FieldOffset(Offset = "0x20")]
	private int summonCount_;

	[Token(Token = "0x400154E")]
	public const int BombCountFieldNumber = 3;

	[Token(Token = "0x400154F")]
	[FieldOffset(Offset = "0x24")]
	private int bombCount_;

	[Token(Token = "0x4001550")]
	public const int SlavesInformationFieldNumber = 4;

	[Token(Token = "0x4001551")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<FightResumeSlaves> _repeated_slavesInformation_codec;

	[Token(Token = "0x4001552")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<FightResumeSlaves> slavesInformation_;

	[Token(Token = "0x17000DE3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightResume> Parser
	{
		[Token(Token = "0x60040AF")]
		[Address(RVA = "0xA489F0", Offset = "0xA47DF0", VA = "0x180A489F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DE4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60040B0")]
		[Address(RVA = "0xA48940", Offset = "0xA47D40", VA = "0x180A48940")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DE5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60040B1")]
		[Address(RVA = "0xA48D50", Offset = "0xA48150", VA = "0x180A48D50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DE6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FightSpellCoolDown> SpellsCoolDown
	{
		[Token(Token = "0x60040B5")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DE7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SummonCount
	{
		[Token(Token = "0x60040B6")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60040B7")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000DE8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int BombCount
	{
		[Token(Token = "0x60040B8")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60040B9")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000DE9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<FightResumeSlaves> SlavesInformation
	{
		[Token(Token = "0x60040BA")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60040B2")]
	[Address(RVA = "0xA487B0", Offset = "0xA47BB0", VA = "0x180A487B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightResume()
	{
	}

	[Token(Token = "0x60040B3")]
	[Address(RVA = "0xA48870", Offset = "0xA47C70", VA = "0x180A48870")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightResume(FightResume other)
	{
	}

	[Token(Token = "0x60040B4")]
	[Address(RVA = "0xA48090", Offset = "0xA47490", VA = "0x180A48090", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightResume Clone()
	{
		return null;
	}

	[Token(Token = "0x60040BB")]
	[Address(RVA = "0xA48260", Offset = "0xA47660", VA = "0x180A48260", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60040BC")]
	[Address(RVA = "0xA48190", Offset = "0xA47590", VA = "0x180A48190", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightResume other)
	{
		return default(bool);
	}

	[Token(Token = "0x60040BD")]
	[Address(RVA = "0xA48380", Offset = "0xA47780", VA = "0x180A48380", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60040BE")]
	[Address(RVA = "0xA48500", Offset = "0xA47900", VA = "0x180A48500", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60040BF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60040C0")]
	[Address(RVA = "0xA48C00", Offset = "0xA48000", VA = "0x180A48C00", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60040C1")]
	[Address(RVA = "0xA47F30", Offset = "0xA47330", VA = "0x180A47F30", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60040C2")]
	[Address(RVA = "0xA48440", Offset = "0xA47840", VA = "0x180A48440", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightResume other)
	{
	}

	[Token(Token = "0x60040C3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60040C4")]
	[Address(RVA = "0xA48A40", Offset = "0xA47E40", VA = "0x180A48A40", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
