using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x20001D7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SpellPositions : IMessage<SpellPositions>, IMessage, IEquatable<SpellPositions>, IDeepCloneable<SpellPositions>, IBufferMessage
{
	[Token(Token = "0x400064D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SpellPositions> _parser;

	[Token(Token = "0x400064E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400064F")]
	public const int PositionsFieldNumber = 1;

	[Token(Token = "0x4000650")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_positions_codec;

	[Token(Token = "0x4000651")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> positions_;

	[Token(Token = "0x17000408")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<SpellPositions> Parser
	{
		[Token(Token = "0x60012C9")]
		[Address(RVA = "0xCD6480", Offset = "0xCD5880", VA = "0x180CD6480")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000409")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60012CA")]
		[Address(RVA = "0xCD63D0", Offset = "0xCD57D0", VA = "0x180CD63D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700040A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60012CB")]
		[Address(RVA = "0xCD66A0", Offset = "0xCD5AA0", VA = "0x180CD66A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700040B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> Positions
	{
		[Token(Token = "0x60012CF")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60012CC")]
	[Address(RVA = "0xCD6350", Offset = "0xCD5750", VA = "0x180CD6350")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellPositions()
	{
	}

	[Token(Token = "0x60012CD")]
	[Address(RVA = "0xCD62C0", Offset = "0xCD56C0", VA = "0x180CD62C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SpellPositions(SpellPositions other)
	{
	}

	[Token(Token = "0x60012CE")]
	[Address(RVA = "0xCD5E80", Offset = "0xCD5280", VA = "0x180CD5E80", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SpellPositions Clone()
	{
		return null;
	}

	[Token(Token = "0x60012D0")]
	[Address(RVA = "0xCD5F40", Offset = "0xCD5340", VA = "0x180CD5F40", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60012D1")]
	[Address(RVA = "0xCD6020", Offset = "0xCD5420", VA = "0x180CD6020", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SpellPositions other)
	{
		return default(bool);
	}

	[Token(Token = "0x60012D2")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60012D3")]
	[Address(RVA = "0xCD6130", Offset = "0xCD5530", VA = "0x180CD6130", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60012D4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60012D5")]
	[Address(RVA = "0xCD65F0", Offset = "0xCD59F0", VA = "0x180CD65F0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60012D6")]
	[Address(RVA = "0xCD5DE0", Offset = "0xCD51E0", VA = "0x180CD5DE0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60012D7")]
	[Address(RVA = "0xCD60B0", Offset = "0xCD54B0", VA = "0x180CD60B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SpellPositions other)
	{
	}

	[Token(Token = "0x60012D8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60012D9")]
	[Address(RVA = "0xCD64D0", Offset = "0xCD58D0", VA = "0x180CD64D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
