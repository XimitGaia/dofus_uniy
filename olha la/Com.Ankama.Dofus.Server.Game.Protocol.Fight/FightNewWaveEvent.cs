using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x20005EF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightNewWaveEvent : IMessage<FightNewWaveEvent>, IMessage, IEquatable<FightNewWaveEvent>, IDeepCloneable<FightNewWaveEvent>, IBufferMessage
{
	[Token(Token = "0x40014CE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightNewWaveEvent> _parser;

	[Token(Token = "0x40014CF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40014D0")]
	public const int WaveIdFieldNumber = 1;

	[Token(Token = "0x40014D1")]
	[FieldOffset(Offset = "0x18")]
	private int waveId_;

	[Token(Token = "0x40014D2")]
	public const int TeamFieldNumber = 2;

	[Token(Token = "0x40014D3")]
	[FieldOffset(Offset = "0x1C")]
	private Team team_;

	[Token(Token = "0x40014D4")]
	public const int TurnLeftBeforeNextWaveFieldNumber = 3;

	[Token(Token = "0x40014D5")]
	[FieldOffset(Offset = "0x20")]
	private int turnLeftBeforeNextWave_;

	[Token(Token = "0x17000DA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightNewWaveEvent> Parser
	{
		[Token(Token = "0x6003F69")]
		[Address(RVA = "0xA416E0", Offset = "0xA40AE0", VA = "0x180A416E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DA1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003F6A")]
		[Address(RVA = "0xA41630", Offset = "0xA40A30", VA = "0x180A41630")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DA2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003F6B")]
		[Address(RVA = "0xA417D0", Offset = "0xA40BD0", VA = "0x180A417D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000DA3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int WaveId
	{
		[Token(Token = "0x6003F6F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003F70")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000DA4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Team Team
	{
		[Token(Token = "0x6003F71")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Team);
		}
		[Token(Token = "0x6003F72")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000DA5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int TurnLeftBeforeNextWave
	{
		[Token(Token = "0x6003F73")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003F74")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6003F6C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightNewWaveEvent()
	{
	}

	[Token(Token = "0x6003F6D")]
	[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightNewWaveEvent(FightNewWaveEvent other)
	{
	}

	[Token(Token = "0x6003F6E")]
	[Address(RVA = "0xA41300", Offset = "0xA40700", VA = "0x180A41300", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightNewWaveEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003F75")]
	[Address(RVA = "0xA41390", Offset = "0xA40790", VA = "0x180A41390", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003F76")]
	[Address(RVA = "0x947820", Offset = "0x946C20", VA = "0x180947820", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightNewWaveEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003F77")]
	[Address(RVA = "0xA41430", Offset = "0xA40830", VA = "0x180A41430", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003F78")]
	[Address(RVA = "0xA414D0", Offset = "0xA408D0", VA = "0x180A414D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003F79")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003F7A")]
	[Address(RVA = "0xA41730", Offset = "0xA40B30", VA = "0x180A41730", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003F7B")]
	[Address(RVA = "0xA41220", Offset = "0xA40620", VA = "0x180A41220", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003F7C")]
	[Address(RVA = "0x947910", Offset = "0x946D10", VA = "0x180947910", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightNewWaveEvent other)
	{
	}

	[Token(Token = "0x6003F7D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003F7E")]
	[Address(RVA = "0x947BE0", Offset = "0x946FE0", VA = "0x180947BE0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
