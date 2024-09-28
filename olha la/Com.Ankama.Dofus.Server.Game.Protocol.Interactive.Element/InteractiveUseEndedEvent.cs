using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Interactive.Element;

[Token(Token = "0x20003E6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class InteractiveUseEndedEvent : IMessage<InteractiveUseEndedEvent>, IMessage, IEquatable<InteractiveUseEndedEvent>, IDeepCloneable<InteractiveUseEndedEvent>, IBufferMessage
{
	[Token(Token = "0x4000D75")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<InteractiveUseEndedEvent> _parser;

	[Token(Token = "0x4000D76")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D77")]
	public const int ElementIdFieldNumber = 1;

	[Token(Token = "0x4000D78")]
	[FieldOffset(Offset = "0x18")]
	private int elementId_;

	[Token(Token = "0x4000D79")]
	public const int SkillIdFieldNumber = 2;

	[Token(Token = "0x4000D7A")]
	[FieldOffset(Offset = "0x1C")]
	private int skillId_;

	[Token(Token = "0x170008BC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<InteractiveUseEndedEvent> Parser
	{
		[Token(Token = "0x60028D7")]
		[Address(RVA = "0x9A6730", Offset = "0x9A5B30", VA = "0x1809A6730")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008BD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60028D8")]
		[Address(RVA = "0x9A6680", Offset = "0x9A5A80", VA = "0x1809A6680")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008BE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60028D9")]
		[Address(RVA = "0x9A6780", Offset = "0x9A5B80", VA = "0x1809A6780", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008BF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ElementId
	{
		[Token(Token = "0x60028DD")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60028DE")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170008C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SkillId
	{
		[Token(Token = "0x60028DF")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60028E0")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x60028DA")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InteractiveUseEndedEvent()
	{
	}

	[Token(Token = "0x60028DB")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InteractiveUseEndedEvent(InteractiveUseEndedEvent other)
	{
	}

	[Token(Token = "0x60028DC")]
	[Address(RVA = "0x9A6400", Offset = "0x9A5800", VA = "0x1809A6400", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public InteractiveUseEndedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60028E1")]
	[Address(RVA = "0x9A6490", Offset = "0x9A5890", VA = "0x1809A6490", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60028E2")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(InteractiveUseEndedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60028E3")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60028E4")]
	[Address(RVA = "0x9A6520", Offset = "0x9A5920", VA = "0x1809A6520", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60028E5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60028E6")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60028E7")]
	[Address(RVA = "0x9A6340", Offset = "0x9A5740", VA = "0x1809A6340", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60028E8")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(InteractiveUseEndedEvent other)
	{
	}

	[Token(Token = "0x60028E9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60028EA")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
