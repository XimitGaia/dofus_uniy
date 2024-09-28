using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x20000AA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorRemovedEvent : IMessage<TaxCollectorRemovedEvent>, IMessage, IEquatable<TaxCollectorRemovedEvent>, IDeepCloneable<TaxCollectorRemovedEvent>, IBufferMessage
{
	[Token(Token = "0x4000238")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorRemovedEvent> _parser;

	[Token(Token = "0x4000239")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400023A")]
	public const int TaxCollectorUidFieldNumber = 1;

	[Token(Token = "0x400023B")]
	[FieldOffset(Offset = "0x18")]
	private string taxCollectorUid_;

	[Token(Token = "0x1700015B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TaxCollectorRemovedEvent> Parser
	{
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x958030", Offset = "0x957430", VA = "0x180958030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700015C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x957F80", Offset = "0x957380", VA = "0x180957F80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700015D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x958140", Offset = "0x957540", VA = "0x180958140", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700015E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string TaxCollectorUid
	{
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x958220", Offset = "0x957620", VA = "0x180958220")]
		set
		{
		}
	}

	[Token(Token = "0x6000669")]
	[Address(RVA = "0x957F30", Offset = "0x957330", VA = "0x180957F30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorRemovedEvent()
	{
	}

	[Token(Token = "0x600066A")]
	[Address(RVA = "0x957E90", Offset = "0x957290", VA = "0x180957E90")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorRemovedEvent(TaxCollectorRemovedEvent other)
	{
	}

	[Token(Token = "0x600066B")]
	[Address(RVA = "0x957B50", Offset = "0x956F50", VA = "0x180957B50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorRemovedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600066E")]
	[Address(RVA = "0x957C20", Offset = "0x957020", VA = "0x180957C20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600066F")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TaxCollectorRemovedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000670")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000671")]
	[Address(RVA = "0x957D30", Offset = "0x957130", VA = "0x180957D30", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000672")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000673")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000674")]
	[Address(RVA = "0x957AC0", Offset = "0x956EC0", VA = "0x180957AC0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000675")]
	[Address(RVA = "0x957CD0", Offset = "0x9570D0", VA = "0x180957CD0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TaxCollectorRemovedEvent other)
	{
	}

	[Token(Token = "0x6000676")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000677")]
	[Address(RVA = "0x958080", Offset = "0x957480", VA = "0x180958080", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
