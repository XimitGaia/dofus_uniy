using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x2000522")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapRunningFightsRequest : IMessage<MapRunningFightsRequest>, IMessage, IEquatable<MapRunningFightsRequest>, IDeepCloneable<MapRunningFightsRequest>, IBufferMessage
{
	[Token(Token = "0x4001171")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapRunningFightsRequest> _parser;

	[Token(Token = "0x4001172")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000B84")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MapRunningFightsRequest> Parser
	{
		[Token(Token = "0x6003657")]
		[Address(RVA = "0xA0F0E0", Offset = "0xA0E4E0", VA = "0x180A0F0E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B85")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003658")]
		[Address(RVA = "0xA0F030", Offset = "0xA0E430", VA = "0x180A0F030")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B86")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003659")]
		[Address(RVA = "0xA0F130", Offset = "0xA0E530", VA = "0x180A0F130", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600365A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRunningFightsRequest()
	{
	}

	[Token(Token = "0x600365B")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRunningFightsRequest(MapRunningFightsRequest other)
	{
	}

	[Token(Token = "0x600365C")]
	[Address(RVA = "0xA0EDD0", Offset = "0xA0E1D0", VA = "0x180A0EDD0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapRunningFightsRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600365D")]
	[Address(RVA = "0xA0EE50", Offset = "0xA0E250", VA = "0x180A0EE50", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600365E")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapRunningFightsRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600365F")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003660")]
	[Address(RVA = "0xA0EED0", Offset = "0xA0E2D0", VA = "0x180A0EED0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003661")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003662")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003663")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003664")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapRunningFightsRequest other)
	{
	}

	[Token(Token = "0x6003665")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003666")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
