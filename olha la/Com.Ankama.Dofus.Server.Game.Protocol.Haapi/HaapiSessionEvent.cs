using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haapi;

[Token(Token = "0x2000456")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HaapiSessionEvent : IMessage<HaapiSessionEvent>, IMessage, IEquatable<HaapiSessionEvent>, IDeepCloneable<HaapiSessionEvent>, IBufferMessage
{
	[Token(Token = "0x4000EEB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HaapiSessionEvent> _parser;

	[Token(Token = "0x4000EEC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000EED")]
	public const int SessionUidFieldNumber = 1;

	[Token(Token = "0x4000EEE")]
	[FieldOffset(Offset = "0x18")]
	private string sessionUid_;

	[Token(Token = "0x170009BE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HaapiSessionEvent> Parser
	{
		[Token(Token = "0x6002DA9")]
		[Address(RVA = "0x9B7660", Offset = "0x9B6A60", VA = "0x1809B7660")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009BF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002DAA")]
		[Address(RVA = "0x9B75B0", Offset = "0x9B69B0", VA = "0x1809B75B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002DAB")]
		[Address(RVA = "0x9B7770", Offset = "0x9B6B70", VA = "0x1809B7770", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009C1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string SessionUid
	{
		[Token(Token = "0x6002DAF")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002DB0")]
		[Address(RVA = "0x9B7850", Offset = "0x9B6C50", VA = "0x1809B7850")]
		set
		{
		}
	}

	[Token(Token = "0x6002DAC")]
	[Address(RVA = "0x9B74C0", Offset = "0x9B68C0", VA = "0x1809B74C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HaapiSessionEvent()
	{
	}

	[Token(Token = "0x6002DAD")]
	[Address(RVA = "0x9B7510", Offset = "0x9B6910", VA = "0x1809B7510")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HaapiSessionEvent(HaapiSessionEvent other)
	{
	}

	[Token(Token = "0x6002DAE")]
	[Address(RVA = "0x9B7180", Offset = "0x9B6580", VA = "0x1809B7180", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HaapiSessionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002DB1")]
	[Address(RVA = "0x9B7250", Offset = "0x9B6650", VA = "0x1809B7250", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002DB2")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(HaapiSessionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002DB3")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002DB4")]
	[Address(RVA = "0x9B7360", Offset = "0x9B6760", VA = "0x1809B7360", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002DB5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002DB6")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002DB7")]
	[Address(RVA = "0x9B70F0", Offset = "0x9B64F0", VA = "0x1809B70F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002DB8")]
	[Address(RVA = "0x9B7300", Offset = "0x9B6700", VA = "0x1809B7300", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HaapiSessionEvent other)
	{
	}

	[Token(Token = "0x6002DB9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002DBA")]
	[Address(RVA = "0x9B76B0", Offset = "0x9B6AB0", VA = "0x1809B76B0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
