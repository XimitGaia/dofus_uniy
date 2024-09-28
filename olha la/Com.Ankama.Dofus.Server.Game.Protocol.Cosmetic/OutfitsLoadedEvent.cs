using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C2B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitsLoadedEvent : IMessage<OutfitsLoadedEvent>, IMessage, IEquatable<OutfitsLoadedEvent>, IDeepCloneable<OutfitsLoadedEvent>, IBufferMessage
{
	[Token(Token = "0x4002D1A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitsLoadedEvent> _parser;

	[Token(Token = "0x4002D1B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002D1C")]
	public const int CurrentFieldNumber = 1;

	[Token(Token = "0x4002D1D")]
	[FieldOffset(Offset = "0x18")]
	private Outfit current_;

	[Token(Token = "0x4002D1E")]
	public const int OutfitsFieldNumber = 2;

	[Token(Token = "0x4002D1F")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Outfit> _repeated_outfits_codec;

	[Token(Token = "0x4002D20")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Outfit> outfits_;

	[Token(Token = "0x17001C14")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OutfitsLoadedEvent> Parser
	{
		[Token(Token = "0x6008007")]
		[Address(RVA = "0xC6C1F0", Offset = "0xC6B5F0", VA = "0x180C6C1F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C15")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008008")]
		[Address(RVA = "0xC6C140", Offset = "0xC6B540", VA = "0x180C6C140")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C16")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008009")]
		[Address(RVA = "0xC6C480", Offset = "0xC6B880", VA = "0x180C6C480", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C17")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Outfit Current
	{
		[Token(Token = "0x600800D")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600800E")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001C18")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<Outfit> Outfits
	{
		[Token(Token = "0x600800F")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600800A")]
	[Address(RVA = "0xC6C000", Offset = "0xC6B400", VA = "0x180C6C000")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitsLoadedEvent()
	{
	}

	[Token(Token = "0x600800B")]
	[Address(RVA = "0xC6C080", Offset = "0xC6B480", VA = "0x180C6C080")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitsLoadedEvent(OutfitsLoadedEvent other)
	{
	}

	[Token(Token = "0x600800C")]
	[Address(RVA = "0xC6BA90", Offset = "0xC6AE90", VA = "0x180C6BA90", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitsLoadedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008010")]
	[Address(RVA = "0xC6BC20", Offset = "0xC6B020", VA = "0x180C6BC20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008011")]
	[Address(RVA = "0xC6BB70", Offset = "0xC6AF70", VA = "0x180C6BB70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OutfitsLoadedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008012")]
	[Address(RVA = "0xA82900", Offset = "0xA81D00", VA = "0x180A82900", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008013")]
	[Address(RVA = "0xC6BE00", Offset = "0xC6B200", VA = "0x180C6BE00", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008014")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008015")]
	[Address(RVA = "0xC6C3B0", Offset = "0xC6B7B0", VA = "0x180C6C3B0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008016")]
	[Address(RVA = "0xC6B9B0", Offset = "0xC6ADB0", VA = "0x180C6B9B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008017")]
	[Address(RVA = "0xC6BD10", Offset = "0xC6B110", VA = "0x180C6BD10", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(OutfitsLoadedEvent other)
	{
	}

	[Token(Token = "0x6008018")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008019")]
	[Address(RVA = "0xC6C240", Offset = "0xC6B640", VA = "0x180C6C240", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
