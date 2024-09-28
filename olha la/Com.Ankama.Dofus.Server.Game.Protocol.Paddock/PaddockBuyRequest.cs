using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Paddock;

[Token(Token = "0x20002AB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PaddockBuyRequest : IMessage<PaddockBuyRequest>, IMessage, IEquatable<PaddockBuyRequest>, IDeepCloneable<PaddockBuyRequest>, IBufferMessage
{
	[Token(Token = "0x4000966")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PaddockBuyRequest> _parser;

	[Token(Token = "0x4000967")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000968")]
	public const int ProposedPriceFieldNumber = 1;

	[Token(Token = "0x4000969")]
	[FieldOffset(Offset = "0x18")]
	private long proposedPrice_;

	[Token(Token = "0x170005FC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PaddockBuyRequest> Parser
	{
		[Token(Token = "0x6001BBB")]
		[Address(RVA = "0xD060D0", Offset = "0xD054D0", VA = "0x180D060D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005FD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001BBC")]
		[Address(RVA = "0xD06020", Offset = "0xD05420", VA = "0x180D06020")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005FE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001BBD")]
		[Address(RVA = "0xD06120", Offset = "0xD05520", VA = "0x180D06120", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005FF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long ProposedPrice
	{
		[Token(Token = "0x6001BC1")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001BC2")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6001BBE")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PaddockBuyRequest()
	{
	}

	[Token(Token = "0x6001BBF")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PaddockBuyRequest(PaddockBuyRequest other)
	{
	}

	[Token(Token = "0x6001BC0")]
	[Address(RVA = "0xD05DB0", Offset = "0xD051B0", VA = "0x180D05DB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockBuyRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001BC3")]
	[Address(RVA = "0xD05E30", Offset = "0xD05230", VA = "0x180D05E30", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BC4")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PaddockBuyRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BC5")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001BC6")]
	[Address(RVA = "0xD05EC0", Offset = "0xD052C0", VA = "0x180D05EC0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001BC7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001BC8")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001BC9")]
	[Address(RVA = "0xD05D20", Offset = "0xD05120", VA = "0x180D05D20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001BCA")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PaddockBuyRequest other)
	{
	}

	[Token(Token = "0x6001BCB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001BCC")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
