using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haapi;

[Token(Token = "0x2000452")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HaapiTokenEvent : IMessage<HaapiTokenEvent>, IMessage, IEquatable<HaapiTokenEvent>, IDeepCloneable<HaapiTokenEvent>, IBufferMessage
{
	[Token(Token = "0x4000EE3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HaapiTokenEvent> _parser;

	[Token(Token = "0x4000EE4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000EE5")]
	public const int TokenFieldNumber = 1;

	[Token(Token = "0x4000EE6")]
	[FieldOffset(Offset = "0x18")]
	private string token_;

	[Token(Token = "0x170009B7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HaapiTokenEvent> Parser
	{
		[Token(Token = "0x6002D7F")]
		[Address(RVA = "0x9B7E30", Offset = "0x9B7230", VA = "0x1809B7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009B8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002D80")]
		[Address(RVA = "0x9B7D80", Offset = "0x9B7180", VA = "0x1809B7D80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009B9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002D81")]
		[Address(RVA = "0x9B7F40", Offset = "0x9B7340", VA = "0x1809B7F40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009BA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Token
	{
		[Token(Token = "0x6002D85")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002D86")]
		[Address(RVA = "0x9B8020", Offset = "0x9B7420", VA = "0x1809B8020")]
		set
		{
		}
	}

	[Token(Token = "0x6002D82")]
	[Address(RVA = "0x9B7C90", Offset = "0x9B7090", VA = "0x1809B7C90")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HaapiTokenEvent()
	{
	}

	[Token(Token = "0x6002D83")]
	[Address(RVA = "0x9B7CE0", Offset = "0x9B70E0", VA = "0x1809B7CE0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HaapiTokenEvent(HaapiTokenEvent other)
	{
	}

	[Token(Token = "0x6002D84")]
	[Address(RVA = "0x9B7950", Offset = "0x9B6D50", VA = "0x1809B7950", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HaapiTokenEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002D87")]
	[Address(RVA = "0x9B7A20", Offset = "0x9B6E20", VA = "0x1809B7A20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D88")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HaapiTokenEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D89")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002D8A")]
	[Address(RVA = "0x9B7B30", Offset = "0x9B6F30", VA = "0x1809B7B30", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002D8B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002D8C")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002D8D")]
	[Address(RVA = "0x9B78C0", Offset = "0x9B6CC0", VA = "0x1809B78C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002D8E")]
	[Address(RVA = "0x9B7AD0", Offset = "0x9B6ED0", VA = "0x1809B7AD0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(HaapiTokenEvent other)
	{
	}

	[Token(Token = "0x6002D8F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002D90")]
	[Address(RVA = "0x9B7E80", Offset = "0x9B7280", VA = "0x1809B7E80", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
