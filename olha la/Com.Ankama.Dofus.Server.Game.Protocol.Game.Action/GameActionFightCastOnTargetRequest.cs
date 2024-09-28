using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action;

[Token(Token = "0x200055F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GameActionFightCastOnTargetRequest : IMessage<GameActionFightCastOnTargetRequest>, IMessage, IEquatable<GameActionFightCastOnTargetRequest>, IDeepCloneable<GameActionFightCastOnTargetRequest>, IBufferMessage
{
	[Token(Token = "0x400126E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GameActionFightCastOnTargetRequest> _parser;

	[Token(Token = "0x400126F")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001270")]
	public const int SpellIdFieldNumber = 1;

	[Token(Token = "0x4001271")]
	[FieldOffset(Offset = "0x18")]
	private int spellId_;

	[Token(Token = "0x4001272")]
	public const int TargetIdFieldNumber = 2;

	[Token(Token = "0x4001273")]
	[FieldOffset(Offset = "0x20")]
	private long targetId_;

	[Token(Token = "0x17000C19")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GameActionFightCastOnTargetRequest> Parser
	{
		[Token(Token = "0x60038EB")]
		[Address(RVA = "0xA12FE0", Offset = "0xA123E0", VA = "0x180A12FE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C1A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60038EC")]
		[Address(RVA = "0xA12F30", Offset = "0xA12330", VA = "0x180A12F30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C1B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60038ED")]
		[Address(RVA = "0xA13030", Offset = "0xA12430", VA = "0x180A13030", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C1C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SpellId
	{
		[Token(Token = "0x60038F1")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60038F2")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000C1D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long TargetId
	{
		[Token(Token = "0x60038F3")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60038F4")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x60038EE")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionFightCastOnTargetRequest()
	{
	}

	[Token(Token = "0x60038EF")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionFightCastOnTargetRequest(GameActionFightCastOnTargetRequest other)
	{
	}

	[Token(Token = "0x60038F0")]
	[Address(RVA = "0xA12CA0", Offset = "0xA120A0", VA = "0x180A12CA0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionFightCastOnTargetRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60038F5")]
	[Address(RVA = "0xA12D30", Offset = "0xA12130", VA = "0x180A12D30", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60038F6")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GameActionFightCastOnTargetRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60038F7")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60038F8")]
	[Address(RVA = "0xA12DD0", Offset = "0xA121D0", VA = "0x180A12DD0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60038F9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60038FA")]
	[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60038FB")]
	[Address(RVA = "0xA12BE0", Offset = "0xA11FE0", VA = "0x180A12BE0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60038FC")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GameActionFightCastOnTargetRequest other)
	{
	}

	[Token(Token = "0x60038FD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60038FE")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
