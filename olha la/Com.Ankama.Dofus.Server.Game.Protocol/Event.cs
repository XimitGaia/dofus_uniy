using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol;

[Token(Token = "0x2000015")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Event : IMessage<Event>, IMessage, IEquatable<Event>, IDeepCloneable<Event>, IBufferMessage
{
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<Event> _parser;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000046")]
	public const int ContentFieldNumber = 1;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x18")]
	private Any content_;

	[Token(Token = "0x1700001F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<Event> Parser
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x93A280", Offset = "0x939680", VA = "0x18093A280")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000020")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x93A1D0", Offset = "0x9395D0", VA = "0x18093A1D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000021")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x93A3D0", Offset = "0x9397D0", VA = "0x18093A3D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000022")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Any Content
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Event()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x93A160", Offset = "0x939560", VA = "0x18093A160")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Event(Event other)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x939DE0", Offset = "0x9391E0", VA = "0x180939DE0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Event Clone()
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x939E80", Offset = "0x939280", VA = "0x180939E80", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Event other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x93A000", Offset = "0x939400", VA = "0x18093A000", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x939D50", Offset = "0x939150", VA = "0x180939D50", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x939F30", Offset = "0x939330", VA = "0x180939F30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(Event other)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x93A2D0", Offset = "0x9396D0", VA = "0x18093A2D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
