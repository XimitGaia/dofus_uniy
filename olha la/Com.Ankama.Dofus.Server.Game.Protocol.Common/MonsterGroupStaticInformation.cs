using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AC1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonsterGroupStaticInformation : IMessage<MonsterGroupStaticInformation>, IMessage, IEquatable<MonsterGroupStaticInformation>, IDeepCloneable<MonsterGroupStaticInformation>, IBufferMessage
{
	[Token(Token = "0x400275A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MonsterGroupStaticInformation> _parser;

	[Token(Token = "0x400275B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400275C")]
	public const int MainCreatureFieldNumber = 1;

	[Token(Token = "0x400275D")]
	[FieldOffset(Offset = "0x18")]
	private MonsterInGroupInformation mainCreature_;

	[Token(Token = "0x400275E")]
	public const int UnderlingsFieldNumber = 2;

	[Token(Token = "0x400275F")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<MonsterInGroupInformation> _repeated_underlings_codec;

	[Token(Token = "0x4002760")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<MonsterInGroupInformation> underlings_;

	[Token(Token = "0x4002761")]
	public const int AlternativesFieldNumber = 3;

	[Token(Token = "0x4002762")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<MonstersInGroupAlternativeInformation> _repeated_alternatives_codec;

	[Token(Token = "0x4002763")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<MonstersInGroupAlternativeInformation> alternatives_;

	[Token(Token = "0x1700188F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MonsterGroupStaticInformation> Parser
	{
		[Token(Token = "0x60070A6")]
		[Address(RVA = "0xBE42A0", Offset = "0xBE36A0", VA = "0x180BE42A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001890")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60070A7")]
		[Address(RVA = "0xBE41F0", Offset = "0xBE35F0", VA = "0x180BE41F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001891")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60070A8")]
		[Address(RVA = "0xBE45D0", Offset = "0xBE39D0", VA = "0x180BE45D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001892")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MonsterInGroupInformation MainCreature
	{
		[Token(Token = "0x60070AC")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60070AD")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001893")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MonsterInGroupInformation> Underlings
	{
		[Token(Token = "0x60070AE")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001894")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<MonstersInGroupAlternativeInformation> Alternatives
	{
		[Token(Token = "0x60070AF")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60070A9")]
	[Address(RVA = "0xBE3FB0", Offset = "0xBE33B0", VA = "0x180BE3FB0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterGroupStaticInformation()
	{
	}

	[Token(Token = "0x60070AA")]
	[Address(RVA = "0xBE4070", Offset = "0xBE3470", VA = "0x180BE4070")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterGroupStaticInformation(MonsterGroupStaticInformation other)
	{
	}

	[Token(Token = "0x60070AB")]
	[Address(RVA = "0xBE3810", Offset = "0xBE2C10", VA = "0x180BE3810", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonsterGroupStaticInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x60070B0")]
	[Address(RVA = "0xBE3940", Offset = "0xBE2D40", VA = "0x180BE3940", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60070B1")]
	[Address(RVA = "0xBE3870", Offset = "0xBE2C70", VA = "0x180BE3870", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MonsterGroupStaticInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x60070B2")]
	[Address(RVA = "0xBE3A60", Offset = "0xBE2E60", VA = "0x180BE3A60", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60070B3")]
	[Address(RVA = "0xBE3D00", Offset = "0xBE3100", VA = "0x180BE3D00", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60070B4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60070B5")]
	[Address(RVA = "0xBE44C0", Offset = "0xBE38C0", VA = "0x180BE44C0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60070B6")]
	[Address(RVA = "0xBE36F0", Offset = "0xBE2AF0", VA = "0x180BE36F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60070B7")]
	[Address(RVA = "0xBE3B20", Offset = "0xBE2F20", VA = "0x180BE3B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonsterGroupStaticInformation other)
	{
	}

	[Token(Token = "0x60070B8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60070B9")]
	[Address(RVA = "0xBE42F0", Offset = "0xBE36F0", VA = "0x180BE42F0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
