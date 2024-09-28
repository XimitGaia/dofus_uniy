using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007AA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FriendAddRequest : IMessage<FriendAddRequest>, IMessage, IEquatable<FriendAddRequest>, IDeepCloneable<FriendAddRequest>, IBufferMessage
{
	[Token(Token = "0x4001AB3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FriendAddRequest> _parser;

	[Token(Token = "0x4001AB4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001AB5")]
	public const int TargetFieldNumber = 1;

	[Token(Token = "0x4001AB6")]
	[FieldOffset(Offset = "0x18")]
	private PlayerSearch target_;

	[Token(Token = "0x17001165")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FriendAddRequest> Parser
	{
		[Token(Token = "0x6005170")]
		[Address(RVA = "0xADD840", Offset = "0xADCC40", VA = "0x180ADD840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001166")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005171")]
		[Address(RVA = "0xADD790", Offset = "0xADCB90", VA = "0x180ADD790")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001167")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005172")]
		[Address(RVA = "0xADD990", Offset = "0xADCD90", VA = "0x180ADD990", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001168")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSearch Target
	{
		[Token(Token = "0x6005176")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005177")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6005173")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendAddRequest()
	{
	}

	[Token(Token = "0x6005174")]
	[Address(RVA = "0xADD720", Offset = "0xADCB20", VA = "0x180ADD720")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendAddRequest(FriendAddRequest other)
	{
	}

	[Token(Token = "0x6005175")]
	[Address(RVA = "0xADD3A0", Offset = "0xADC7A0", VA = "0x180ADD3A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendAddRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005178")]
	[Address(RVA = "0xADD440", Offset = "0xADC840", VA = "0x180ADD440", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005179")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FriendAddRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600517A")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600517B")]
	[Address(RVA = "0xADD5C0", Offset = "0xADC9C0", VA = "0x180ADD5C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600517C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600517D")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600517E")]
	[Address(RVA = "0xADD310", Offset = "0xADC710", VA = "0x180ADD310", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600517F")]
	[Address(RVA = "0xADD4F0", Offset = "0xADC8F0", VA = "0x180ADD4F0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FriendAddRequest other)
	{
	}

	[Token(Token = "0x6005180")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005181")]
	[Address(RVA = "0xADD890", Offset = "0xADCC90", VA = "0x180ADD890", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
