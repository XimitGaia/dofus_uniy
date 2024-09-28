using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x200031D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountDataEvent : IMessage<MountDataEvent>, IMessage, IEquatable<MountDataEvent>, IDeepCloneable<MountDataEvent>, IBufferMessage
{
	[Token(Token = "0x4000AD3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountDataEvent> _parser;

	[Token(Token = "0x4000AD4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000AD5")]
	public const int MountDataFieldNumber = 1;

	[Token(Token = "0x4000AD6")]
	[FieldOffset(Offset = "0x18")]
	private MountData mountData_;

	[Token(Token = "0x170006F1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MountDataEvent> Parser
	{
		[Token(Token = "0x6002053")]
		[Address(RVA = "0xD1BEC0", Offset = "0xD1B2C0", VA = "0x180D1BEC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002054")]
		[Address(RVA = "0xD1BE10", Offset = "0xD1B210", VA = "0x180D1BE10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002055")]
		[Address(RVA = "0xD1C010", Offset = "0xD1B410", VA = "0x180D1C010", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountData MountData
	{
		[Token(Token = "0x6002059")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600205A")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6002056")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountDataEvent()
	{
	}

	[Token(Token = "0x6002057")]
	[Address(RVA = "0xD1BDA0", Offset = "0xD1B1A0", VA = "0x180D1BDA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountDataEvent(MountDataEvent other)
	{
	}

	[Token(Token = "0x6002058")]
	[Address(RVA = "0xD1BA20", Offset = "0xD1AE20", VA = "0x180D1BA20", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountDataEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600205B")]
	[Address(RVA = "0xD1BAC0", Offset = "0xD1AEC0", VA = "0x180D1BAC0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600205C")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MountDataEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600205D")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600205E")]
	[Address(RVA = "0xD1BC40", Offset = "0xD1B040", VA = "0x180D1BC40", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600205F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002060")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002061")]
	[Address(RVA = "0xD1B990", Offset = "0xD1AD90", VA = "0x180D1B990", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002062")]
	[Address(RVA = "0xD1BB70", Offset = "0xD1AF70", VA = "0x180D1BB70", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MountDataEvent other)
	{
	}

	[Token(Token = "0x6002063")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002064")]
	[Address(RVA = "0xD1BF10", Offset = "0xD1B310", VA = "0x180D1BF10", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
