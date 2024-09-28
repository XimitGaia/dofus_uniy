using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight;

[Token(Token = "0x20005E1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightTurnFinishRequest : IMessage<FightTurnFinishRequest>, IMessage, IEquatable<FightTurnFinishRequest>, IDeepCloneable<FightTurnFinishRequest>, IBufferMessage
{
	[Token(Token = "0x4001478")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightTurnFinishRequest> _parser;

	[Token(Token = "0x4001479")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400147A")]
	public const int IsAfkFieldNumber = 1;

	[Token(Token = "0x400147B")]
	[FieldOffset(Offset = "0x18")]
	private bool isAfk_;

	[Token(Token = "0x17000D6E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FightTurnFinishRequest> Parser
	{
		[Token(Token = "0x6003EAA")]
		[Address(RVA = "0xA4D740", Offset = "0xA4CB40", VA = "0x180A4D740")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D6F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003EAB")]
		[Address(RVA = "0xA4D690", Offset = "0xA4CA90", VA = "0x180A4D690")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D70")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003EAC")]
		[Address(RVA = "0xA4D790", Offset = "0xA4CB90", VA = "0x180A4D790", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D71")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsAfk
	{
		[Token(Token = "0x6003EB0")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003EB1")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6003EAD")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTurnFinishRequest()
	{
	}

	[Token(Token = "0x6003EAE")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTurnFinishRequest(FightTurnFinishRequest other)
	{
	}

	[Token(Token = "0x6003EAF")]
	[Address(RVA = "0xA4D380", Offset = "0xA4C780", VA = "0x180A4D380", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightTurnFinishRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003EB2")]
	[Address(RVA = "0xA4D400", Offset = "0xA4C800", VA = "0x180A4D400", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003EB3")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(FightTurnFinishRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003EB4")]
	[Address(RVA = "0xA4D490", Offset = "0xA4C890", VA = "0x180A4D490", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003EB5")]
	[Address(RVA = "0xA4D530", Offset = "0xA4C930", VA = "0x180A4D530", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003EB6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003EB7")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003EB8")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003EB9")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightTurnFinishRequest other)
	{
	}

	[Token(Token = "0x6003EBA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003EBB")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
