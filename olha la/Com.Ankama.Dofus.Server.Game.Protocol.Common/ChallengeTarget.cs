using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009A6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeTarget : IMessage<ChallengeTarget>, IMessage, IEquatable<ChallengeTarget>, IDeepCloneable<ChallengeTarget>, IBufferMessage
{
	[Token(Token = "0x40021F6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChallengeTarget> _parser;

	[Token(Token = "0x40021F7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40021F8")]
	public const int TargetIdFieldNumber = 1;

	[Token(Token = "0x40021F9")]
	[FieldOffset(Offset = "0x18")]
	private long targetId_;

	[Token(Token = "0x40021FA")]
	public const int TargetCellFieldNumber = 2;

	[Token(Token = "0x40021FB")]
	[FieldOffset(Offset = "0x20")]
	private int targetCell_;

	[Token(Token = "0x40021FC")]
	public const int AttackersIdFieldNumber = 3;

	[Token(Token = "0x40021FD")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<long> _repeated_attackersId_codec;

	[Token(Token = "0x40021FE")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<long> attackersId_;

	[Token(Token = "0x1700156F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ChallengeTarget> Parser
	{
		[Token(Token = "0x6006482")]
		[Address(RVA = "0xB91430", Offset = "0xB90830", VA = "0x180B91430")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001570")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006483")]
		[Address(RVA = "0xB91380", Offset = "0xB90780", VA = "0x180B91380")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001571")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006484")]
		[Address(RVA = "0xB916D0", Offset = "0xB90AD0", VA = "0x180B916D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001572")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long TargetId
	{
		[Token(Token = "0x6006488")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6006489")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001573")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TargetCell
	{
		[Token(Token = "0x600648A")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600648B")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17001574")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<long> AttackersId
	{
		[Token(Token = "0x600648C")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006485")]
	[Address(RVA = "0xB91260", Offset = "0xB90660", VA = "0x180B91260")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChallengeTarget()
	{
	}

	[Token(Token = "0x6006486")]
	[Address(RVA = "0xB912E0", Offset = "0xB906E0", VA = "0x180B912E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChallengeTarget(ChallengeTarget other)
	{
	}

	[Token(Token = "0x6006487")]
	[Address(RVA = "0xB90DD0", Offset = "0xB901D0", VA = "0x180B90DD0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeTarget Clone()
	{
		return null;
	}

	[Token(Token = "0x600648D")]
	[Address(RVA = "0xB90EA0", Offset = "0xB902A0", VA = "0x180B90EA0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600648E")]
	[Address(RVA = "0xB90F90", Offset = "0xB90390", VA = "0x180B90F90", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeTarget other)
	{
		return default(bool);
	}

	[Token(Token = "0x600648F")]
	[Address(RVA = "0xAA90A0", Offset = "0xAA84A0", VA = "0x180AA90A0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006490")]
	[Address(RVA = "0xB910D0", Offset = "0xB904D0", VA = "0x180B910D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006491")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006492")]
	[Address(RVA = "0xB915D0", Offset = "0xB909D0", VA = "0x180B915D0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006493")]
	[Address(RVA = "0xB90CC0", Offset = "0xB900C0", VA = "0x180B90CC0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006494")]
	[Address(RVA = "0xB91030", Offset = "0xB90430", VA = "0x180B91030", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeTarget other)
	{
	}

	[Token(Token = "0x6006495")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006496")]
	[Address(RVA = "0xB91480", Offset = "0xB90880", VA = "0x180B91480", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
