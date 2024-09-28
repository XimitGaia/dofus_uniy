using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Chest;

[Token(Token = "0x20004EF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildChestCurrentListenersAddEvent : IMessage<GuildChestCurrentListenersAddEvent>, IMessage, IEquatable<GuildChestCurrentListenersAddEvent>, IDeepCloneable<GuildChestCurrentListenersAddEvent>, IBufferMessage
{
	[Token(Token = "0x40010C9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildChestCurrentListenersAddEvent> _parser;

	[Token(Token = "0x40010CA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40010CB")]
	public const int PlayersFieldNumber = 1;

	[Token(Token = "0x40010CC")]
	[FieldOffset(Offset = "0x18")]
	private string players_;

	[Token(Token = "0x17000B0C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildChestCurrentListenersAddEvent> Parser
	{
		[Token(Token = "0x6003419")]
		[Address(RVA = "0x9EC1E0", Offset = "0x9EB5E0", VA = "0x1809EC1E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B0D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600341A")]
		[Address(RVA = "0x9EC130", Offset = "0x9EB530", VA = "0x1809EC130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B0E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600341B")]
		[Address(RVA = "0x9EC2F0", Offset = "0x9EB6F0", VA = "0x1809EC2F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B0F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Players
	{
		[Token(Token = "0x600341F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003420")]
		[Address(RVA = "0x9EC3D0", Offset = "0x9EB7D0", VA = "0x1809EC3D0")]
		set
		{
		}
	}

	[Token(Token = "0x600341C")]
	[Address(RVA = "0x9EC040", Offset = "0x9EB440", VA = "0x1809EC040")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestCurrentListenersAddEvent()
	{
	}

	[Token(Token = "0x600341D")]
	[Address(RVA = "0x9EC090", Offset = "0x9EB490", VA = "0x1809EC090")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildChestCurrentListenersAddEvent(GuildChestCurrentListenersAddEvent other)
	{
	}

	[Token(Token = "0x600341E")]
	[Address(RVA = "0x9EBD00", Offset = "0x9EB100", VA = "0x1809EBD00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildChestCurrentListenersAddEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003421")]
	[Address(RVA = "0x9EBDD0", Offset = "0x9EB1D0", VA = "0x1809EBDD0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003422")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildChestCurrentListenersAddEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003423")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003424")]
	[Address(RVA = "0x9EBEE0", Offset = "0x9EB2E0", VA = "0x1809EBEE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003425")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003426")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003427")]
	[Address(RVA = "0x9EBC70", Offset = "0x9EB070", VA = "0x1809EBC70", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003428")]
	[Address(RVA = "0x9EBE80", Offset = "0x9EB280", VA = "0x1809EBE80", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildChestCurrentListenersAddEvent other)
	{
	}

	[Token(Token = "0x6003429")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600342A")]
	[Address(RVA = "0x9EC230", Offset = "0x9EB630", VA = "0x1809EC230", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
