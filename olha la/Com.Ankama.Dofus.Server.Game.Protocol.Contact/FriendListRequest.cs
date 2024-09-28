using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007BE")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FriendListRequest : IMessage<FriendListRequest>, IMessage, IEquatable<FriendListRequest>, IDeepCloneable<FriendListRequest>, IBufferMessage
{
	[Token(Token = "0x4001AE3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FriendListRequest> _parser;

	[Token(Token = "0x4001AE4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x1700118C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<FriendListRequest> Parser
	{
		[Token(Token = "0x600524A")]
		[Address(RVA = "0xAF0770", Offset = "0xAEFB70", VA = "0x180AF0770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700118D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600524B")]
		[Address(RVA = "0xAF06C0", Offset = "0xAEFAC0", VA = "0x180AF06C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700118E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600524C")]
		[Address(RVA = "0xAF07C0", Offset = "0xAEFBC0", VA = "0x180AF07C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600524D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FriendListRequest()
	{
	}

	[Token(Token = "0x600524E")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendListRequest(FriendListRequest other)
	{
	}

	[Token(Token = "0x600524F")]
	[Address(RVA = "0xAF0460", Offset = "0xAEF860", VA = "0x180AF0460", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendListRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005250")]
	[Address(RVA = "0xAF04E0", Offset = "0xAEF8E0", VA = "0x180AF04E0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005251")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FriendListRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005252")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005253")]
	[Address(RVA = "0xAF0560", Offset = "0xAEF960", VA = "0x180AF0560", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005254")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005255")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005256")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005257")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FriendListRequest other)
	{
	}

	[Token(Token = "0x6005258")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005259")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
