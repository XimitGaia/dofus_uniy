using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Prism;

[Token(Token = "0x20001C1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PrismAttackedEvent : IMessage<PrismAttackedEvent>, IMessage, IEquatable<PrismAttackedEvent>, IDeepCloneable<PrismAttackedEvent>, IBufferMessage
{
	[Token(Token = "0x40005DD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PrismAttackedEvent> _parser;

	[Token(Token = "0x40005DE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40005DF")]
	public const int PrismLocalizedInformationFieldNumber = 1;

	[Token(Token = "0x40005E0")]
	[FieldOffset(Offset = "0x18")]
	private PrismLocalizedInformation prismLocalizedInformation_;

	[Token(Token = "0x170003C5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PrismAttackedEvent> Parser
	{
		[Token(Token = "0x60011C9")]
		[Address(RVA = "0xCCF520", Offset = "0xCCE920", VA = "0x180CCF520")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003C6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60011CA")]
		[Address(RVA = "0xCCF470", Offset = "0xCCE870", VA = "0x180CCF470")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003C7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60011CB")]
		[Address(RVA = "0xCCF670", Offset = "0xCCEA70", VA = "0x180CCF670", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003C8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismLocalizedInformation PrismLocalizedInformation
	{
		[Token(Token = "0x60011CF")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60011D0")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x60011CC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismAttackedEvent()
	{
	}

	[Token(Token = "0x60011CD")]
	[Address(RVA = "0xCCE100", Offset = "0xCCD500", VA = "0x180CCE100")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismAttackedEvent(PrismAttackedEvent other)
	{
	}

	[Token(Token = "0x60011CE")]
	[Address(RVA = "0xCCF0F0", Offset = "0xCCE4F0", VA = "0x180CCF0F0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismAttackedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60011D1")]
	[Address(RVA = "0xCCF190", Offset = "0xCCE590", VA = "0x180CCF190", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60011D2")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PrismAttackedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60011D3")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60011D4")]
	[Address(RVA = "0xCCF310", Offset = "0xCCE710", VA = "0x180CCF310", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60011D5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60011D6")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60011D7")]
	[Address(RVA = "0xCCF060", Offset = "0xCCE460", VA = "0x180CCF060", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60011D8")]
	[Address(RVA = "0xCCF240", Offset = "0xCCE640", VA = "0x180CCF240", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PrismAttackedEvent other)
	{
	}

	[Token(Token = "0x60011D9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60011DA")]
	[Address(RVA = "0xCCF570", Offset = "0xCCE970", VA = "0x180CCF570", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
