using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009D7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterCharacteristicValue : IMessage<CharacterCharacteristicValue>, IMessage, IEquatable<CharacterCharacteristicValue>, IDeepCloneable<CharacterCharacteristicValue>, IBufferMessage
{
	[Token(Token = "0x40022DF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterCharacteristicValue> _parser;

	[Token(Token = "0x40022E0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40022E1")]
	public const int TotalFieldNumber = 1;

	[Token(Token = "0x40022E2")]
	[FieldOffset(Offset = "0x18")]
	private long total_;

	[Token(Token = "0x170015F5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterCharacteristicValue> Parser
	{
		[Token(Token = "0x6006678")]
		[Address(RVA = "0xBA3860", Offset = "0xBA2C60", VA = "0x180BA3860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015F6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6006679")]
		[Address(RVA = "0xBA37B0", Offset = "0xBA2BB0", VA = "0x180BA37B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015F7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600667A")]
		[Address(RVA = "0xBA38B0", Offset = "0xBA2CB0", VA = "0x180BA38B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015F8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Total
	{
		[Token(Token = "0x600667E")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600667F")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x600667B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCharacteristicValue()
	{
	}

	[Token(Token = "0x600667C")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterCharacteristicValue(CharacterCharacteristicValue other)
	{
	}

	[Token(Token = "0x600667D")]
	[Address(RVA = "0xBA3540", Offset = "0xBA2940", VA = "0x180BA3540", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterCharacteristicValue Clone()
	{
		return null;
	}

	[Token(Token = "0x6006680")]
	[Address(RVA = "0xBA35C0", Offset = "0xBA29C0", VA = "0x180BA35C0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006681")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterCharacteristicValue other)
	{
		return default(bool);
	}

	[Token(Token = "0x6006682")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6006683")]
	[Address(RVA = "0xBA3650", Offset = "0xBA2A50", VA = "0x180BA3650", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6006684")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6006685")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6006686")]
	[Address(RVA = "0xBA34B0", Offset = "0xBA28B0", VA = "0x180BA34B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6006687")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterCharacteristicValue other)
	{
	}

	[Token(Token = "0x6006688")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6006689")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
