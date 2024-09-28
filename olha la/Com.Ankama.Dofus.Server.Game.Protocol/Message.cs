using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol;

[Token(Token = "0x200000E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Message : IMessage<Message>, IMessage, IEquatable<Message>, IDeepCloneable<Message>, IBufferMessage
{
	[Token(Token = "0x200000F")]
	public enum ContentOneofCase
	{
		[Token(Token = "0x4000031")]
		None,
		[Token(Token = "0x4000032")]
		Request,
		[Token(Token = "0x4000033")]
		Response,
		[Token(Token = "0x4000034")]
		Event
	}

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<Message> _parser;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400002B")]
	public const int RequestFieldNumber = 1;

	[Token(Token = "0x400002C")]
	public const int ResponseFieldNumber = 2;

	[Token(Token = "0x400002D")]
	public const int EventFieldNumber = 3;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x18")]
	private object content_;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x20")]
	private ContentOneofCase contentCase_;

	[Token(Token = "0x1700000E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<Message> Parser
	{
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x93D060", Offset = "0x93C460", VA = "0x18093D060")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x93CF50", Offset = "0x93C350", VA = "0x18093CF50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x93D520", Offset = "0x93C920", VA = "0x18093D520", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000011")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Request Request
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x93D0B0", Offset = "0x93C4B0", VA = "0x18093D0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x917DA0", Offset = "0x9171A0", VA = "0x180917DA0")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Response Response
	{
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x93D110", Offset = "0x93C510", VA = "0x18093D110")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x917DE0", Offset = "0x9171E0", VA = "0x180917DE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Event Event
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x93D000", Offset = "0x93C400", VA = "0x18093D000")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x919620", Offset = "0x918A20", VA = "0x180919620")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContentOneofCase ContentCase
	{
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(ContentOneofCase);
		}
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Message()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x93CBF0", Offset = "0x93BFF0", VA = "0x18093CBF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Message(Message other)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x93C4D0", Offset = "0x93B8D0", VA = "0x18093C4D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Message Clone()
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x916DD0", Offset = "0x9161D0", VA = "0x180916DD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearContent()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x93C690", Offset = "0x93BA90", VA = "0x18093C690", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x93C530", Offset = "0x93B930", VA = "0x18093C530", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(Message other)
	{
		return default(bool);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x93C6F0", Offset = "0x93BAF0", VA = "0x18093C6F0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x93CA90", Offset = "0x93BE90", VA = "0x18093CA90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x93D3A0", Offset = "0x93C7A0", VA = "0x18093D3A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x93C320", Offset = "0x93B720", VA = "0x18093C320", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x93C890", Offset = "0x93BC90", VA = "0x18093C890", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Message other)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x93D170", Offset = "0x93C570", VA = "0x18093D170", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
