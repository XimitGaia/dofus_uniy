using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Taxcollector;

[Token(Token = "0x20000A6")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TaxCollectorStateUpdateEvent : IMessage<TaxCollectorStateUpdateEvent>, IMessage, IEquatable<TaxCollectorStateUpdateEvent>, IDeepCloneable<TaxCollectorStateUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x400022A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TaxCollectorStateUpdateEvent> _parser;

	[Token(Token = "0x400022B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400022C")]
	public const int TaxCollectorUidFieldNumber = 1;

	[Token(Token = "0x400022D")]
	[FieldOffset(Offset = "0x18")]
	private string taxCollectorUid_;

	[Token(Token = "0x400022E")]
	public const int StateFieldNumber = 2;

	[Token(Token = "0x400022F")]
	[FieldOffset(Offset = "0x20")]
	private TaxCollectorState state_;

	[Token(Token = "0x17000151")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TaxCollectorStateUpdateEvent> Parser
	{
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x958850", Offset = "0x957C50", VA = "0x180958850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000152")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x9587A0", Offset = "0x957BA0", VA = "0x1809587A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000153")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x958A00", Offset = "0x957E00", VA = "0x180958A00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000154")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TaxCollectorUid
	{
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x958AE0", Offset = "0x957EE0", VA = "0x180958AE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000155")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorState State
	{
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(TaxCollectorState);
		}
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6000639")]
	[Address(RVA = "0x958750", Offset = "0x957B50", VA = "0x180958750")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TaxCollectorStateUpdateEvent()
	{
	}

	[Token(Token = "0x600063A")]
	[Address(RVA = "0x9586A0", Offset = "0x957AA0", VA = "0x1809586A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorStateUpdateEvent(TaxCollectorStateUpdateEvent other)
	{
	}

	[Token(Token = "0x600063B")]
	[Address(RVA = "0x958350", Offset = "0x957750", VA = "0x180958350", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TaxCollectorStateUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000640")]
	[Address(RVA = "0x958420", Offset = "0x957820", VA = "0x180958420", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000641")]
	[Address(RVA = "0x955090", Offset = "0x954490", VA = "0x180955090", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TaxCollectorStateUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000642")]
	[Address(RVA = "0x955100", Offset = "0x954500", VA = "0x180955100", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000643")]
	[Address(RVA = "0x958540", Offset = "0x957940", VA = "0x180958540", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000644")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000645")]
	[Address(RVA = "0x958970", Offset = "0x957D70", VA = "0x180958970", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000646")]
	[Address(RVA = "0x958290", Offset = "0x957690", VA = "0x180958290", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000647")]
	[Address(RVA = "0x9584D0", Offset = "0x9578D0", VA = "0x1809584D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TaxCollectorStateUpdateEvent other)
	{
	}

	[Token(Token = "0x6000648")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000649")]
	[Address(RVA = "0x9588A0", Offset = "0x957CA0", VA = "0x1809588A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
