using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Teleportation;

[Token(Token = "0x2000075")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TeleportDestinationsEvent : IMessage<TeleportDestinationsEvent>, IMessage, IEquatable<TeleportDestinationsEvent>, IDeepCloneable<TeleportDestinationsEvent>, IBufferMessage
{
	[Token(Token = "0x400016F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TeleportDestinationsEvent> _parser;

	[Token(Token = "0x4000170")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000171")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4000172")]
	public const int TypeFieldNumber = 1;

	[Token(Token = "0x4000173")]
	[FieldOffset(Offset = "0x1C")]
	private Teleporter type_;

	[Token(Token = "0x4000174")]
	public const int DestinationsFieldNumber = 2;

	[Token(Token = "0x4000175")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<TeleportDestination> _repeated_destinations_codec;

	[Token(Token = "0x4000176")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<TeleportDestination> destinations_;

	[Token(Token = "0x4000177")]
	public const int SpawnMapIdFieldNumber = 3;

	[Token(Token = "0x4000178")]
	[FieldOffset(Offset = "0x10")]
	private static readonly long SpawnMapIdDefaultValue;

	[Token(Token = "0x4000179")]
	[FieldOffset(Offset = "0x28")]
	private long spawnMapId_;

	[Token(Token = "0x170000D4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TeleportDestinationsEvent> Parser
	{
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x9609A0", Offset = "0x95FDA0", VA = "0x1809609A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x9608F0", Offset = "0x95FCF0", VA = "0x1809608F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x960D00", Offset = "0x960100", VA = "0x180960D00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Teleporter Type
	{
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(Teleporter);
		}
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170000D8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<TeleportDestination> Destinations
	{
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long SpawnMapId
	{
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x9609F0", Offset = "0x95FDF0", VA = "0x1809609F0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x960DE0", Offset = "0x9601E0", VA = "0x180960DE0")]
		set
		{
		}
	}

	[Token(Token = "0x170000DA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasSpawnMapId
	{
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x9607D0", Offset = "0x95FBD0", VA = "0x1809607D0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TeleportDestinationsEvent()
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x960850", Offset = "0x95FC50", VA = "0x180960850")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TeleportDestinationsEvent(TeleportDestinationsEvent other)
	{
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x960180", Offset = "0x95F580", VA = "0x180960180", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TeleportDestinationsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearSpawnMapId()
	{
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x960310", Offset = "0x95F710", VA = "0x180960310", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x960250", Offset = "0x95F650", VA = "0x180960250", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TeleportDestinationsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x960410", Offset = "0x95F810", VA = "0x180960410", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0x9605B0", Offset = "0x95F9B0", VA = "0x1809605B0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x960BB0", Offset = "0x95FFB0", VA = "0x180960BB0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x960020", Offset = "0x95F420", VA = "0x180960020", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x960510", Offset = "0x95F910", VA = "0x180960510", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TeleportDestinationsEvent other)
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x960A60", Offset = "0x95FE60", VA = "0x180960A60", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
