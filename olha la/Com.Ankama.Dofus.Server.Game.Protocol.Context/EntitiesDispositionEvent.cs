using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context;

[Token(Token = "0x2000797")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class EntitiesDispositionEvent : IMessage<EntitiesDispositionEvent>, IMessage, IEquatable<EntitiesDispositionEvent>, IDeepCloneable<EntitiesDispositionEvent>, IBufferMessage
{
	[Token(Token = "0x4001A6C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<EntitiesDispositionEvent> _parser;

	[Token(Token = "0x4001A6D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001A6E")]
	public const int DispositionsFieldNumber = 1;

	[Token(Token = "0x4001A6F")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<EntityDisposition> _repeated_dispositions_codec;

	[Token(Token = "0x4001A70")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<EntityDisposition> dispositions_;

	[Token(Token = "0x1700113F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<EntitiesDispositionEvent> Parser
	{
		[Token(Token = "0x60050C5")]
		[Address(RVA = "0xADCBE0", Offset = "0xADBFE0", VA = "0x180ADCBE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001140")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60050C6")]
		[Address(RVA = "0xADCB30", Offset = "0xADBF30", VA = "0x180ADCB30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001141")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60050C7")]
		[Address(RVA = "0xADCDF0", Offset = "0xADC1F0", VA = "0x180ADCDF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001142")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EntityDisposition> Dispositions
	{
		[Token(Token = "0x60050CB")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60050C8")]
	[Address(RVA = "0xADCA20", Offset = "0xADBE20", VA = "0x180ADCA20")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EntitiesDispositionEvent()
	{
	}

	[Token(Token = "0x60050C9")]
	[Address(RVA = "0xADCAA0", Offset = "0xADBEA0", VA = "0x180ADCAA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntitiesDispositionEvent(EntitiesDispositionEvent other)
	{
	}

	[Token(Token = "0x60050CA")]
	[Address(RVA = "0xADC570", Offset = "0xADB970", VA = "0x180ADC570", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntitiesDispositionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60050CC")]
	[Address(RVA = "0xADC6C0", Offset = "0xADBAC0", VA = "0x180ADC6C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60050CD")]
	[Address(RVA = "0xADC630", Offset = "0xADBA30", VA = "0x180ADC630", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EntitiesDispositionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60050CE")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60050CF")]
	[Address(RVA = "0xADC820", Offset = "0xADBC20", VA = "0x180ADC820", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60050D0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60050D1")]
	[Address(RVA = "0xADCD40", Offset = "0xADC140", VA = "0x180ADCD40", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60050D2")]
	[Address(RVA = "0xADC4D0", Offset = "0xADB8D0", VA = "0x180ADC4D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60050D3")]
	[Address(RVA = "0xADC7A0", Offset = "0xADBBA0", VA = "0x180ADC7A0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EntitiesDispositionEvent other)
	{
	}

	[Token(Token = "0x60050D4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60050D5")]
	[Address(RVA = "0xADCC30", Offset = "0xADC030", VA = "0x180ADCC30", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
