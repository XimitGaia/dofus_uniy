using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House;

[Token(Token = "0x2000414")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HouseGuildNoneEvent : IMessage<HouseGuildNoneEvent>, IMessage, IEquatable<HouseGuildNoneEvent>, IDeepCloneable<HouseGuildNoneEvent>, IBufferMessage
{
	[Token(Token = "0x4000E3C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HouseGuildNoneEvent> _parser;

	[Token(Token = "0x4000E3D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000E3E")]
	public const int HouseIdFieldNumber = 1;

	[Token(Token = "0x4000E3F")]
	[FieldOffset(Offset = "0x18")]
	private int houseId_;

	[Token(Token = "0x4000E40")]
	public const int InstanceIdFieldNumber = 2;

	[Token(Token = "0x4000E41")]
	[FieldOffset(Offset = "0x1C")]
	private int instanceId_;

	[Token(Token = "0x4000E42")]
	public const int SecondHandFieldNumber = 3;

	[Token(Token = "0x4000E43")]
	[FieldOffset(Offset = "0x20")]
	private bool secondHand_;

	[Token(Token = "0x1700093E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HouseGuildNoneEvent> Parser
	{
		[Token(Token = "0x6002B09")]
		[Address(RVA = "0x9C43E0", Offset = "0x9C37E0", VA = "0x1809C43E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700093F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002B0A")]
		[Address(RVA = "0x9C4330", Offset = "0x9C3730", VA = "0x1809C4330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000940")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002B0B")]
		[Address(RVA = "0x9C4430", Offset = "0x9C3830", VA = "0x1809C4430", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000941")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HouseId
	{
		[Token(Token = "0x6002B0F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002B10")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000942")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int InstanceId
	{
		[Token(Token = "0x6002B11")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002B12")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000943")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool SecondHand
	{
		[Token(Token = "0x6002B13")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002B14")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x6002B0C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HouseGuildNoneEvent()
	{
	}

	[Token(Token = "0x6002B0D")]
	[Address(RVA = "0x92C240", Offset = "0x92B640", VA = "0x18092C240")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseGuildNoneEvent(HouseGuildNoneEvent other)
	{
	}

	[Token(Token = "0x6002B0E")]
	[Address(RVA = "0x9C3FC0", Offset = "0x9C33C0", VA = "0x1809C3FC0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseGuildNoneEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002B15")]
	[Address(RVA = "0x9C4050", Offset = "0x9C3450", VA = "0x1809C4050", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002B16")]
	[Address(RVA = "0x92BF50", Offset = "0x92B350", VA = "0x18092BF50", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HouseGuildNoneEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002B17")]
	[Address(RVA = "0x9C40F0", Offset = "0x9C34F0", VA = "0x1809C40F0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002B18")]
	[Address(RVA = "0x9C41D0", Offset = "0x9C35D0", VA = "0x1809C41D0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002B19")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002B1A")]
	[Address(RVA = "0x98A3B0", Offset = "0x9897B0", VA = "0x18098A3B0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002B1B")]
	[Address(RVA = "0x9C3F00", Offset = "0x9C3300", VA = "0x1809C3F00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002B1C")]
	[Address(RVA = "0x92C070", Offset = "0x92B470", VA = "0x18092C070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HouseGuildNoneEvent other)
	{
	}

	[Token(Token = "0x6002B1D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002B1E")]
	[Address(RVA = "0x92C3A0", Offset = "0x92B7A0", VA = "0x18092C3A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
