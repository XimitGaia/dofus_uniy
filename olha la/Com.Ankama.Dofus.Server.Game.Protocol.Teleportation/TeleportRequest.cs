using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation;

[Token(Token = "0x2000067")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TeleportRequest : IMessage<TeleportRequest>, IMessage, IEquatable<TeleportRequest>, IDeepCloneable<TeleportRequest>, IBufferMessage
{
	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TeleportRequest> _parser;

	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400014C")]
	public const int SourceTypeFieldNumber = 1;

	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x18")]
	private Teleporter sourceType_;

	[Token(Token = "0x400014E")]
	public const int DestinationTypeFieldNumber = 2;

	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0x1C")]
	private Teleporter destinationType_;

	[Token(Token = "0x4000150")]
	public const int MapIdFieldNumber = 3;

	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0x20")]
	private long mapId_;

	[Token(Token = "0x170000B7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TeleportRequest> Parser
	{
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x962940", Offset = "0x961D40", VA = "0x180962940")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x962890", Offset = "0x961C90", VA = "0x180962890")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x962B00", Offset = "0x961F00", VA = "0x180962B00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000BA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Teleporter SourceType
	{
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Teleporter);
		}
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170000BB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Teleporter DestinationType
	{
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Teleporter);
		}
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170000BC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long MapId
	{
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TeleportRequest()
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x962830", Offset = "0x961C30", VA = "0x180962830")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportRequest(TeleportRequest other)
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x962440", Offset = "0x961840", VA = "0x180962440", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TeleportRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x9624D0", Offset = "0x9618D0", VA = "0x1809624D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x962570", Offset = "0x961970", VA = "0x180962570", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TeleportRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x9625B0", Offset = "0x9619B0", VA = "0x1809625B0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x9626D0", Offset = "0x961AD0", VA = "0x1809626D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x962A60", Offset = "0x961E60", VA = "0x180962A60", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x962360", Offset = "0x961760", VA = "0x180962360", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x962660", Offset = "0x961A60", VA = "0x180962660", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TeleportRequest other)
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x962990", Offset = "0x961D90", VA = "0x180962990", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
