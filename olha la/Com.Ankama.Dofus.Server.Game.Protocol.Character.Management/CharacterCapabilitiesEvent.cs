using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x20008C5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterCapabilitiesEvent : IMessage<CharacterCapabilitiesEvent>, IMessage, IEquatable<CharacterCapabilitiesEvent>, IDeepCloneable<CharacterCapabilitiesEvent>, IBufferMessage
{
	[Token(Token = "0x4001E32")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterCapabilitiesEvent> _parser;

	[Token(Token = "0x4001E33")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001E34")]
	public const int GuildEmblemSymbolCategoryFieldNumber = 1;

	[Token(Token = "0x4001E35")]
	[FieldOffset(Offset = "0x18")]
	private int guildEmblemSymbolCategory_;

	[Token(Token = "0x170013B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterCapabilitiesEvent> Parser
	{
		[Token(Token = "0x6005CC3")]
		[Address(RVA = "0xB157B0", Offset = "0xB14BB0", VA = "0x180B157B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013B1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005CC4")]
		[Address(RVA = "0xB15700", Offset = "0xB14B00", VA = "0x180B15700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013B2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005CC5")]
		[Address(RVA = "0xB15800", Offset = "0xB14C00", VA = "0x180B15800", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013B3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GuildEmblemSymbolCategory
	{
		[Token(Token = "0x6005CC9")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005CCA")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6005CC6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCapabilitiesEvent()
	{
	}

	[Token(Token = "0x6005CC7")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCapabilitiesEvent(CharacterCapabilitiesEvent other)
	{
	}

	[Token(Token = "0x6005CC8")]
	[Address(RVA = "0xB15490", Offset = "0xB14890", VA = "0x180B15490", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCapabilitiesEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005CCB")]
	[Address(RVA = "0xB15510", Offset = "0xB14910", VA = "0x180B15510", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CCC")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterCapabilitiesEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CCD")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005CCE")]
	[Address(RVA = "0xB155A0", Offset = "0xB149A0", VA = "0x180B155A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005CCF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005CD0")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005CD1")]
	[Address(RVA = "0xB15400", Offset = "0xB14800", VA = "0x180B15400", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005CD2")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterCapabilitiesEvent other)
	{
	}

	[Token(Token = "0x6005CD3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005CD4")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
