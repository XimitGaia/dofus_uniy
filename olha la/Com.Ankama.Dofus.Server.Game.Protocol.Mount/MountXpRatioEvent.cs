using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x200031B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountXpRatioEvent : IMessage<MountXpRatioEvent>, IMessage, IEquatable<MountXpRatioEvent>, IDeepCloneable<MountXpRatioEvent>, IBufferMessage
{
	[Token(Token = "0x4000ACE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountXpRatioEvent> _parser;

	[Token(Token = "0x4000ACF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000AD0")]
	public const int RatioFieldNumber = 1;

	[Token(Token = "0x4000AD1")]
	[FieldOffset(Offset = "0x18")]
	private int ratio_;

	[Token(Token = "0x170006ED")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MountXpRatioEvent> Parser
	{
		[Token(Token = "0x600203D")]
		[Address(RVA = "0xD23F00", Offset = "0xD23300", VA = "0x180D23F00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006EE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600203E")]
		[Address(RVA = "0xD23E50", Offset = "0xD23250", VA = "0x180D23E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006EF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600203F")]
		[Address(RVA = "0xD23F50", Offset = "0xD23350", VA = "0x180D23F50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Ratio
	{
		[Token(Token = "0x6002043")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002044")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6002040")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountXpRatioEvent()
	{
	}

	[Token(Token = "0x6002041")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountXpRatioEvent(MountXpRatioEvent other)
	{
	}

	[Token(Token = "0x6002042")]
	[Address(RVA = "0xD23BE0", Offset = "0xD22FE0", VA = "0x180D23BE0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountXpRatioEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002045")]
	[Address(RVA = "0xD23C60", Offset = "0xD23060", VA = "0x180D23C60", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002046")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MountXpRatioEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002047")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002048")]
	[Address(RVA = "0xD23CF0", Offset = "0xD230F0", VA = "0x180D23CF0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002049")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600204A")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600204B")]
	[Address(RVA = "0xD23B50", Offset = "0xD22F50", VA = "0x180D23B50", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600204C")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MountXpRatioEvent other)
	{
	}

	[Token(Token = "0x600204D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600204E")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
