using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009D4")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterCharacteristic : IMessage<CharacterCharacteristic>, IMessage, IEquatable<CharacterCharacteristic>, IDeepCloneable<CharacterCharacteristic>, IBufferMessage
{
	[Token(Token = "0x20009D5")]
	public enum CharacterCharacteristicOneofCase
	{
		[Token(Token = "0x40022DA")]
		None = 0,
		[Token(Token = "0x40022DB")]
		Value = 2,
		[Token(Token = "0x40022DC")]
		Detailed = 3,
		[Token(Token = "0x40022DD")]
		Usable = 4
	}

	[Token(Token = "0x40022D0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterCharacteristic> _parser;

	[Token(Token = "0x40022D1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40022D2")]
	public const int CharacteristicIdFieldNumber = 1;

	[Token(Token = "0x40022D3")]
	[FieldOffset(Offset = "0x18")]
	private int characteristicId_;

	[Token(Token = "0x40022D4")]
	public const int ValueFieldNumber = 2;

	[Token(Token = "0x40022D5")]
	public const int DetailedFieldNumber = 3;

	[Token(Token = "0x40022D6")]
	public const int UsableFieldNumber = 4;

	[Token(Token = "0x40022D7")]
	[FieldOffset(Offset = "0x20")]
	private object characterCharacteristic_;

	[Token(Token = "0x40022D8")]
	[FieldOffset(Offset = "0x28")]
	private CharacterCharacteristicOneofCase characterCharacteristicCase_;

	[Token(Token = "0x170015ED")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterCharacteristic> Parser
	{
		[Token(Token = "0x600665A")]
		[Address(RVA = "0xBA4790", Offset = "0xBA3B90", VA = "0x180BA4790")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015EE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600665B")]
		[Address(RVA = "0xBA4680", Offset = "0xBA3A80", VA = "0x180BA4680")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015EF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600665C")]
		[Address(RVA = "0xBA4CC0", Offset = "0xBA40C0", VA = "0x180BA4CC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CharacteristicId
	{
		[Token(Token = "0x6006660")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006661")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170015F1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCharacteristicValue Value
	{
		[Token(Token = "0x6006662")]
		[Address(RVA = "0xBA4840", Offset = "0xBA3C40", VA = "0x180BA4840")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006663")]
		[Address(RVA = "0x926590", Offset = "0x925990", VA = "0x180926590")]
		set
		{
		}
	}

	[Token(Token = "0x170015F2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCharacteristicDetailed Detailed
	{
		[Token(Token = "0x6006664")]
		[Address(RVA = "0xBA4730", Offset = "0xBA3B30", VA = "0x180BA4730")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006665")]
		[Address(RVA = "0x926550", Offset = "0x925950", VA = "0x180926550")]
		set
		{
		}
	}

	[Token(Token = "0x170015F3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCharacteristicDetailedUsable Usable
	{
		[Token(Token = "0x6006666")]
		[Address(RVA = "0xBA47E0", Offset = "0xBA3BE0", VA = "0x180BA47E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006667")]
		[Address(RVA = "0x926610", Offset = "0x925A10", VA = "0x180926610")]
		set
		{
		}
	}

	[Token(Token = "0x170015F4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterCharacteristicOneofCase CharacterCharacteristicCase
	{
		[Token(Token = "0x6006668")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(CharacterCharacteristicOneofCase);
		}
	}

	[Token(Token = "0x600665D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterCharacteristic()
	{
	}

	[Token(Token = "0x600665E")]
	[Address(RVA = "0xBA4360", Offset = "0xBA3760", VA = "0x180BA4360")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCharacteristic(CharacterCharacteristic other)
	{
	}

	[Token(Token = "0x600665F")]
	[Address(RVA = "0xBA3B70", Offset = "0xBA2F70", VA = "0x180BA3B70", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCharacteristic Clone()
	{
		return null;
	}

	[Token(Token = "0x6006669")]
	[Address(RVA = "0x9247A0", Offset = "0x923BA0", VA = "0x1809247A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearCharacterCharacteristic()
	{
	}

	[Token(Token = "0x600666A")]
	[Address(RVA = "0xBA3CD0", Offset = "0xBA30D0", VA = "0x180BA3CD0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600666B")]
	[Address(RVA = "0xBA3BD0", Offset = "0xBA2FD0", VA = "0x180BA3BD0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterCharacteristic other)
	{
		return default(bool);
	}

	[Token(Token = "0x600666C")]
	[Address(RVA = "0xBA3E10", Offset = "0xBA3210", VA = "0x180BA3E10", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600666D")]
	[Address(RVA = "0xBA4200", Offset = "0xBA3600", VA = "0x180BA4200", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600666E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600666F")]
	[Address(RVA = "0xBA4B20", Offset = "0xBA3F20", VA = "0x180BA4B20", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006670")]
	[Address(RVA = "0xBA3990", Offset = "0xBA2D90", VA = "0x180BA3990", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006671")]
	[Address(RVA = "0xBA3FD0", Offset = "0xBA33D0", VA = "0x180BA3FD0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterCharacteristic other)
	{
	}

	[Token(Token = "0x6006672")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006673")]
	[Address(RVA = "0xBA48A0", Offset = "0xBA3CA0", VA = "0x180BA48A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
