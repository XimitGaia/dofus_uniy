using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Document;

[Token(Token = "0x2000759")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class DocumentReadingBeginEvent : IMessage<DocumentReadingBeginEvent>, IMessage, IEquatable<DocumentReadingBeginEvent>, IDeepCloneable<DocumentReadingBeginEvent>, IBufferMessage
{
	[Token(Token = "0x40019CF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<DocumentReadingBeginEvent> _parser;

	[Token(Token = "0x40019D0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40019D1")]
	public const int DocumentIdFieldNumber = 1;

	[Token(Token = "0x40019D2")]
	[FieldOffset(Offset = "0x18")]
	private int documentId_;

	[Token(Token = "0x170010D8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<DocumentReadingBeginEvent> Parser
	{
		[Token(Token = "0x6004EAC")]
		[Address(RVA = "0xADB470", Offset = "0xADA870", VA = "0x180ADB470")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010D9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004EAD")]
		[Address(RVA = "0xADB3C0", Offset = "0xADA7C0", VA = "0x180ADB3C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010DA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004EAE")]
		[Address(RVA = "0xADB4C0", Offset = "0xADA8C0", VA = "0x180ADB4C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010DB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DocumentId
	{
		[Token(Token = "0x6004EB2")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004EB3")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6004EAF")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DocumentReadingBeginEvent()
	{
	}

	[Token(Token = "0x6004EB0")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DocumentReadingBeginEvent(DocumentReadingBeginEvent other)
	{
	}

	[Token(Token = "0x6004EB1")]
	[Address(RVA = "0xADB150", Offset = "0xADA550", VA = "0x180ADB150", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DocumentReadingBeginEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004EB4")]
	[Address(RVA = "0xADB1D0", Offset = "0xADA5D0", VA = "0x180ADB1D0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004EB5")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(DocumentReadingBeginEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004EB6")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004EB7")]
	[Address(RVA = "0xADB260", Offset = "0xADA660", VA = "0x180ADB260", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004EB8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004EB9")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004EBA")]
	[Address(RVA = "0xADB0C0", Offset = "0xADA4C0", VA = "0x180ADB0C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004EBB")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DocumentReadingBeginEvent other)
	{
	}

	[Token(Token = "0x6004EBC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004EBD")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
