using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Chat;

[Token(Token = "0x200085E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChatChannelsEnabledEvent : IMessage<ChatChannelsEnabledEvent>, IMessage, IEquatable<ChatChannelsEnabledEvent>, IDeepCloneable<ChatChannelsEnabledEvent>, IBufferMessage
{
	[Token(Token = "0x4001D04")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChatChannelsEnabledEvent> _parser;

	[Token(Token = "0x4001D05")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001D06")]
	public const int ActiveChannelsFieldNumber = 1;

	[Token(Token = "0x4001D07")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Channel> _repeated_activeChannels_codec;

	[Token(Token = "0x4001D08")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Channel> activeChannels_;

	[Token(Token = "0x4001D09")]
	public const int DisabledChannelsFieldNumber = 2;

	[Token(Token = "0x4001D0A")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<Channel> _repeated_disabledChannels_codec;

	[Token(Token = "0x4001D0B")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Channel> disabledChannels_;

	[Token(Token = "0x170012F1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ChatChannelsEnabledEvent> Parser
	{
		[Token(Token = "0x60058EB")]
		[Address(RVA = "0xB007B0", Offset = "0xAFFBB0", VA = "0x180B007B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012F2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60058EC")]
		[Address(RVA = "0xB00700", Offset = "0xAFFB00", VA = "0x180B00700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012F3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60058ED")]
		[Address(RVA = "0xB00A40", Offset = "0xAFFE40", VA = "0x180B00A40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012F4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Channel> ActiveChannels
	{
		[Token(Token = "0x60058F1")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012F5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Channel> DisabledChannels
	{
		[Token(Token = "0x60058F2")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60058EE")]
	[Address(RVA = "0xB00650", Offset = "0xAFFA50", VA = "0x180B00650")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatChannelsEnabledEvent()
	{
	}

	[Token(Token = "0x60058EF")]
	[Address(RVA = "0xB005A0", Offset = "0xAFF9A0", VA = "0x180B005A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatChannelsEnabledEvent(ChatChannelsEnabledEvent other)
	{
	}

	[Token(Token = "0x60058F0")]
	[Address(RVA = "0xAFFF70", Offset = "0xAFF370", VA = "0x180AFFF70", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatChannelsEnabledEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60058F3")]
	[Address(RVA = "0xB00050", Offset = "0xAFF450", VA = "0x180B00050", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60058F4")]
	[Address(RVA = "0xB00140", Offset = "0xAFF540", VA = "0x180B00140", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ChatChannelsEnabledEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60058F5")]
	[Address(RVA = "0x943E20", Offset = "0x943220", VA = "0x180943E20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60058F6")]
	[Address(RVA = "0xB00290", Offset = "0xAFF690", VA = "0x180B00290", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60058F7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60058F8")]
	[Address(RVA = "0xB00960", Offset = "0xAFFD60", VA = "0x180B00960", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60058F9")]
	[Address(RVA = "0xAFFE90", Offset = "0xAFF290", VA = "0x180AFFE90", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60058FA")]
	[Address(RVA = "0xB001F0", Offset = "0xAFF5F0", VA = "0x180B001F0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChatChannelsEnabledEvent other)
	{
	}

	[Token(Token = "0x60058FB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60058FC")]
	[Address(RVA = "0xB00800", Offset = "0xAFFC00", VA = "0x180B00800", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
