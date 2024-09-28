using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character;

[Token(Token = "0x200086D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterCharacteristicsEvent : IMessage<CharacterCharacteristicsEvent>, IMessage, IEquatable<CharacterCharacteristicsEvent>, IDeepCloneable<CharacterCharacteristicsEvent>, IBufferMessage
{
	[Token(Token = "0x4001D34")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterCharacteristicsEvent> _parser;

	[Token(Token = "0x4001D35")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001D36")]
	public const int StatsFieldNumber = 1;

	[Token(Token = "0x4001D37")]
	[FieldOffset(Offset = "0x18")]
	private CharacterCharacteristics stats_;

	[Token(Token = "0x17001313")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterCharacteristicsEvent> Parser
	{
		[Token(Token = "0x6005993")]
		[Address(RVA = "0xB17B30", Offset = "0xB16F30", VA = "0x180B17B30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001314")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005994")]
		[Address(RVA = "0xB17A80", Offset = "0xB16E80", VA = "0x180B17A80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001315")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005995")]
		[Address(RVA = "0xB17C80", Offset = "0xB17080", VA = "0x180B17C80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001316")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCharacteristics Stats
	{
		[Token(Token = "0x6005999")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600599A")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6005996")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCharacteristicsEvent()
	{
	}

	[Token(Token = "0x6005997")]
	[Address(RVA = "0xB17A10", Offset = "0xB16E10", VA = "0x180B17A10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCharacteristicsEvent(CharacterCharacteristicsEvent other)
	{
	}

	[Token(Token = "0x6005998")]
	[Address(RVA = "0xB17690", Offset = "0xB16A90", VA = "0x180B17690", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCharacteristicsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600599B")]
	[Address(RVA = "0xB17730", Offset = "0xB16B30", VA = "0x180B17730", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600599C")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterCharacteristicsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600599D")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600599E")]
	[Address(RVA = "0xB178B0", Offset = "0xB16CB0", VA = "0x180B178B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600599F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60059A0")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60059A1")]
	[Address(RVA = "0xB17600", Offset = "0xB16A00", VA = "0x180B17600", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60059A2")]
	[Address(RVA = "0xB177E0", Offset = "0xB16BE0", VA = "0x180B177E0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterCharacteristicsEvent other)
	{
	}

	[Token(Token = "0x60059A3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60059A4")]
	[Address(RVA = "0xB17B80", Offset = "0xB16F80", VA = "0x180B17B80", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
