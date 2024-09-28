using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000B8E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ArenaFightAnswerRequest : IMessage<ArenaFightAnswerRequest>, IMessage, IEquatable<ArenaFightAnswerRequest>, IDeepCloneable<ArenaFightAnswerRequest>, IBufferMessage
{
	[Token(Token = "0x4002B17")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ArenaFightAnswerRequest> _parser;

	[Token(Token = "0x4002B18")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002B19")]
	public const int AcceptFieldNumber = 1;

	[Token(Token = "0x4002B1A")]
	[FieldOffset(Offset = "0x18")]
	private bool accept_;

	[Token(Token = "0x17001ABE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ArenaFightAnswerRequest> Parser
	{
		[Token(Token = "0x6007981")]
		[Address(RVA = "0xC2DF90", Offset = "0xC2D390", VA = "0x180C2DF90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001ABF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007982")]
		[Address(RVA = "0xC2DEE0", Offset = "0xC2D2E0", VA = "0x180C2DEE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AC0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007983")]
		[Address(RVA = "0xC2DFE0", Offset = "0xC2D3E0", VA = "0x180C2DFE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AC1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Accept
	{
		[Token(Token = "0x6007987")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007988")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6007984")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaFightAnswerRequest()
	{
	}

	[Token(Token = "0x6007985")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaFightAnswerRequest(ArenaFightAnswerRequest other)
	{
	}

	[Token(Token = "0x6007986")]
	[Address(RVA = "0xC2DBD0", Offset = "0xC2CFD0", VA = "0x180C2DBD0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaFightAnswerRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007989")]
	[Address(RVA = "0xC2DC50", Offset = "0xC2D050", VA = "0x180C2DC50", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600798A")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ArenaFightAnswerRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600798B")]
	[Address(RVA = "0xC2DCE0", Offset = "0xC2D0E0", VA = "0x180C2DCE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600798C")]
	[Address(RVA = "0xC2DD80", Offset = "0xC2D180", VA = "0x180C2DD80", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600798D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600798E")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600798F")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007990")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ArenaFightAnswerRequest other)
	{
	}

	[Token(Token = "0x6007991")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007992")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
