using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x20001D3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Equipment : IMessage<Equipment>, IMessage, IEquatable<Equipment>, IDeepCloneable<Equipment>, IBufferMessage
{
	[Token(Token = "0x4000638")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<Equipment> _parser;

	[Token(Token = "0x4000639")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400063A")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x400063B")]
	public const int GidFieldNumber = 1;

	[Token(Token = "0x400063C")]
	[FieldOffset(Offset = "0x1C")]
	private int gid_;

	[Token(Token = "0x400063D")]
	public const int UidFieldNumber = 2;

	[Token(Token = "0x400063E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int UidDefaultValue;

	[Token(Token = "0x400063F")]
	[FieldOffset(Offset = "0x20")]
	private int uid_;

	[Token(Token = "0x4000640")]
	public const int EffectsFieldNumber = 3;

	[Token(Token = "0x4000641")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<ObjectEffect> _repeated_effects_codec;

	[Token(Token = "0x4000642")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<ObjectEffect> effects_;

	[Token(Token = "0x170003FB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Equipment> Parser
	{
		[Token(Token = "0x6001294")]
		[Address(RVA = "0xCC2250", Offset = "0xCC1650", VA = "0x180CC2250")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003FC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001295")]
		[Address(RVA = "0xCC21A0", Offset = "0xCC15A0", VA = "0x180CC21A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003FD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001296")]
		[Address(RVA = "0xCC25A0", Offset = "0xCC19A0", VA = "0x180CC25A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003FE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Gid
	{
		[Token(Token = "0x600129A")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600129B")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170003FF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Uid
	{
		[Token(Token = "0x600129C")]
		[Address(RVA = "0xCC22A0", Offset = "0xCC16A0", VA = "0x180CC22A0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600129D")]
		[Address(RVA = "0x939960", Offset = "0x938D60", VA = "0x180939960")]
		set
		{
		}
	}

	[Token(Token = "0x17000400")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool HasUid
	{
		[Token(Token = "0x600129E")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000401")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<ObjectEffect> Effects
	{
		[Token(Token = "0x60012A0")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001297")]
	[Address(RVA = "0xCC2080", Offset = "0xCC1480", VA = "0x180CC2080")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Equipment()
	{
	}

	[Token(Token = "0x6001298")]
	[Address(RVA = "0xCC2100", Offset = "0xCC1500", VA = "0x180CC2100")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Equipment(Equipment other)
	{
	}

	[Token(Token = "0x6001299")]
	[Address(RVA = "0xCC1A40", Offset = "0xCC0E40", VA = "0x180CC1A40", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Equipment Clone()
	{
		return null;
	}

	[Token(Token = "0x600129F")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearUid()
	{
	}

	[Token(Token = "0x60012A1")]
	[Address(RVA = "0xCC1B10", Offset = "0xCC0F10", VA = "0x180CC1B10", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60012A2")]
	[Address(RVA = "0xCC1C10", Offset = "0xCC1010", VA = "0x180CC1C10", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Equipment other)
	{
		return default(bool);
	}

	[Token(Token = "0x60012A3")]
	[Address(RVA = "0xCC1CD0", Offset = "0xCC10D0", VA = "0x180CC1CD0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60012A4")]
	[Address(RVA = "0xCC1E60", Offset = "0xCC1260", VA = "0x180CC1E60", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60012A5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60012A6")]
	[Address(RVA = "0xCC2460", Offset = "0xCC1860", VA = "0x180CC2460", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60012A7")]
	[Address(RVA = "0xCC18E0", Offset = "0xCC0CE0", VA = "0x180CC18E0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60012A8")]
	[Address(RVA = "0xCC1DC0", Offset = "0xCC11C0", VA = "0x180CC1DC0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(Equipment other)
	{
	}

	[Token(Token = "0x60012A9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60012AA")]
	[Address(RVA = "0xCC2310", Offset = "0xCC1710", VA = "0x180CC2310", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
