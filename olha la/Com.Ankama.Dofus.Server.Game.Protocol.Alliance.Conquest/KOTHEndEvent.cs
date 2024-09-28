using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest;

[Token(Token = "0x2000CF7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class KOTHEndEvent : IMessage<KOTHEndEvent>, IMessage, IEquatable<KOTHEndEvent>, IDeepCloneable<KOTHEndEvent>, IBufferMessage
{
	[Token(Token = "0x4002FB5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<KOTHEndEvent> _parser;

	[Token(Token = "0x4002FB6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002FB7")]
	public const int WinnerFieldNumber = 1;

	[Token(Token = "0x4002FB8")]
	[FieldOffset(Offset = "0x18")]
	private AllianceInformation winner_;

	[Token(Token = "0x17001DDC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<KOTHEndEvent> Parser
	{
		[Token(Token = "0x6008898")]
		[Address(RVA = "0xCB33E0", Offset = "0xCB27E0", VA = "0x180CB33E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DDD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008899")]
		[Address(RVA = "0xCB3330", Offset = "0xCB2730", VA = "0x180CB3330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DDE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600889A")]
		[Address(RVA = "0xCB3530", Offset = "0xCB2930", VA = "0x180CB3530", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DDF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceInformation Winner
	{
		[Token(Token = "0x600889E")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600889F")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x600889B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KOTHEndEvent()
	{
	}

	[Token(Token = "0x600889C")]
	[Address(RVA = "0xBD8910", Offset = "0xBD7D10", VA = "0x180BD8910")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KOTHEndEvent(KOTHEndEvent other)
	{
	}

	[Token(Token = "0x600889D")]
	[Address(RVA = "0xCB2FB0", Offset = "0xCB23B0", VA = "0x180CB2FB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KOTHEndEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60088A0")]
	[Address(RVA = "0xCB3050", Offset = "0xCB2450", VA = "0x180CB3050", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60088A1")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KOTHEndEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60088A2")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60088A3")]
	[Address(RVA = "0xCB31D0", Offset = "0xCB25D0", VA = "0x180CB31D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60088A4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60088A5")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60088A6")]
	[Address(RVA = "0xCB2F20", Offset = "0xCB2320", VA = "0x180CB2F20", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60088A7")]
	[Address(RVA = "0xCB3100", Offset = "0xCB2500", VA = "0x180CB3100", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(KOTHEndEvent other)
	{
	}

	[Token(Token = "0x60088A8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60088A9")]
	[Address(RVA = "0xCB3430", Offset = "0xCB2830", VA = "0x180CB3430", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
