using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap;

[Token(Token = "0x2000520")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MapChangeRequest : IMessage<MapChangeRequest>, IMessage, IEquatable<MapChangeRequest>, IDeepCloneable<MapChangeRequest>, IBufferMessage
{
	[Token(Token = "0x400116A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MapChangeRequest> _parser;

	[Token(Token = "0x400116B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400116C")]
	public const int MapIdFieldNumber = 1;

	[Token(Token = "0x400116D")]
	[FieldOffset(Offset = "0x18")]
	private int mapId_;

	[Token(Token = "0x400116E")]
	public const int AutoPilotFieldNumber = 2;

	[Token(Token = "0x400116F")]
	[FieldOffset(Offset = "0x1C")]
	private bool autoPilot_;

	[Token(Token = "0x17000B7F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MapChangeRequest> Parser
	{
		[Token(Token = "0x600363F")]
		[Address(RVA = "0xA02680", Offset = "0xA01A80", VA = "0x180A02680")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003640")]
		[Address(RVA = "0xA025D0", Offset = "0xA019D0", VA = "0x180A025D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B81")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003641")]
		[Address(RVA = "0xA026D0", Offset = "0xA01AD0", VA = "0x180A026D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B82")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MapId
	{
		[Token(Token = "0x6003645")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003646")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000B83")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool AutoPilot
	{
		[Token(Token = "0x6003647")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003648")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x6003642")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapChangeRequest()
	{
	}

	[Token(Token = "0x6003643")]
	[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapChangeRequest(MapChangeRequest other)
	{
	}

	[Token(Token = "0x6003644")]
	[Address(RVA = "0xA02290", Offset = "0xA01690", VA = "0x180A02290", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapChangeRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003649")]
	[Address(RVA = "0xA02320", Offset = "0xA01720", VA = "0x180A02320", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600364A")]
	[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MapChangeRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600364B")]
	[Address(RVA = "0xA023B0", Offset = "0xA017B0", VA = "0x180A023B0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600364C")]
	[Address(RVA = "0xA02470", Offset = "0xA01870", VA = "0x180A02470", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600364D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600364E")]
	[Address(RVA = "0x980260", Offset = "0x97F660", VA = "0x180980260", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600364F")]
	[Address(RVA = "0xA02200", Offset = "0xA01600", VA = "0x180A02200", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003650")]
	[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MapChangeRequest other)
	{
	}

	[Token(Token = "0x6003651")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003652")]
	[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
