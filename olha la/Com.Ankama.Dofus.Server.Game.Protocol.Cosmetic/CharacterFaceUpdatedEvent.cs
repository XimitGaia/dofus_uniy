using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000BE9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterFaceUpdatedEvent : IMessage<CharacterFaceUpdatedEvent>, IMessage, IEquatable<CharacterFaceUpdatedEvent>, IDeepCloneable<CharacterFaceUpdatedEvent>, IBufferMessage
{
	[Token(Token = "0x4002C31")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterFaceUpdatedEvent> _parser;

	[Token(Token = "0x4002C32")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002C33")]
	public const int FaceIdFieldNumber = 1;

	[Token(Token = "0x4002C34")]
	[FieldOffset(Offset = "0x18")]
	private int faceId_;

	[Token(Token = "0x4002C35")]
	public const int SlotFieldNumber = 2;

	[Token(Token = "0x4002C36")]
	[FieldOffset(Offset = "0x1C")]
	private int slot_;

	[Token(Token = "0x17001B80")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterFaceUpdatedEvent> Parser
	{
		[Token(Token = "0x6007D2E")]
		[Address(RVA = "0xC57D90", Offset = "0xC57190", VA = "0x180C57D90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B81")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007D2F")]
		[Address(RVA = "0xC57CE0", Offset = "0xC570E0", VA = "0x180C57CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B82")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007D30")]
		[Address(RVA = "0xC57DE0", Offset = "0xC571E0", VA = "0x180C57DE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B83")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int FaceId
	{
		[Token(Token = "0x6007D34")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007D35")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001B84")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Slot
	{
		[Token(Token = "0x6007D36")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007D37")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6007D31")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterFaceUpdatedEvent()
	{
	}

	[Token(Token = "0x6007D32")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterFaceUpdatedEvent(CharacterFaceUpdatedEvent other)
	{
	}

	[Token(Token = "0x6007D33")]
	[Address(RVA = "0xC57A60", Offset = "0xC56E60", VA = "0x180C57A60", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterFaceUpdatedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6007D38")]
	[Address(RVA = "0xC57AF0", Offset = "0xC56EF0", VA = "0x180C57AF0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007D39")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterFaceUpdatedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007D3A")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007D3B")]
	[Address(RVA = "0xC57B80", Offset = "0xC56F80", VA = "0x180C57B80", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007D3C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007D3D")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007D3E")]
	[Address(RVA = "0xC579A0", Offset = "0xC56DA0", VA = "0x180C579A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007D3F")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterFaceUpdatedEvent other)
	{
	}

	[Token(Token = "0x6007D40")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007D41")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
