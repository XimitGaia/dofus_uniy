using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A55")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightEffectTriggerCount : IMessage<FightEffectTriggerCount>, IMessage, IEquatable<FightEffectTriggerCount>, IDeepCloneable<FightEffectTriggerCount>, IBufferMessage
{
	[Token(Token = "0x400255E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightEffectTriggerCount> _parser;

	[Token(Token = "0x400255F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002560")]
	public const int EffectIdFieldNumber = 1;

	[Token(Token = "0x4002561")]
	[FieldOffset(Offset = "0x18")]
	private int effectId_;

	[Token(Token = "0x4002562")]
	public const int TargetIdFieldNumber = 2;

	[Token(Token = "0x4002563")]
	[FieldOffset(Offset = "0x20")]
	private long targetId_;

	[Token(Token = "0x4002564")]
	public const int CountFieldNumber = 3;

	[Token(Token = "0x4002565")]
	[FieldOffset(Offset = "0x28")]
	private int count_;

	[Token(Token = "0x17001762")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightEffectTriggerCount> Parser
	{
		[Token(Token = "0x6006BFC")]
		[Address(RVA = "0xBC9C40", Offset = "0xBC9040", VA = "0x180BC9C40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001763")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006BFD")]
		[Address(RVA = "0xBC9B90", Offset = "0xBC8F90", VA = "0x180BC9B90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001764")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006BFE")]
		[Address(RVA = "0xBC9C90", Offset = "0xBC9090", VA = "0x180BC9C90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001765")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int EffectId
	{
		[Token(Token = "0x6006C02")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006C03")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001766")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long TargetId
	{
		[Token(Token = "0x6006C04")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006C05")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001767")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Count
	{
		[Token(Token = "0x6006C06")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006C07")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x6006BFF")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightEffectTriggerCount()
	{
	}

	[Token(Token = "0x6006C00")]
	[Address(RVA = "0x963AD0", Offset = "0x962ED0", VA = "0x180963AD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightEffectTriggerCount(FightEffectTriggerCount other)
	{
	}

	[Token(Token = "0x6006C01")]
	[Address(RVA = "0xBC9900", Offset = "0xBC8D00", VA = "0x180BC9900", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightEffectTriggerCount Clone()
	{
		return null;
	}

	[Token(Token = "0x6006C08")]
	[Address(RVA = "0xBC9990", Offset = "0xBC8D90", VA = "0x180BC9990", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006C09")]
	[Address(RVA = "0x963810", Offset = "0x962C10", VA = "0x180963810", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightEffectTriggerCount other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006C0A")]
	[Address(RVA = "0x963850", Offset = "0x962C50", VA = "0x180963850", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006C0B")]
	[Address(RVA = "0xBC9A30", Offset = "0xBC8E30", VA = "0x180BC9A30", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006C0C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006C0D")]
	[Address(RVA = "0x963D00", Offset = "0x963100", VA = "0x180963D00", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006C0E")]
	[Address(RVA = "0xBC9820", Offset = "0xBC8C20", VA = "0x180BC9820", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006C0F")]
	[Address(RVA = "0x963900", Offset = "0x962D00", VA = "0x180963900", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightEffectTriggerCount other)
	{
	}

	[Token(Token = "0x6006C10")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006C11")]
	[Address(RVA = "0x963C30", Offset = "0x963030", VA = "0x180963C30", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
