using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CC0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceFactsErrorEvent : IMessage<AllianceFactsErrorEvent>, IMessage, IEquatable<AllianceFactsErrorEvent>, IDeepCloneable<AllianceFactsErrorEvent>, IBufferMessage
{
	[Token(Token = "0x4002F04")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceFactsErrorEvent> _parser;

	[Token(Token = "0x4002F05")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002F06")]
	public const int AllianceUuidFieldNumber = 1;

	[Token(Token = "0x4002F07")]
	[FieldOffset(Offset = "0x18")]
	private string allianceUuid_;

	[Token(Token = "0x17001D63")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceFactsErrorEvent> Parser
	{
		[Token(Token = "0x600864F")]
		[Address(RVA = "0xC8DD30", Offset = "0xC8D130", VA = "0x180C8DD30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D64")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008650")]
		[Address(RVA = "0xC8DC80", Offset = "0xC8D080", VA = "0x180C8DC80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D65")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008651")]
		[Address(RVA = "0xC8DE40", Offset = "0xC8D240", VA = "0x180C8DE40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D66")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AllianceUuid
	{
		[Token(Token = "0x6008655")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008656")]
		[Address(RVA = "0xC8DF20", Offset = "0xC8D320", VA = "0x180C8DF20")]
		set
		{
		}
	}

	[Token(Token = "0x6008652")]
	[Address(RVA = "0xC8DB90", Offset = "0xC8CF90", VA = "0x180C8DB90")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFactsErrorEvent()
	{
	}

	[Token(Token = "0x6008653")]
	[Address(RVA = "0xC8DBE0", Offset = "0xC8CFE0", VA = "0x180C8DBE0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFactsErrorEvent(AllianceFactsErrorEvent other)
	{
	}

	[Token(Token = "0x6008654")]
	[Address(RVA = "0xC8D850", Offset = "0xC8CC50", VA = "0x180C8D850", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFactsErrorEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008657")]
	[Address(RVA = "0xC8D920", Offset = "0xC8CD20", VA = "0x180C8D920", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008658")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceFactsErrorEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008659")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600865A")]
	[Address(RVA = "0xC8DA30", Offset = "0xC8CE30", VA = "0x180C8DA30", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600865B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600865C")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600865D")]
	[Address(RVA = "0xC8D7C0", Offset = "0xC8CBC0", VA = "0x180C8D7C0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600865E")]
	[Address(RVA = "0xC8D9D0", Offset = "0xC8CDD0", VA = "0x180C8D9D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceFactsErrorEvent other)
	{
	}

	[Token(Token = "0x600865F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008660")]
	[Address(RVA = "0xC8DD80", Offset = "0xC8D180", VA = "0x180C8DD80", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
