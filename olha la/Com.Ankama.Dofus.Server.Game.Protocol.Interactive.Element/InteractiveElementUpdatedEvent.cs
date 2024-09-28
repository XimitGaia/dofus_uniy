using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Interactive.Element;

[Token(Token = "0x20003EC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class InteractiveElementUpdatedEvent : IMessage<InteractiveElementUpdatedEvent>, IMessage, IEquatable<InteractiveElementUpdatedEvent>, IDeepCloneable<InteractiveElementUpdatedEvent>, IBufferMessage
{
	[Token(Token = "0x4000D88")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<InteractiveElementUpdatedEvent> _parser;

	[Token(Token = "0x4000D89")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000D8A")]
	public const int InteractiveElementFieldNumber = 1;

	[Token(Token = "0x4000D8B")]
	[FieldOffset(Offset = "0x18")]
	private InteractiveElement interactiveElement_;

	[Token(Token = "0x170008C9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<InteractiveElementUpdatedEvent> Parser
	{
		[Token(Token = "0x6002919")]
		[Address(RVA = "0x9A5710", Offset = "0x9A4B10", VA = "0x1809A5710")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008CA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600291A")]
		[Address(RVA = "0x9A5660", Offset = "0x9A4A60", VA = "0x1809A5660")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008CB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600291B")]
		[Address(RVA = "0x9A5860", Offset = "0x9A4C60", VA = "0x1809A5860", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008CC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InteractiveElement InteractiveElement
	{
		[Token(Token = "0x600291F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002920")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x600291C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InteractiveElementUpdatedEvent()
	{
	}

	[Token(Token = "0x600291D")]
	[Address(RVA = "0x9A55F0", Offset = "0x9A49F0", VA = "0x1809A55F0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InteractiveElementUpdatedEvent(InteractiveElementUpdatedEvent other)
	{
	}

	[Token(Token = "0x600291E")]
	[Address(RVA = "0x9A5270", Offset = "0x9A4670", VA = "0x1809A5270", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InteractiveElementUpdatedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002921")]
	[Address(RVA = "0x9A5310", Offset = "0x9A4710", VA = "0x1809A5310", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002922")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(InteractiveElementUpdatedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002923")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002924")]
	[Address(RVA = "0x9A5490", Offset = "0x9A4890", VA = "0x1809A5490", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002925")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002926")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002927")]
	[Address(RVA = "0x9A51E0", Offset = "0x9A45E0", VA = "0x1809A51E0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002928")]
	[Address(RVA = "0x9A53C0", Offset = "0x9A47C0", VA = "0x1809A53C0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(InteractiveElementUpdatedEvent other)
	{
	}

	[Token(Token = "0x6002929")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600292A")]
	[Address(RVA = "0x9A5760", Offset = "0x9A4B60", VA = "0x1809A5760", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
