using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest;

[Token(Token = "0x20004ED")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildChestCurrentListenersEvent : IMessage<GuildChestCurrentListenersEvent>, IMessage, IEquatable<GuildChestCurrentListenersEvent>, IDeepCloneable<GuildChestCurrentListenersEvent>, IBufferMessage
{
	[Token(Token = "0x40010C3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildChestCurrentListenersEvent> _parser;

	[Token(Token = "0x40010C4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40010C5")]
	public const int PlayersFieldNumber = 1;

	[Token(Token = "0x40010C6")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<string> _repeated_players_codec;

	[Token(Token = "0x40010C7")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<string> players_;

	[Token(Token = "0x17000B08")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildChestCurrentListenersEvent> Parser
	{
		[Token(Token = "0x6003404")]
		[Address(RVA = "0x9ECAE0", Offset = "0x9EBEE0", VA = "0x1809ECAE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B09")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003405")]
		[Address(RVA = "0x9ECA30", Offset = "0x9EBE30", VA = "0x1809ECA30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B0A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003406")]
		[Address(RVA = "0x9ECCF0", Offset = "0x9EC0F0", VA = "0x1809ECCF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B0B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<string> Players
	{
		[Token(Token = "0x600340A")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003407")]
	[Address(RVA = "0x9EC920", Offset = "0x9EBD20", VA = "0x1809EC920")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestCurrentListenersEvent()
	{
	}

	[Token(Token = "0x6003408")]
	[Address(RVA = "0x9EC9A0", Offset = "0x9EBDA0", VA = "0x1809EC9A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestCurrentListenersEvent(GuildChestCurrentListenersEvent other)
	{
	}

	[Token(Token = "0x6003409")]
	[Address(RVA = "0x9EC4E0", Offset = "0x9EB8E0", VA = "0x1809EC4E0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildChestCurrentListenersEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600340B")]
	[Address(RVA = "0x9EC5A0", Offset = "0x9EB9A0", VA = "0x1809EC5A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600340C")]
	[Address(RVA = "0x9EC680", Offset = "0x9EBA80", VA = "0x1809EC680", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildChestCurrentListenersEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600340D")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600340E")]
	[Address(RVA = "0x9EC790", Offset = "0x9EBB90", VA = "0x1809EC790", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600340F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003410")]
	[Address(RVA = "0x9ECC40", Offset = "0x9EC040", VA = "0x1809ECC40", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003411")]
	[Address(RVA = "0x9EC440", Offset = "0x9EB840", VA = "0x1809EC440", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003412")]
	[Address(RVA = "0x9EC710", Offset = "0x9EBB10", VA = "0x1809EC710", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildChestCurrentListenersEvent other)
	{
	}

	[Token(Token = "0x6003413")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003414")]
	[Address(RVA = "0x9ECB30", Offset = "0x9EBF30", VA = "0x1809ECB30", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
