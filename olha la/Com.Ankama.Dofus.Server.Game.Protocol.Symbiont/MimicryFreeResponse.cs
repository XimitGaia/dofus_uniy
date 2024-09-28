using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Symbiont;

[Token(Token = "0x20000F2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MimicryFreeResponse : IMessage<MimicryFreeResponse>, IMessage, IEquatable<MimicryFreeResponse>, IDeepCloneable<MimicryFreeResponse>, IBufferMessage
{
	[Token(Token = "0x4000332")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MimicryFreeResponse> _parser;

	[Token(Token = "0x4000333")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000334")]
	public const int SuccessFieldNumber = 1;

	[Token(Token = "0x4000335")]
	[FieldOffset(Offset = "0x18")]
	private bool success_;

	[Token(Token = "0x170001F8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MimicryFreeResponse> Parser
	{
		[Token(Token = "0x6000955")]
		[Address(RVA = "0xA584B0", Offset = "0xA578B0", VA = "0x180A584B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001F9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000956")]
		[Address(RVA = "0xA58400", Offset = "0xA57800", VA = "0x180A58400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001FA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000957")]
		[Address(RVA = "0xA58500", Offset = "0xA57900", VA = "0x180A58500", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001FB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Success
	{
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6000958")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MimicryFreeResponse()
	{
	}

	[Token(Token = "0x6000959")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MimicryFreeResponse(MimicryFreeResponse other)
	{
	}

	[Token(Token = "0x600095A")]
	[Address(RVA = "0xA580F0", Offset = "0xA574F0", VA = "0x180A580F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MimicryFreeResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x600095D")]
	[Address(RVA = "0xA58170", Offset = "0xA57570", VA = "0x180A58170", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600095E")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MimicryFreeResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x600095F")]
	[Address(RVA = "0xA58200", Offset = "0xA57600", VA = "0x180A58200", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000960")]
	[Address(RVA = "0xA582A0", Offset = "0xA576A0", VA = "0x180A582A0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000961")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000962")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000963")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000964")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MimicryFreeResponse other)
	{
	}

	[Token(Token = "0x6000965")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000966")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
