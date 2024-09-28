using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character;

[Token(Token = "0x2000877")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterLifeStatusEvent : IMessage<CharacterLifeStatusEvent>, IMessage, IEquatable<CharacterLifeStatusEvent>, IDeepCloneable<CharacterLifeStatusEvent>, IBufferMessage
{
	[Token(Token = "0x2000878")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000879")]
		public enum LifeStatus
		{
			[Token(Token = "0x4001D5E")]
			[OriginalName("ALIVE_AND_KICKING")]
			AliveAndKicking,
			[Token(Token = "0x4001D5F")]
			[OriginalName("TOMBSTONE")]
			Tombstone,
			[Token(Token = "0x4001D60")]
			[OriginalName("PHANTOM")]
			Phantom
		}
	}

	[Token(Token = "0x4001D57")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterLifeStatusEvent> _parser;

	[Token(Token = "0x4001D58")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001D59")]
	public const int StateFieldNumber = 1;

	[Token(Token = "0x4001D5A")]
	[FieldOffset(Offset = "0x18")]
	private Types.LifeStatus state_;

	[Token(Token = "0x4001D5B")]
	public const int PhoenixMapIdFieldNumber = 2;

	[Token(Token = "0x4001D5C")]
	[FieldOffset(Offset = "0x20")]
	private long phoenixMapId_;

	[Token(Token = "0x1700132C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterLifeStatusEvent> Parser
	{
		[Token(Token = "0x6005A0B")]
		[Address(RVA = "0xB1C440", Offset = "0xB1B840", VA = "0x180B1C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700132D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005A0C")]
		[Address(RVA = "0xB1C390", Offset = "0xB1B790", VA = "0x180B1C390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700132E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005A0D")]
		[Address(RVA = "0xB1C490", Offset = "0xB1B890", VA = "0x180B1C490", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700132F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.LifeStatus State
	{
		[Token(Token = "0x6005A11")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.LifeStatus);
		}
		[Token(Token = "0x6005A12")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001330")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long PhoenixMapId
	{
		[Token(Token = "0x6005A13")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005A14")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6005A0E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterLifeStatusEvent()
	{
	}

	[Token(Token = "0x6005A0F")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterLifeStatusEvent(CharacterLifeStatusEvent other)
	{
	}

	[Token(Token = "0x6005A10")]
	[Address(RVA = "0xB1C100", Offset = "0xB1B500", VA = "0x180B1C100", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterLifeStatusEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005A15")]
	[Address(RVA = "0xB1C190", Offset = "0xB1B590", VA = "0x180B1C190", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005A16")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterLifeStatusEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005A17")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005A18")]
	[Address(RVA = "0xB1C230", Offset = "0xB1B630", VA = "0x180B1C230", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005A19")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005A1A")]
	[Address(RVA = "0xA308E0", Offset = "0xA2FCE0", VA = "0x180A308E0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005A1B")]
	[Address(RVA = "0xB1C040", Offset = "0xB1B440", VA = "0x180B1C040", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005A1C")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterLifeStatusEvent other)
	{
	}

	[Token(Token = "0x6005A1D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005A1E")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
