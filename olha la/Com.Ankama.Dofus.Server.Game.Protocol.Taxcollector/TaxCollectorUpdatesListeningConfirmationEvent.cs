using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x20000BE")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorUpdatesListeningConfirmationEvent : IMessage<TaxCollectorUpdatesListeningConfirmationEvent>, IMessage, IEquatable<TaxCollectorUpdatesListeningConfirmationEvent>, IDeepCloneable<TaxCollectorUpdatesListeningConfirmationEvent>, IBufferMessage
{
	[Token(Token = "0x4000298")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorUpdatesListeningConfirmationEvent> _parser;

	[Token(Token = "0x4000299")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400029A")]
	public const int InformationFieldNumber = 1;

	[Token(Token = "0x400029B")]
	[FieldOffset(Offset = "0x18")]
	private TaxCollectorInformation information_;

	[Token(Token = "0x1700018E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TaxCollectorUpdatesListeningConfirmationEvent> Parser
	{
		[Token(Token = "0x600073A")]
		[Address(RVA = "0xA6A870", Offset = "0xA69C70", VA = "0x180A6A870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700018F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600073B")]
		[Address(RVA = "0xA6A7C0", Offset = "0xA69BC0", VA = "0x180A6A7C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000190")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600073C")]
		[Address(RVA = "0xA6A9C0", Offset = "0xA69DC0", VA = "0x180A6A9C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000191")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorInformation Information
	{
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x600073D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorUpdatesListeningConfirmationEvent()
	{
	}

	[Token(Token = "0x600073E")]
	[Address(RVA = "0xA6A750", Offset = "0xA69B50", VA = "0x180A6A750")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorUpdatesListeningConfirmationEvent(TaxCollectorUpdatesListeningConfirmationEvent other)
	{
	}

	[Token(Token = "0x600073F")]
	[Address(RVA = "0xA6A3D0", Offset = "0xA697D0", VA = "0x180A6A3D0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorUpdatesListeningConfirmationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000742")]
	[Address(RVA = "0xA6A470", Offset = "0xA69870", VA = "0x180A6A470", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000743")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TaxCollectorUpdatesListeningConfirmationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000744")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000745")]
	[Address(RVA = "0xA6A5F0", Offset = "0xA699F0", VA = "0x180A6A5F0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000746")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000747")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000748")]
	[Address(RVA = "0xA6A340", Offset = "0xA69740", VA = "0x180A6A340", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000749")]
	[Address(RVA = "0xA6A520", Offset = "0xA69920", VA = "0x180A6A520", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TaxCollectorUpdatesListeningConfirmationEvent other)
	{
	}

	[Token(Token = "0x600074A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600074B")]
	[Address(RVA = "0xA6A8C0", Offset = "0xA69CC0", VA = "0x180A6A8C0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
