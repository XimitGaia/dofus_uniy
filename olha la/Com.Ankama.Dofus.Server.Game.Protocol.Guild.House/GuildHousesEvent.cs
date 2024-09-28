using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.House;

[Token(Token = "0x20004CF")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildHousesEvent : IMessage<GuildHousesEvent>, IMessage, IEquatable<GuildHousesEvent>, IDeepCloneable<GuildHousesEvent>, IBufferMessage
{
	[Token(Token = "0x400106D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildHousesEvent> _parser;

	[Token(Token = "0x400106E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400106F")]
	public const int HousesFieldNumber = 1;

	[Token(Token = "0x4001070")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Com.Ankama.Dofus.Server.Game.Protocol.Common.House> _repeated_houses_codec;

	[Token(Token = "0x4001071")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.House> houses_;

	[Token(Token = "0x17000AC9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildHousesEvent> Parser
	{
		[Token(Token = "0x60032C5")]
		[Address(RVA = "0x9F4D60", Offset = "0x9F4160", VA = "0x1809F4D60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ACA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60032C6")]
		[Address(RVA = "0x9F4CB0", Offset = "0x9F40B0", VA = "0x1809F4CB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ACB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60032C7")]
		[Address(RVA = "0x9F4F70", Offset = "0x9F4370", VA = "0x1809F4F70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ACC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.House> Houses
	{
		[Token(Token = "0x60032CB")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60032C8")]
	[Address(RVA = "0x9F4C30", Offset = "0x9F4030", VA = "0x1809F4C30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildHousesEvent()
	{
	}

	[Token(Token = "0x60032C9")]
	[Address(RVA = "0x9F4BA0", Offset = "0x9F3FA0", VA = "0x1809F4BA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildHousesEvent(GuildHousesEvent other)
	{
	}

	[Token(Token = "0x60032CA")]
	[Address(RVA = "0x9F46F0", Offset = "0x9F3AF0", VA = "0x1809F46F0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildHousesEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60032CC")]
	[Address(RVA = "0x9F4840", Offset = "0x9F3C40", VA = "0x1809F4840", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60032CD")]
	[Address(RVA = "0x9F47B0", Offset = "0x9F3BB0", VA = "0x1809F47B0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildHousesEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60032CE")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60032CF")]
	[Address(RVA = "0x9F49A0", Offset = "0x9F3DA0", VA = "0x1809F49A0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60032D0")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60032D1")]
	[Address(RVA = "0x9F4EC0", Offset = "0x9F42C0", VA = "0x1809F4EC0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60032D2")]
	[Address(RVA = "0x9F4650", Offset = "0x9F3A50", VA = "0x1809F4650", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60032D3")]
	[Address(RVA = "0x9F4920", Offset = "0x9F3D20", VA = "0x1809F4920", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildHousesEvent other)
	{
	}

	[Token(Token = "0x60032D4")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60032D5")]
	[Address(RVA = "0x9F4DB0", Offset = "0x9F41B0", VA = "0x1809F4DB0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
