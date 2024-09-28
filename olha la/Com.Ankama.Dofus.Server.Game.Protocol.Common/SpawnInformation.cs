using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000992")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpawnInformation : IMessage<SpawnInformation>, IMessage, IEquatable<SpawnInformation>, IDeepCloneable<SpawnInformation>, IBufferMessage
{
	[Token(Token = "0x4002188")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SpawnInformation> _parser;

	[Token(Token = "0x4002189")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400218A")]
	public const int TeamFieldNumber = 1;

	[Token(Token = "0x400218B")]
	[FieldOffset(Offset = "0x18")]
	private Team team_;

	[Token(Token = "0x400218C")]
	public const int AliveFieldNumber = 2;

	[Token(Token = "0x400218D")]
	[FieldOffset(Offset = "0x1C")]
	private bool alive_;

	[Token(Token = "0x400218E")]
	public const int PositionFieldNumber = 3;

	[Token(Token = "0x400218F")]
	[FieldOffset(Offset = "0x20")]
	private ActorPositionInformation position_;

	[Token(Token = "0x17001535")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SpawnInformation> Parser
	{
		[Token(Token = "0x60063AF")]
		[Address(RVA = "0xB9F100", Offset = "0xB9E500", VA = "0x180B9F100")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001536")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60063B0")]
		[Address(RVA = "0xB9F050", Offset = "0xB9E450", VA = "0x180B9F050")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001537")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60063B1")]
		[Address(RVA = "0xB9F330", Offset = "0xB9E730", VA = "0x180B9F330", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001538")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Team Team
	{
		[Token(Token = "0x60063B5")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Team);
		}
		[Token(Token = "0x60063B6")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001539")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Alive
	{
		[Token(Token = "0x60063B7")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60063B8")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x1700153A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActorPositionInformation Position
	{
		[Token(Token = "0x60063B9")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60063BA")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x60063B2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpawnInformation()
	{
	}

	[Token(Token = "0x60063B3")]
	[Address(RVA = "0xB9EFD0", Offset = "0xB9E3D0", VA = "0x180B9EFD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpawnInformation(SpawnInformation other)
	{
	}

	[Token(Token = "0x60063B4")]
	[Address(RVA = "0xB9EAC0", Offset = "0xB9DEC0", VA = "0x180B9EAC0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpawnInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x60063BB")]
	[Address(RVA = "0xB9EBF0", Offset = "0xB9DFF0", VA = "0x180B9EBF0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60063BC")]
	[Address(RVA = "0xB9EB70", Offset = "0xB9DF70", VA = "0x180B9EB70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpawnInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x60063BD")]
	[Address(RVA = "0xB9ECB0", Offset = "0xB9E0B0", VA = "0x180B9ECB0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60063BE")]
	[Address(RVA = "0xB9EE70", Offset = "0xB9E270", VA = "0x180B9EE70", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60063BF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60063C0")]
	[Address(RVA = "0xB9F290", Offset = "0xB9E690", VA = "0x180B9F290", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60063C1")]
	[Address(RVA = "0xB9EA00", Offset = "0xB9DE00", VA = "0x180B9EA00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60063C2")]
	[Address(RVA = "0xB9ED90", Offset = "0xB9E190", VA = "0x180B9ED90", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(SpawnInformation other)
	{
	}

	[Token(Token = "0x60063C3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60063C4")]
	[Address(RVA = "0xB9F150", Offset = "0xB9E550", VA = "0x180B9F150", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
