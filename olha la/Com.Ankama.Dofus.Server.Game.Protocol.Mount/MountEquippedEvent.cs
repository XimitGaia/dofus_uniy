using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x2000323")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountEquippedEvent : IMessage<MountEquippedEvent>, IMessage, IEquatable<MountEquippedEvent>, IDeepCloneable<MountEquippedEvent>, IBufferMessage
{
	[Token(Token = "0x4000AE2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountEquippedEvent> _parser;

	[Token(Token = "0x4000AE3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000AE4")]
	public const int MountDataFieldNumber = 1;

	[Token(Token = "0x4000AE5")]
	[FieldOffset(Offset = "0x18")]
	private MountData mountData_;

	[Token(Token = "0x170006F9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MountEquippedEvent> Parser
	{
		[Token(Token = "0x600207F")]
		[Address(RVA = "0xD1C5B0", Offset = "0xD1B9B0", VA = "0x180D1C5B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006FA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002080")]
		[Address(RVA = "0xD1C500", Offset = "0xD1B900", VA = "0x180D1C500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006FB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002081")]
		[Address(RVA = "0xD1C700", Offset = "0xD1BB00", VA = "0x180D1C700", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006FC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountData MountData
	{
		[Token(Token = "0x6002085")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002086")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6002082")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountEquippedEvent()
	{
	}

	[Token(Token = "0x6002083")]
	[Address(RVA = "0xD1BDA0", Offset = "0xD1B1A0", VA = "0x180D1BDA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountEquippedEvent(MountEquippedEvent other)
	{
	}

	[Token(Token = "0x6002084")]
	[Address(RVA = "0xD1C180", Offset = "0xD1B580", VA = "0x180D1C180", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountEquippedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002087")]
	[Address(RVA = "0xD1C220", Offset = "0xD1B620", VA = "0x180D1C220", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002088")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MountEquippedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002089")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600208A")]
	[Address(RVA = "0xD1C3A0", Offset = "0xD1B7A0", VA = "0x180D1C3A0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600208B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600208C")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600208D")]
	[Address(RVA = "0xD1C0F0", Offset = "0xD1B4F0", VA = "0x180D1C0F0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600208E")]
	[Address(RVA = "0xD1C2D0", Offset = "0xD1B6D0", VA = "0x180D1C2D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MountEquippedEvent other)
	{
	}

	[Token(Token = "0x600208F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002090")]
	[Address(RVA = "0xD1C600", Offset = "0xD1BA00", VA = "0x180D1C600", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
