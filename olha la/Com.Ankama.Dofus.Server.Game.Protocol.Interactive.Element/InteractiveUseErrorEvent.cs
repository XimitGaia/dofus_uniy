using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Interactive.Element;

[Token(Token = "0x20003E2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class InteractiveUseErrorEvent : IMessage<InteractiveUseErrorEvent>, IMessage, IEquatable<InteractiveUseErrorEvent>, IDeepCloneable<InteractiveUseErrorEvent>, IBufferMessage
{
	[Token(Token = "0x4000D61")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<InteractiveUseErrorEvent> _parser;

	[Token(Token = "0x4000D62")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D63")]
	public const int ElementIdFieldNumber = 1;

	[Token(Token = "0x4000D64")]
	[FieldOffset(Offset = "0x18")]
	private int elementId_;

	[Token(Token = "0x4000D65")]
	public const int SkillInstanceUidFieldNumber = 2;

	[Token(Token = "0x4000D66")]
	[FieldOffset(Offset = "0x1C")]
	private int skillInstanceUid_;

	[Token(Token = "0x170008AF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<InteractiveUseErrorEvent> Parser
	{
		[Token(Token = "0x60028A1")]
		[Address(RVA = "0x9A6C50", Offset = "0x9A6050", VA = "0x1809A6C50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60028A2")]
		[Address(RVA = "0x9A6BA0", Offset = "0x9A5FA0", VA = "0x1809A6BA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008B1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60028A3")]
		[Address(RVA = "0x9A6CA0", Offset = "0x9A60A0", VA = "0x1809A6CA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008B2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ElementId
	{
		[Token(Token = "0x60028A7")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60028A8")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170008B3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SkillInstanceUid
	{
		[Token(Token = "0x60028A9")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60028AA")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x60028A4")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public InteractiveUseErrorEvent()
	{
	}

	[Token(Token = "0x60028A5")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public InteractiveUseErrorEvent(InteractiveUseErrorEvent other)
	{
	}

	[Token(Token = "0x60028A6")]
	[Address(RVA = "0x9A6920", Offset = "0x9A5D20", VA = "0x1809A6920", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InteractiveUseErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60028AB")]
	[Address(RVA = "0x9A69B0", Offset = "0x9A5DB0", VA = "0x1809A69B0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60028AC")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(InteractiveUseErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60028AD")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60028AE")]
	[Address(RVA = "0x9A6A40", Offset = "0x9A5E40", VA = "0x1809A6A40", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60028AF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60028B0")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60028B1")]
	[Address(RVA = "0x9A6860", Offset = "0x9A5C60", VA = "0x1809A6860", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60028B2")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(InteractiveUseErrorEvent other)
	{
	}

	[Token(Token = "0x60028B3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60028B4")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
