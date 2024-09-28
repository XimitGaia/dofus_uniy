using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest;

[Token(Token = "0x20004F1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildChestCurrentListenersRemoveEvent : IMessage<GuildChestCurrentListenersRemoveEvent>, IMessage, IEquatable<GuildChestCurrentListenersRemoveEvent>, IDeepCloneable<GuildChestCurrentListenersRemoveEvent>, IBufferMessage
{
	[Token(Token = "0x40010CE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildChestCurrentListenersRemoveEvent> _parser;

	[Token(Token = "0x40010CF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40010D0")]
	public const int PlayersFieldNumber = 1;

	[Token(Token = "0x40010D1")]
	[FieldOffset(Offset = "0x18")]
	private string players_;

	[Token(Token = "0x17000B10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildChestCurrentListenersRemoveEvent> Parser
	{
		[Token(Token = "0x600342F")]
		[Address(RVA = "0x9ED340", Offset = "0x9EC740", VA = "0x1809ED340")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003430")]
		[Address(RVA = "0x9ED290", Offset = "0x9EC690", VA = "0x1809ED290")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003431")]
		[Address(RVA = "0x9ED450", Offset = "0x9EC850", VA = "0x1809ED450", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B13")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Players
	{
		[Token(Token = "0x6003435")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003436")]
		[Address(RVA = "0x9ED530", Offset = "0x9EC930", VA = "0x1809ED530")]
		set
		{
		}
	}

	[Token(Token = "0x6003432")]
	[Address(RVA = "0x9ED240", Offset = "0x9EC640", VA = "0x1809ED240")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildChestCurrentListenersRemoveEvent()
	{
	}

	[Token(Token = "0x6003433")]
	[Address(RVA = "0x9ED1A0", Offset = "0x9EC5A0", VA = "0x1809ED1A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestCurrentListenersRemoveEvent(GuildChestCurrentListenersRemoveEvent other)
	{
	}

	[Token(Token = "0x6003434")]
	[Address(RVA = "0x9ECE60", Offset = "0x9EC260", VA = "0x1809ECE60", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestCurrentListenersRemoveEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003437")]
	[Address(RVA = "0x9ECF30", Offset = "0x9EC330", VA = "0x1809ECF30", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003438")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildChestCurrentListenersRemoveEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003439")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600343A")]
	[Address(RVA = "0x9ED040", Offset = "0x9EC440", VA = "0x1809ED040", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600343B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600343C")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600343D")]
	[Address(RVA = "0x9ECDD0", Offset = "0x9EC1D0", VA = "0x1809ECDD0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600343E")]
	[Address(RVA = "0x9ECFE0", Offset = "0x9EC3E0", VA = "0x1809ECFE0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildChestCurrentListenersRemoveEvent other)
	{
	}

	[Token(Token = "0x600343F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003440")]
	[Address(RVA = "0x9ED390", Offset = "0x9EC790", VA = "0x1809ED390", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
