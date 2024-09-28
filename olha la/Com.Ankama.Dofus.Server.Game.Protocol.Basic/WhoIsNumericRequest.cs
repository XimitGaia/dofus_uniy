using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Basic;

[Token(Token = "0x2000B3A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class WhoIsNumericRequest : IMessage<WhoIsNumericRequest>, IMessage, IEquatable<WhoIsNumericRequest>, IDeepCloneable<WhoIsNumericRequest>, IBufferMessage
{
	[Token(Token = "0x40029F3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<WhoIsNumericRequest> _parser;

	[Token(Token = "0x40029F4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40029F5")]
	public const int PlayerIdFieldNumber = 1;

	[Token(Token = "0x40029F6")]
	[FieldOffset(Offset = "0x18")]
	private long playerId_;

	[Token(Token = "0x17001A14")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<WhoIsNumericRequest> Parser
	{
		[Token(Token = "0x6007654")]
		[Address(RVA = "0xC2B8F0", Offset = "0xC2ACF0", VA = "0x180C2B8F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A15")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007655")]
		[Address(RVA = "0xC2B840", Offset = "0xC2AC40", VA = "0x180C2B840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A16")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007656")]
		[Address(RVA = "0xC2B940", Offset = "0xC2AD40", VA = "0x180C2B940", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A17")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PlayerId
	{
		[Token(Token = "0x600765A")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600765B")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6007657")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public WhoIsNumericRequest()
	{
	}

	[Token(Token = "0x6007658")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public WhoIsNumericRequest(WhoIsNumericRequest other)
	{
	}

	[Token(Token = "0x6007659")]
	[Address(RVA = "0xC2B5D0", Offset = "0xC2A9D0", VA = "0x180C2B5D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public WhoIsNumericRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600765C")]
	[Address(RVA = "0xC2B650", Offset = "0xC2AA50", VA = "0x180C2B650", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600765D")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(WhoIsNumericRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600765E")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600765F")]
	[Address(RVA = "0xC2B6E0", Offset = "0xC2AAE0", VA = "0x180C2B6E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007660")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007661")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007662")]
	[Address(RVA = "0xC2B540", Offset = "0xC2A940", VA = "0x180C2B540", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007663")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(WhoIsNumericRequest other)
	{
	}

	[Token(Token = "0x6007664")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007665")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
