using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Prism;

[Token(Token = "0x20001BF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PrismRemoveEvent : IMessage<PrismRemoveEvent>, IMessage, IEquatable<PrismRemoveEvent>, IDeepCloneable<PrismRemoveEvent>, IBufferMessage
{
	[Token(Token = "0x40005D8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PrismRemoveEvent> _parser;

	[Token(Token = "0x40005D9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40005DA")]
	public const int PrismLocalizedInformationFieldNumber = 1;

	[Token(Token = "0x40005DB")]
	[FieldOffset(Offset = "0x18")]
	private PrismLocalizedInformation prismLocalizedInformation_;

	[Token(Token = "0x170003C1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PrismRemoveEvent> Parser
	{
		[Token(Token = "0x60011B3")]
		[Address(RVA = "0xCD1E90", Offset = "0xCD1290", VA = "0x180CD1E90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003C2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60011B4")]
		[Address(RVA = "0xCD1DE0", Offset = "0xCD11E0", VA = "0x180CD1DE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003C3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60011B5")]
		[Address(RVA = "0xCD1FE0", Offset = "0xCD13E0", VA = "0x180CD1FE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003C4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismLocalizedInformation PrismLocalizedInformation
	{
		[Token(Token = "0x60011B9")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60011BA")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x60011B6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismRemoveEvent()
	{
	}

	[Token(Token = "0x60011B7")]
	[Address(RVA = "0xCCE100", Offset = "0xCCD500", VA = "0x180CCE100")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismRemoveEvent(PrismRemoveEvent other)
	{
	}

	[Token(Token = "0x60011B8")]
	[Address(RVA = "0xCD1A60", Offset = "0xCD0E60", VA = "0x180CD1A60", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismRemoveEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60011BB")]
	[Address(RVA = "0xCD1B00", Offset = "0xCD0F00", VA = "0x180CD1B00", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60011BC")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PrismRemoveEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60011BD")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60011BE")]
	[Address(RVA = "0xCD1C80", Offset = "0xCD1080", VA = "0x180CD1C80", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60011BF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60011C0")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60011C1")]
	[Address(RVA = "0xCD19D0", Offset = "0xCD0DD0", VA = "0x180CD19D0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60011C2")]
	[Address(RVA = "0xCD1BB0", Offset = "0xCD0FB0", VA = "0x180CD1BB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PrismRemoveEvent other)
	{
	}

	[Token(Token = "0x60011C3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60011C4")]
	[Address(RVA = "0xCD1EE0", Offset = "0xCD12E0", VA = "0x180CD1EE0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
