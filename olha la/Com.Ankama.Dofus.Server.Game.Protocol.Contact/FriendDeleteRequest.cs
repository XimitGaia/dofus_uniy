using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007AC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FriendDeleteRequest : IMessage<FriendDeleteRequest>, IMessage, IEquatable<FriendDeleteRequest>, IDeepCloneable<FriendDeleteRequest>, IBufferMessage
{
	[Token(Token = "0x4001AB8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FriendDeleteRequest> _parser;

	[Token(Token = "0x4001AB9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001ABA")]
	public const int AccountIdFieldNumber = 1;

	[Token(Token = "0x4001ABB")]
	[FieldOffset(Offset = "0x18")]
	private long accountId_;

	[Token(Token = "0x17001169")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FriendDeleteRequest> Parser
	{
		[Token(Token = "0x6005186")]
		[Address(RVA = "0xADDE20", Offset = "0xADD220", VA = "0x180ADDE20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700116A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005187")]
		[Address(RVA = "0xADDD70", Offset = "0xADD170", VA = "0x180ADDD70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700116B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005188")]
		[Address(RVA = "0xADDE70", Offset = "0xADD270", VA = "0x180ADDE70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700116C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long AccountId
	{
		[Token(Token = "0x600518C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600518D")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6005189")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendDeleteRequest()
	{
	}

	[Token(Token = "0x600518A")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendDeleteRequest(FriendDeleteRequest other)
	{
	}

	[Token(Token = "0x600518B")]
	[Address(RVA = "0xADDB00", Offset = "0xADCF00", VA = "0x180ADDB00", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FriendDeleteRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600518E")]
	[Address(RVA = "0xADDB80", Offset = "0xADCF80", VA = "0x180ADDB80", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600518F")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FriendDeleteRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005190")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005191")]
	[Address(RVA = "0xADDC10", Offset = "0xADD010", VA = "0x180ADDC10", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005192")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005193")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005194")]
	[Address(RVA = "0xADDA70", Offset = "0xADCE70", VA = "0x180ADDA70", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005195")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(FriendDeleteRequest other)
	{
	}

	[Token(Token = "0x6005196")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005197")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
