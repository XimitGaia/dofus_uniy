using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Choice;

[Token(Token = "0x2000837")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class VotedChoice : IMessage<VotedChoice>, IMessage, IEquatable<VotedChoice>, IDeepCloneable<VotedChoice>, IBufferMessage
{
	[Token(Token = "0x4001C48")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<VotedChoice> _parser;

	[Token(Token = "0x4001C49")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001C4A")]
	public const int IdFieldNumber = 1;

	[Token(Token = "0x4001C4B")]
	[FieldOffset(Offset = "0x18")]
	private int id_;

	[Token(Token = "0x4001C4C")]
	public const int PositionFieldNumber = 2;

	[Token(Token = "0x4001C4D")]
	[FieldOffset(Offset = "0x1C")]
	private int position_;

	[Token(Token = "0x4001C4E")]
	public const int PlayersFieldNumber = 3;

	[Token(Token = "0x4001C4F")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<long> _repeated_players_codec;

	[Token(Token = "0x4001C50")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<long> players_;

	[Token(Token = "0x1700128D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<VotedChoice> Parser
	{
		[Token(Token = "0x600573C")]
		[Address(RVA = "0xB14760", Offset = "0xB13B60", VA = "0x180B14760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700128E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600573D")]
		[Address(RVA = "0xB146B0", Offset = "0xB13AB0", VA = "0x180B146B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700128F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600573E")]
		[Address(RVA = "0xB149F0", Offset = "0xB13DF0", VA = "0x180B149F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Id
	{
		[Token(Token = "0x6005742")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005743")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001291")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Position
	{
		[Token(Token = "0x6005744")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005745")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001292")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<long> Players
	{
		[Token(Token = "0x6005746")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600573F")]
	[Address(RVA = "0xB14630", Offset = "0xB13A30", VA = "0x180B14630")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public VotedChoice()
	{
	}

	[Token(Token = "0x6005740")]
	[Address(RVA = "0xB14590", Offset = "0xB13990", VA = "0x180B14590")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public VotedChoice(VotedChoice other)
	{
	}

	[Token(Token = "0x6005741")]
	[Address(RVA = "0xB14110", Offset = "0xB13510", VA = "0x180B14110", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public VotedChoice Clone()
	{
		return null;
	}

	[Token(Token = "0x6005747")]
	[Address(RVA = "0xB14280", Offset = "0xB13680", VA = "0x180B14280", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005748")]
	[Address(RVA = "0xB141E0", Offset = "0xB135E0", VA = "0x180B141E0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(VotedChoice other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005749")]
	[Address(RVA = "0x9C6C20", Offset = "0x9C6020", VA = "0x1809C6C20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600574A")]
	[Address(RVA = "0xB14400", Offset = "0xB13800", VA = "0x180B14400", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600574B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600574C")]
	[Address(RVA = "0xB14900", Offset = "0xB13D00", VA = "0x180B14900", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600574D")]
	[Address(RVA = "0xB14000", Offset = "0xB13400", VA = "0x180B14000", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600574E")]
	[Address(RVA = "0xB14370", Offset = "0xB13770", VA = "0x180B14370", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(VotedChoice other)
	{
	}

	[Token(Token = "0x600574F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005750")]
	[Address(RVA = "0xB147B0", Offset = "0xB13BB0", VA = "0x180B147B0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
