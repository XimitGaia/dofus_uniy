using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x20005DF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightTurnReadyRequest : IMessage<FightTurnReadyRequest>, IMessage, IEquatable<FightTurnReadyRequest>, IDeepCloneable<FightTurnReadyRequest>, IBufferMessage
{
	[Token(Token = "0x4001473")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightTurnReadyRequest> _parser;

	[Token(Token = "0x4001474")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001475")]
	public const int IsReadyFieldNumber = 1;

	[Token(Token = "0x4001476")]
	[FieldOffset(Offset = "0x18")]
	private bool isReady_;

	[Token(Token = "0x17000D6A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightTurnReadyRequest> Parser
	{
		[Token(Token = "0x6003E94")]
		[Address(RVA = "0xA4E770", Offset = "0xA4DB70", VA = "0x180A4E770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D6B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003E95")]
		[Address(RVA = "0xA4E6C0", Offset = "0xA4DAC0", VA = "0x180A4E6C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D6C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003E96")]
		[Address(RVA = "0xA4E7C0", Offset = "0xA4DBC0", VA = "0x180A4E7C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D6D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsReady
	{
		[Token(Token = "0x6003E9A")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003E9B")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6003E97")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTurnReadyRequest()
	{
	}

	[Token(Token = "0x6003E98")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTurnReadyRequest(FightTurnReadyRequest other)
	{
	}

	[Token(Token = "0x6003E99")]
	[Address(RVA = "0xA4E3B0", Offset = "0xA4D7B0", VA = "0x180A4E3B0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightTurnReadyRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003E9C")]
	[Address(RVA = "0xA4E430", Offset = "0xA4D830", VA = "0x180A4E430", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003E9D")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightTurnReadyRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003E9E")]
	[Address(RVA = "0xA4E4C0", Offset = "0xA4D8C0", VA = "0x180A4E4C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003E9F")]
	[Address(RVA = "0xA4E560", Offset = "0xA4D960", VA = "0x180A4E560", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003EA0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003EA1")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003EA2")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003EA3")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FightTurnReadyRequest other)
	{
	}

	[Token(Token = "0x6003EA4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003EA5")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
