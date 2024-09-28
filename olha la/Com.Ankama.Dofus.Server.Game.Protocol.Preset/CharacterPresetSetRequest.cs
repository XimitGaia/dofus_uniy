using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x20001F9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterPresetSetRequest : IMessage<CharacterPresetSetRequest>, IMessage, IEquatable<CharacterPresetSetRequest>, IDeepCloneable<CharacterPresetSetRequest>, IBufferMessage
{
	[Token(Token = "0x40006B5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterPresetSetRequest> _parser;

	[Token(Token = "0x40006B6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40006B7")]
	public const int UuidFieldNumber = 1;

	[Token(Token = "0x40006B8")]
	[FieldOffset(Offset = "0x18")]
	private string uuid_;

	[Token(Token = "0x40006B9")]
	public const int OriginFieldNumber = 2;

	[Token(Token = "0x40006BA")]
	[FieldOffset(Offset = "0x20")]
	private PresetOrigin origin_;

	[Token(Token = "0x17000448")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterPresetSetRequest> Parser
	{
		[Token(Token = "0x60013FD")]
		[Address(RVA = "0xCDB750", Offset = "0xCDAB50", VA = "0x180CDB750")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000449")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60013FE")]
		[Address(RVA = "0xCDB6A0", Offset = "0xCDAAA0", VA = "0x180CDB6A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700044A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60013FF")]
		[Address(RVA = "0xCDB8E0", Offset = "0xCDACE0", VA = "0x180CDB8E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700044B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Uuid
	{
		[Token(Token = "0x6001403")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001404")]
		[Address(RVA = "0xCDB9C0", Offset = "0xCDADC0", VA = "0x180CDB9C0")]
		set
		{
		}
	}

	[Token(Token = "0x1700044C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetOrigin Origin
	{
		[Token(Token = "0x6001405")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001406")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6001400")]
	[Address(RVA = "0xCDB590", Offset = "0xCDA990", VA = "0x180CDB590")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterPresetSetRequest()
	{
	}

	[Token(Token = "0x6001401")]
	[Address(RVA = "0xCDB5E0", Offset = "0xCDA9E0", VA = "0x180CDB5E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPresetSetRequest(CharacterPresetSetRequest other)
	{
	}

	[Token(Token = "0x6001402")]
	[Address(RVA = "0xCDB190", Offset = "0xCDA590", VA = "0x180CDB190", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterPresetSetRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001407")]
	[Address(RVA = "0xCDB280", Offset = "0xCDA680", VA = "0x180CDB280", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001408")]
	[Address(RVA = "0x92F3E0", Offset = "0x92E7E0", VA = "0x18092F3E0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterPresetSetRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001409")]
	[Address(RVA = "0x92F460", Offset = "0x92E860", VA = "0x18092F460", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600140A")]
	[Address(RVA = "0xCDB430", Offset = "0xCDA830", VA = "0x180CDB430", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600140B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600140C")]
	[Address(RVA = "0x92FB90", Offset = "0x92EF90", VA = "0x18092FB90", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600140D")]
	[Address(RVA = "0xCDB0D0", Offset = "0xCDA4D0", VA = "0x180CDB0D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600140E")]
	[Address(RVA = "0xCDB340", Offset = "0xCDA740", VA = "0x180CDB340", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterPresetSetRequest other)
	{
	}

	[Token(Token = "0x600140F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001410")]
	[Address(RVA = "0xCDB7A0", Offset = "0xCDABA0", VA = "0x180CDB7A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
