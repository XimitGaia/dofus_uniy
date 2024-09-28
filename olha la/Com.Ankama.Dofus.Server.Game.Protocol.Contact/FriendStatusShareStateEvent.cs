using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007D8")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FriendStatusShareStateEvent : IMessage<FriendStatusShareStateEvent>, IMessage, IEquatable<FriendStatusShareStateEvent>, IDeepCloneable<FriendStatusShareStateEvent>, IBufferMessage
{
	[Token(Token = "0x4001B28")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FriendStatusShareStateEvent> _parser;

	[Token(Token = "0x4001B29")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001B2A")]
	public const int ShareFieldNumber = 1;

	[Token(Token = "0x4001B2B")]
	[FieldOffset(Offset = "0x18")]
	private bool share_;

	[Token(Token = "0x170011C2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FriendStatusShareStateEvent> Parser
	{
		[Token(Token = "0x600536C")]
		[Address(RVA = "0xAF1DD0", Offset = "0xAF11D0", VA = "0x180AF1DD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011C3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600536D")]
		[Address(RVA = "0xAF1D20", Offset = "0xAF1120", VA = "0x180AF1D20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011C4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600536E")]
		[Address(RVA = "0xAF1E20", Offset = "0xAF1220", VA = "0x180AF1E20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011C5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Share
	{
		[Token(Token = "0x6005372")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005373")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x600536F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendStatusShareStateEvent()
	{
	}

	[Token(Token = "0x6005370")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendStatusShareStateEvent(FriendStatusShareStateEvent other)
	{
	}

	[Token(Token = "0x6005371")]
	[Address(RVA = "0xAF1A10", Offset = "0xAF0E10", VA = "0x180AF1A10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FriendStatusShareStateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005374")]
	[Address(RVA = "0xAF1A90", Offset = "0xAF0E90", VA = "0x180AF1A90", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005375")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FriendStatusShareStateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005376")]
	[Address(RVA = "0xAF1B20", Offset = "0xAF0F20", VA = "0x180AF1B20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005377")]
	[Address(RVA = "0xAF1BC0", Offset = "0xAF0FC0", VA = "0x180AF1BC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005378")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005379")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600537A")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600537B")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FriendStatusShareStateEvent other)
	{
	}

	[Token(Token = "0x600537C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600537D")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
