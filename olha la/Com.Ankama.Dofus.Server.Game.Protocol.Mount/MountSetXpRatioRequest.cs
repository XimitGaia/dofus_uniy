using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x2000309")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountSetXpRatioRequest : IMessage<MountSetXpRatioRequest>, IMessage, IEquatable<MountSetXpRatioRequest>, IDeepCloneable<MountSetXpRatioRequest>, IBufferMessage
{
	[Token(Token = "0x4000A9F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountSetXpRatioRequest> _parser;

	[Token(Token = "0x4000AA0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000AA1")]
	public const int XpRatioFieldNumber = 1;

	[Token(Token = "0x4000AA2")]
	[FieldOffset(Offset = "0x18")]
	private int xpRatio_;

	[Token(Token = "0x170006C8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MountSetXpRatioRequest> Parser
	{
		[Token(Token = "0x6001F75")]
		[Address(RVA = "0xD22CC0", Offset = "0xD220C0", VA = "0x180D22CC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006C9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001F76")]
		[Address(RVA = "0xD22C10", Offset = "0xD22010", VA = "0x180D22C10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006CA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001F77")]
		[Address(RVA = "0xD22D10", Offset = "0xD22110", VA = "0x180D22D10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006CB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int XpRatio
	{
		[Token(Token = "0x6001F7B")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001F7C")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6001F78")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountSetXpRatioRequest()
	{
	}

	[Token(Token = "0x6001F79")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountSetXpRatioRequest(MountSetXpRatioRequest other)
	{
	}

	[Token(Token = "0x6001F7A")]
	[Address(RVA = "0xD229A0", Offset = "0xD21DA0", VA = "0x180D229A0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountSetXpRatioRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001F7D")]
	[Address(RVA = "0xD22A20", Offset = "0xD21E20", VA = "0x180D22A20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F7E")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MountSetXpRatioRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F7F")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001F80")]
	[Address(RVA = "0xD22AB0", Offset = "0xD21EB0", VA = "0x180D22AB0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001F81")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001F82")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001F83")]
	[Address(RVA = "0xD22910", Offset = "0xD21D10", VA = "0x180D22910", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001F84")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MountSetXpRatioRequest other)
	{
	}

	[Token(Token = "0x6001F85")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001F86")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
