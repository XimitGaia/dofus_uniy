using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007BC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class UnBlockRequest : IMessage<UnBlockRequest>, IMessage, IEquatable<UnBlockRequest>, IDeepCloneable<UnBlockRequest>, IBufferMessage
{
	[Token(Token = "0x4001ADE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<UnBlockRequest> _parser;

	[Token(Token = "0x4001ADF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001AE0")]
	public const int AccountIdFieldNumber = 1;

	[Token(Token = "0x4001AE1")]
	[FieldOffset(Offset = "0x18")]
	private long accountId_;

	[Token(Token = "0x17001188")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UnBlockRequest> Parser
	{
		[Token(Token = "0x6005234")]
		[Address(RVA = "0xAF9240", Offset = "0xAF8640", VA = "0x180AF9240")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001189")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005235")]
		[Address(RVA = "0xAF9190", Offset = "0xAF8590", VA = "0x180AF9190")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700118A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005236")]
		[Address(RVA = "0xAF9290", Offset = "0xAF8690", VA = "0x180AF9290", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700118B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long AccountId
	{
		[Token(Token = "0x600523A")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600523B")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6005237")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UnBlockRequest()
	{
	}

	[Token(Token = "0x6005238")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UnBlockRequest(UnBlockRequest other)
	{
	}

	[Token(Token = "0x6005239")]
	[Address(RVA = "0xAF8F20", Offset = "0xAF8320", VA = "0x180AF8F20", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UnBlockRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600523C")]
	[Address(RVA = "0xAF8FA0", Offset = "0xAF83A0", VA = "0x180AF8FA0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600523D")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UnBlockRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600523E")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600523F")]
	[Address(RVA = "0xAF9030", Offset = "0xAF8430", VA = "0x180AF9030", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005240")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005241")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005242")]
	[Address(RVA = "0xAF8E90", Offset = "0xAF8290", VA = "0x180AF8E90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005243")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UnBlockRequest other)
	{
	}

	[Token(Token = "0x6005244")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005245")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
