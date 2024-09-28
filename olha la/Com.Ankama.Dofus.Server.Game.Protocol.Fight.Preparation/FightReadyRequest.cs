using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Fight.Preparation;

[Token(Token = "0x200061F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FightReadyRequest : IMessage<FightReadyRequest>, IMessage, IEquatable<FightReadyRequest>, IDeepCloneable<FightReadyRequest>, IBufferMessage
{
	[Token(Token = "0x4001580")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FightReadyRequest> _parser;

	[Token(Token = "0x4001581")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001582")]
	public const int IsReadyFieldNumber = 1;

	[Token(Token = "0x4001583")]
	[FieldOffset(Offset = "0x18")]
	private bool isReady_;

	[Token(Token = "0x17000E0B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FightReadyRequest> Parser
	{
		[Token(Token = "0x600416D")]
		[Address(RVA = "0xA81F00", Offset = "0xA81300", VA = "0x180A81F00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E0C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600416E")]
		[Address(RVA = "0xA81E50", Offset = "0xA81250", VA = "0x180A81E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E0D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600416F")]
		[Address(RVA = "0xA81F50", Offset = "0xA81350", VA = "0x180A81F50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E0E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsReady
	{
		[Token(Token = "0x6004173")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6004174")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6004170")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightReadyRequest()
	{
	}

	[Token(Token = "0x6004171")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightReadyRequest(FightReadyRequest other)
	{
	}

	[Token(Token = "0x6004172")]
	[Address(RVA = "0xA81B40", Offset = "0xA80F40", VA = "0x180A81B40", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightReadyRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6004175")]
	[Address(RVA = "0xA81BC0", Offset = "0xA80FC0", VA = "0x180A81BC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004176")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FightReadyRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004177")]
	[Address(RVA = "0xA81C50", Offset = "0xA81050", VA = "0x180A81C50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004178")]
	[Address(RVA = "0xA81CF0", Offset = "0xA810F0", VA = "0x180A81CF0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004179")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600417A")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600417B")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600417C")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FightReadyRequest other)
	{
	}

	[Token(Token = "0x600417D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600417E")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
