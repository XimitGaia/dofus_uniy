using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Npc;

[Token(Token = "0x20002CD")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class NpcDialogReplyRequest : IMessage<NpcDialogReplyRequest>, IMessage, IEquatable<NpcDialogReplyRequest>, IDeepCloneable<NpcDialogReplyRequest>, IBufferMessage
{
	[Token(Token = "0x40009DC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<NpcDialogReplyRequest> _parser;

	[Token(Token = "0x40009DD")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40009DE")]
	public const int ReplyIdFieldNumber = 1;

	[Token(Token = "0x40009DF")]
	[FieldOffset(Offset = "0x18")]
	private int replyId_;

	[Token(Token = "0x1700064B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NpcDialogReplyRequest> Parser
	{
		[Token(Token = "0x6001D28")]
		[Address(RVA = "0xD28140", Offset = "0xD27540", VA = "0x180D28140")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700064C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001D29")]
		[Address(RVA = "0xD28090", Offset = "0xD27490", VA = "0x180D28090")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700064D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001D2A")]
		[Address(RVA = "0xD28190", Offset = "0xD27590", VA = "0x180D28190", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700064E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ReplyId
	{
		[Token(Token = "0x6001D2E")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001D2F")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6001D2B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcDialogReplyRequest()
	{
	}

	[Token(Token = "0x6001D2C")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcDialogReplyRequest(NpcDialogReplyRequest other)
	{
	}

	[Token(Token = "0x6001D2D")]
	[Address(RVA = "0xD27E20", Offset = "0xD27220", VA = "0x180D27E20", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcDialogReplyRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001D30")]
	[Address(RVA = "0xD27EA0", Offset = "0xD272A0", VA = "0x180D27EA0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D31")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NpcDialogReplyRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001D32")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001D33")]
	[Address(RVA = "0xD27F30", Offset = "0xD27330", VA = "0x180D27F30", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001D34")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001D35")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001D36")]
	[Address(RVA = "0xD27D90", Offset = "0xD27190", VA = "0x180D27D90", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001D37")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NpcDialogReplyRequest other)
	{
	}

	[Token(Token = "0x6001D38")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001D39")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
