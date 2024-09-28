using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social;

[Token(Token = "0x200011D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AdditionalSmileyEvent : IMessage<AdditionalSmileyEvent>, IMessage, IEquatable<AdditionalSmileyEvent>, IDeepCloneable<AdditionalSmileyEvent>, IBufferMessage
{
	[Token(Token = "0x40003CA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AdditionalSmileyEvent> _parser;

	[Token(Token = "0x40003CB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40003CC")]
	public const int PackIdFieldNumber = 1;

	[Token(Token = "0x40003CD")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_packId_codec;

	[Token(Token = "0x40003CE")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> packId_;

	[Token(Token = "0x17000256")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AdditionalSmileyEvent> Parser
	{
		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0xB63860", Offset = "0xB62C60", VA = "0x180B63860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000257")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0xB637B0", Offset = "0xB62BB0", VA = "0x180B637B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000258")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0xB63A80", Offset = "0xB62E80", VA = "0x180B63A80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000259")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> PackId
	{
		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000AFC")]
	[Address(RVA = "0xB636A0", Offset = "0xB62AA0", VA = "0x180B636A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AdditionalSmileyEvent()
	{
	}

	[Token(Token = "0x6000AFD")]
	[Address(RVA = "0xB63720", Offset = "0xB62B20", VA = "0x180B63720")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AdditionalSmileyEvent(AdditionalSmileyEvent other)
	{
	}

	[Token(Token = "0x6000AFE")]
	[Address(RVA = "0xB63260", Offset = "0xB62660", VA = "0x180B63260", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AdditionalSmileyEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000B00")]
	[Address(RVA = "0xB633B0", Offset = "0xB627B0", VA = "0x180B633B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B01")]
	[Address(RVA = "0xB63320", Offset = "0xB62720", VA = "0x180B63320", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AdditionalSmileyEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000B02")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000B03")]
	[Address(RVA = "0xB63510", Offset = "0xB62910", VA = "0x180B63510", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000B04")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000B05")]
	[Address(RVA = "0xB639D0", Offset = "0xB62DD0", VA = "0x180B639D0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000B06")]
	[Address(RVA = "0xB631C0", Offset = "0xB625C0", VA = "0x180B631C0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000B07")]
	[Address(RVA = "0xB63490", Offset = "0xB62890", VA = "0x180B63490", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AdditionalSmileyEvent other)
	{
	}

	[Token(Token = "0x6000B08")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000B09")]
	[Address(RVA = "0xB638B0", Offset = "0xB62CB0", VA = "0x180B638B0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
