using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Exchange;

[Token(Token = "0x2000711")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExchangeMountFreeFromPaddockEvent : IMessage<ExchangeMountFreeFromPaddockEvent>, IMessage, IEquatable<ExchangeMountFreeFromPaddockEvent>, IDeepCloneable<ExchangeMountFreeFromPaddockEvent>, IBufferMessage
{
	[Token(Token = "0x40018E8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ExchangeMountFreeFromPaddockEvent> _parser;

	[Token(Token = "0x40018E9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40018EA")]
	public const int NameFieldNumber = 1;

	[Token(Token = "0x40018EB")]
	[FieldOffset(Offset = "0x18")]
	private string name_;

	[Token(Token = "0x40018EC")]
	public const int CoordinatesFieldNumber = 2;

	[Token(Token = "0x40018ED")]
	[FieldOffset(Offset = "0x20")]
	private MapCoordinates coordinates_;

	[Token(Token = "0x40018EE")]
	public const int LiberatorFieldNumber = 3;

	[Token(Token = "0x40018EF")]
	[FieldOffset(Offset = "0x28")]
	private string liberator_;

	[Token(Token = "0x17001043")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExchangeMountFreeFromPaddockEvent> Parser
	{
		[Token(Token = "0x6004BF4")]
		[Address(RVA = "0xABB460", Offset = "0xABA860", VA = "0x180ABB460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001044")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004BF5")]
		[Address(RVA = "0xABB3B0", Offset = "0xABA7B0", VA = "0x180ABB3B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001045")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004BF6")]
		[Address(RVA = "0xABB6F0", Offset = "0xABAAF0", VA = "0x180ABB6F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001046")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Name
	{
		[Token(Token = "0x6004BFA")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004BFB")]
		[Address(RVA = "0xABB840", Offset = "0xABAC40", VA = "0x180ABB840")]
		set
		{
		}
	}

	[Token(Token = "0x17001047")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapCoordinates Coordinates
	{
		[Token(Token = "0x6004BFC")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004BFD")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x17001048")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Liberator
	{
		[Token(Token = "0x6004BFE")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004BFF")]
		[Address(RVA = "0xABB7D0", Offset = "0xABABD0", VA = "0x180ABB7D0")]
		set
		{
		}
	}

	[Token(Token = "0x6004BF7")]
	[Address(RVA = "0xABB240", Offset = "0xABA640", VA = "0x180ABB240")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeMountFreeFromPaddockEvent()
	{
	}

	[Token(Token = "0x6004BF8")]
	[Address(RVA = "0xABB2B0", Offset = "0xABA6B0", VA = "0x180ABB2B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ExchangeMountFreeFromPaddockEvent(ExchangeMountFreeFromPaddockEvent other)
	{
	}

	[Token(Token = "0x6004BF9")]
	[Address(RVA = "0xABAC80", Offset = "0xABA080", VA = "0x180ABAC80", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExchangeMountFreeFromPaddockEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004C00")]
	[Address(RVA = "0xABADB0", Offset = "0xABA1B0", VA = "0x180ABADB0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004C01")]
	[Address(RVA = "0xABAE90", Offset = "0xABA290", VA = "0x180ABAE90", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ExchangeMountFreeFromPaddockEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004C02")]
	[Address(RVA = "0xABAF20", Offset = "0xABA320", VA = "0x180ABAF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004C03")]
	[Address(RVA = "0xABB0E0", Offset = "0xABA4E0", VA = "0x180ABB0E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004C04")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004C05")]
	[Address(RVA = "0xABB630", Offset = "0xABAA30", VA = "0x180ABB630", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004C06")]
	[Address(RVA = "0xABAB90", Offset = "0xAB9F90", VA = "0x180ABAB90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004C07")]
	[Address(RVA = "0xABAFE0", Offset = "0xABA3E0", VA = "0x180ABAFE0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ExchangeMountFreeFromPaddockEvent other)
	{
	}

	[Token(Token = "0x6004C08")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004C09")]
	[Address(RVA = "0xABB4B0", Offset = "0xABA8B0", VA = "0x180ABB4B0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
