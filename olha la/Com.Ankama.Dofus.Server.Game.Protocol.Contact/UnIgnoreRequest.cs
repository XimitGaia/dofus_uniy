using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007B6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class UnIgnoreRequest : IMessage<UnIgnoreRequest>, IMessage, IEquatable<UnIgnoreRequest>, IDeepCloneable<UnIgnoreRequest>, IBufferMessage
{
	[Token(Token = "0x4001AD1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<UnIgnoreRequest> _parser;

	[Token(Token = "0x4001AD2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001AD3")]
	public const int AccountIdFieldNumber = 1;

	[Token(Token = "0x4001AD4")]
	[FieldOffset(Offset = "0x18")]
	private long accountId_;

	[Token(Token = "0x1700117D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UnIgnoreRequest> Parser
	{
		[Token(Token = "0x60051F4")]
		[Address(RVA = "0xAE3670", Offset = "0xAE2A70", VA = "0x180AE3670")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700117E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60051F5")]
		[Address(RVA = "0xAE35C0", Offset = "0xAE29C0", VA = "0x180AE35C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700117F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60051F6")]
		[Address(RVA = "0xAE36C0", Offset = "0xAE2AC0", VA = "0x180AE36C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001180")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long AccountId
	{
		[Token(Token = "0x60051FA")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60051FB")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x60051F7")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UnIgnoreRequest()
	{
	}

	[Token(Token = "0x60051F8")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UnIgnoreRequest(UnIgnoreRequest other)
	{
	}

	[Token(Token = "0x60051F9")]
	[Address(RVA = "0xAE3350", Offset = "0xAE2750", VA = "0x180AE3350", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public UnIgnoreRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60051FC")]
	[Address(RVA = "0xAE33D0", Offset = "0xAE27D0", VA = "0x180AE33D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60051FD")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UnIgnoreRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60051FE")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60051FF")]
	[Address(RVA = "0xAE3460", Offset = "0xAE2860", VA = "0x180AE3460", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005200")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005201")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005202")]
	[Address(RVA = "0xAE32C0", Offset = "0xAE26C0", VA = "0x180AE32C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005203")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(UnIgnoreRequest other)
	{
	}

	[Token(Token = "0x6005204")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005205")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
