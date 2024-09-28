using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage;

[Token(Token = "0x20000D9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TagObjectUpdateContent : IMessage<TagObjectUpdateContent>, IMessage, IEquatable<TagObjectUpdateContent>, IDeepCloneable<TagObjectUpdateContent>, IBufferMessage
{
	[Token(Token = "0x40002E5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TagObjectUpdateContent> _parser;

	[Token(Token = "0x40002E6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40002E7")]
	public const int TagStorageUuidFieldNumber = 1;

	[Token(Token = "0x40002E8")]
	[FieldOffset(Offset = "0x18")]
	private string tagStorageUuid_;

	[Token(Token = "0x40002E9")]
	public const int ObjectIdFieldNumber = 2;

	[Token(Token = "0x40002EA")]
	[FieldOffset(Offset = "0x20")]
	private int objectId_;

	[Token(Token = "0x170001C5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TagObjectUpdateContent> Parser
	{
		[Token(Token = "0x6000857")]
		[Address(RVA = "0xA5F7D0", Offset = "0xA5EBD0", VA = "0x180A5F7D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001C6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000858")]
		[Address(RVA = "0xA5F720", Offset = "0xA5EB20", VA = "0x180A5F720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001C7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000859")]
		[Address(RVA = "0xA5F8F0", Offset = "0xA5ECF0", VA = "0x180A5F8F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001C8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string TagStorageUuid
	{
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600085E")]
		[Address(RVA = "0xA5F9D0", Offset = "0xA5EDD0", VA = "0x180A5F9D0")]
		set
		{
		}
	}

	[Token(Token = "0x170001C9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectId
	{
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000860")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x600085A")]
	[Address(RVA = "0xA5F620", Offset = "0xA5EA20", VA = "0x180A5F620")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TagObjectUpdateContent()
	{
	}

	[Token(Token = "0x600085B")]
	[Address(RVA = "0xA5F670", Offset = "0xA5EA70", VA = "0x180A5F670")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TagObjectUpdateContent(TagObjectUpdateContent other)
	{
	}

	[Token(Token = "0x600085C")]
	[Address(RVA = "0xA5F2D0", Offset = "0xA5E6D0", VA = "0x180A5F2D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TagObjectUpdateContent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000861")]
	[Address(RVA = "0xA5F3A0", Offset = "0xA5E7A0", VA = "0x180A5F3A0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000862")]
	[Address(RVA = "0x955090", Offset = "0x954490", VA = "0x180955090", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TagObjectUpdateContent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000863")]
	[Address(RVA = "0x955100", Offset = "0x954500", VA = "0x180955100", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000864")]
	[Address(RVA = "0xA5F4C0", Offset = "0xA5E8C0", VA = "0x180A5F4C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000865")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000866")]
	[Address(RVA = "0x955630", Offset = "0x954A30", VA = "0x180955630", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000867")]
	[Address(RVA = "0xA5F210", Offset = "0xA5E610", VA = "0x180A5F210", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000868")]
	[Address(RVA = "0xA5F450", Offset = "0xA5E850", VA = "0x180A5F450", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TagObjectUpdateContent other)
	{
	}

	[Token(Token = "0x6000869")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600086A")]
	[Address(RVA = "0xA5F820", Offset = "0xA5EC20", VA = "0x180A5F820", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
