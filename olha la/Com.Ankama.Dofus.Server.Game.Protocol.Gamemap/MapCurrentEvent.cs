using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x2000530")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapCurrentEvent : IMessage<MapCurrentEvent>, IMessage, IEquatable<MapCurrentEvent>, IDeepCloneable<MapCurrentEvent>, IBufferMessage
{
	[Token(Token = "0x400119D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapCurrentEvent> _parser;

	[Token(Token = "0x400119E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400119F")]
	public const int MapIdFieldNumber = 1;

	[Token(Token = "0x40011A0")]
	[FieldOffset(Offset = "0x18")]
	private long mapId_;

	[Token(Token = "0x17000BA4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MapCurrentEvent> Parser
	{
		[Token(Token = "0x60036F8")]
		[Address(RVA = "0xA07660", Offset = "0xA06A60", VA = "0x180A07660")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BA5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60036F9")]
		[Address(RVA = "0xA075B0", Offset = "0xA069B0", VA = "0x180A075B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BA6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60036FA")]
		[Address(RVA = "0xA076B0", Offset = "0xA06AB0", VA = "0x180A076B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000BA7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long MapId
	{
		[Token(Token = "0x60036FE")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60036FF")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x60036FB")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapCurrentEvent()
	{
	}

	[Token(Token = "0x60036FC")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapCurrentEvent(MapCurrentEvent other)
	{
	}

	[Token(Token = "0x60036FD")]
	[Address(RVA = "0xA07340", Offset = "0xA06740", VA = "0x180A07340", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapCurrentEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003700")]
	[Address(RVA = "0xA073C0", Offset = "0xA067C0", VA = "0x180A073C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003701")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapCurrentEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003702")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003703")]
	[Address(RVA = "0xA07450", Offset = "0xA06850", VA = "0x180A07450", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003704")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003705")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003706")]
	[Address(RVA = "0xA072B0", Offset = "0xA066B0", VA = "0x180A072B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003707")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapCurrentEvent other)
	{
	}

	[Token(Token = "0x6003708")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003709")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
