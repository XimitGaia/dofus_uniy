using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x2000524")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapRunningFightStopListeningRequest : IMessage<MapRunningFightStopListeningRequest>, IMessage, IEquatable<MapRunningFightStopListeningRequest>, IDeepCloneable<MapRunningFightStopListeningRequest>, IBufferMessage
{
	[Token(Token = "0x4001174")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapRunningFightStopListeningRequest> _parser;

	[Token(Token = "0x4001175")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000B87")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MapRunningFightStopListeningRequest> Parser
	{
		[Token(Token = "0x600366B")]
		[Address(RVA = "0xA0E2A0", Offset = "0xA0D6A0", VA = "0x180A0E2A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B88")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600366C")]
		[Address(RVA = "0xA0E1F0", Offset = "0xA0D5F0", VA = "0x180A0E1F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B89")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600366D")]
		[Address(RVA = "0xA0E2F0", Offset = "0xA0D6F0", VA = "0x180A0E2F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600366E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRunningFightStopListeningRequest()
	{
	}

	[Token(Token = "0x600366F")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRunningFightStopListeningRequest(MapRunningFightStopListeningRequest other)
	{
	}

	[Token(Token = "0x6003670")]
	[Address(RVA = "0xA0DF90", Offset = "0xA0D390", VA = "0x180A0DF90", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRunningFightStopListeningRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003671")]
	[Address(RVA = "0xA0E010", Offset = "0xA0D410", VA = "0x180A0E010", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003672")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapRunningFightStopListeningRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003673")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003674")]
	[Address(RVA = "0xA0E090", Offset = "0xA0D490", VA = "0x180A0E090", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003675")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003676")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003677")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003678")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapRunningFightStopListeningRequest other)
	{
	}

	[Token(Token = "0x6003679")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600367A")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
