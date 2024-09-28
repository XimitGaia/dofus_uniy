using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Document;

[Token(Token = "0x200075B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OpenGuideBookEvent : IMessage<OpenGuideBookEvent>, IMessage, IEquatable<OpenGuideBookEvent>, IDeepCloneable<OpenGuideBookEvent>, IBufferMessage
{
	[Token(Token = "0x40019D4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OpenGuideBookEvent> _parser;

	[Token(Token = "0x40019D5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40019D6")]
	public const int ArticleIdFieldNumber = 1;

	[Token(Token = "0x40019D7")]
	[FieldOffset(Offset = "0x18")]
	private int articleId_;

	[Token(Token = "0x170010DC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OpenGuideBookEvent> Parser
	{
		[Token(Token = "0x6004EC2")]
		[Address(RVA = "0xADFE10", Offset = "0xADF210", VA = "0x180ADFE10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010DD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004EC3")]
		[Address(RVA = "0xADFD60", Offset = "0xADF160", VA = "0x180ADFD60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010DE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004EC4")]
		[Address(RVA = "0xADFE60", Offset = "0xADF260", VA = "0x180ADFE60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010DF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ArticleId
	{
		[Token(Token = "0x6004EC8")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004EC9")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6004EC5")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OpenGuideBookEvent()
	{
	}

	[Token(Token = "0x6004EC6")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OpenGuideBookEvent(OpenGuideBookEvent other)
	{
	}

	[Token(Token = "0x6004EC7")]
	[Address(RVA = "0xADFAF0", Offset = "0xADEEF0", VA = "0x180ADFAF0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OpenGuideBookEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004ECA")]
	[Address(RVA = "0xADFB70", Offset = "0xADEF70", VA = "0x180ADFB70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004ECB")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OpenGuideBookEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004ECC")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004ECD")]
	[Address(RVA = "0xADFC00", Offset = "0xADF000", VA = "0x180ADFC00", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004ECE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004ECF")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004ED0")]
	[Address(RVA = "0xADFA60", Offset = "0xADEE60", VA = "0x180ADFA60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004ED1")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OpenGuideBookEvent other)
	{
	}

	[Token(Token = "0x6004ED2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004ED3")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
