using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000A1E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightCommonInformation : IMessage<FightCommonInformation>, IMessage, IEquatable<FightCommonInformation>, IDeepCloneable<FightCommonInformation>, IBufferMessage
{
	[Token(Token = "0x4002446")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightCommonInformation> _parser;

	[Token(Token = "0x4002447")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002448")]
	public const int FightIdFieldNumber = 1;

	[Token(Token = "0x4002449")]
	[FieldOffset(Offset = "0x18")]
	private int fightId_;

	[Token(Token = "0x400244A")]
	public const int TypeFieldNumber = 2;

	[Token(Token = "0x400244B")]
	[FieldOffset(Offset = "0x1C")]
	private FightType type_;

	[Token(Token = "0x400244C")]
	public const int TeamsInformationFieldNumber = 3;

	[Token(Token = "0x400244D")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<FightTeamInformation> _repeated_teamsInformation_codec;

	[Token(Token = "0x400244E")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<FightTeamInformation> teamsInformation_;

	[Token(Token = "0x400244F")]
	public const int TeamsPositionFieldNumber = 4;

	[Token(Token = "0x4002450")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<int> _repeated_teamsPosition_codec;

	[Token(Token = "0x4002451")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<int> teamsPosition_;

	[Token(Token = "0x4002452")]
	public const int TeamsOptionsFieldNumber = 5;

	[Token(Token = "0x4002453")]
	[FieldOffset(Offset = "0x18")]
	private static readonly FieldCodec<FightOptionsInformation> _repeated_teamsOptions_codec;

	[Token(Token = "0x4002454")]
	[FieldOffset(Offset = "0x30")]
	private readonly RepeatedField<FightOptionsInformation> teamsOptions_;

	[Token(Token = "0x170016C3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightCommonInformation> Parser
	{
		[Token(Token = "0x60069A0")]
		[Address(RVA = "0xBB51E0", Offset = "0xBB45E0", VA = "0x180BB51E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016C4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60069A1")]
		[Address(RVA = "0xBB5130", Offset = "0xBB4530", VA = "0x180BB5130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016C5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60069A2")]
		[Address(RVA = "0xBB55A0", Offset = "0xBB49A0", VA = "0x180BB55A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016C6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FightId
	{
		[Token(Token = "0x60069A6")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60069A7")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170016C7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightType Type
	{
		[Token(Token = "0x60069A8")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(FightType);
		}
		[Token(Token = "0x60069A9")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170016C8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FightTeamInformation> TeamsInformation
	{
		[Token(Token = "0x60069AA")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016C9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> TeamsPosition
	{
		[Token(Token = "0x60069AB")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016CA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FightOptionsInformation> TeamsOptions
	{
		[Token(Token = "0x60069AC")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60069A3")]
	[Address(RVA = "0xBB5030", Offset = "0xBB4430", VA = "0x180BB5030")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightCommonInformation()
	{
	}

	[Token(Token = "0x60069A4")]
	[Address(RVA = "0xBB4F30", Offset = "0xBB4330", VA = "0x180BB4F30")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightCommonInformation(FightCommonInformation other)
	{
	}

	[Token(Token = "0x60069A5")]
	[Address(RVA = "0xBB46E0", Offset = "0xBB3AE0", VA = "0x180BB46E0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightCommonInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x60069AD")]
	[Address(RVA = "0xBB4810", Offset = "0xBB3C10", VA = "0x180BB4810", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60069AE")]
	[Address(RVA = "0xBB4960", Offset = "0xBB3D60", VA = "0x180BB4960", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightCommonInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x60069AF")]
	[Address(RVA = "0xBB4A70", Offset = "0xBB3E70", VA = "0x180BB4A70", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60069B0")]
	[Address(RVA = "0xBB4C50", Offset = "0xBB4050", VA = "0x180BB4C50", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60069B1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60069B2")]
	[Address(RVA = "0xBB5440", Offset = "0xBB4840", VA = "0x180BB5440", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60069B3")]
	[Address(RVA = "0xBB4550", Offset = "0xBB3950", VA = "0x180BB4550", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60069B4")]
	[Address(RVA = "0xBB4B70", Offset = "0xBB3F70", VA = "0x180BB4B70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightCommonInformation other)
	{
	}

	[Token(Token = "0x60069B5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60069B6")]
	[Address(RVA = "0xBB5230", Offset = "0xBB4630", VA = "0x180BB5230", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
