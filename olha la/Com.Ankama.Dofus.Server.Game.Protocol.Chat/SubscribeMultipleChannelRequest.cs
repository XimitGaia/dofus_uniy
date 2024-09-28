using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Chat;

[Token(Token = "0x200085A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SubscribeMultipleChannelRequest : IMessage<SubscribeMultipleChannelRequest>, IMessage, IEquatable<SubscribeMultipleChannelRequest>, IDeepCloneable<SubscribeMultipleChannelRequest>, IBufferMessage
{
	[Token(Token = "0x4001CF4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<SubscribeMultipleChannelRequest> _parser;

	[Token(Token = "0x4001CF5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001CF6")]
	public const int ChannelEnabledFieldNumber = 1;

	[Token(Token = "0x4001CF7")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Channel> _repeated_channelEnabled_codec;

	[Token(Token = "0x4001CF8")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Channel> channelEnabled_;

	[Token(Token = "0x4001CF9")]
	public const int ChannelDisabledFieldNumber = 2;

	[Token(Token = "0x4001CFA")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<Channel> _repeated_channelDisabled_codec;

	[Token(Token = "0x4001CFB")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Channel> channelDisabled_;

	[Token(Token = "0x170012E7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SubscribeMultipleChannelRequest> Parser
	{
		[Token(Token = "0x60058B9")]
		[Address(RVA = "0xB12050", Offset = "0xB11450", VA = "0x180B12050")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012E8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60058BA")]
		[Address(RVA = "0xB11FA0", Offset = "0xB113A0", VA = "0x180B11FA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012E9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60058BB")]
		[Address(RVA = "0xB122E0", Offset = "0xB116E0", VA = "0x180B122E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012EA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Channel> ChannelEnabled
	{
		[Token(Token = "0x60058BF")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012EB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Channel> ChannelDisabled
	{
		[Token(Token = "0x60058C0")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60058BC")]
	[Address(RVA = "0xB11E40", Offset = "0xB11240", VA = "0x180B11E40")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubscribeMultipleChannelRequest()
	{
	}

	[Token(Token = "0x60058BD")]
	[Address(RVA = "0xB11EF0", Offset = "0xB112F0", VA = "0x180B11EF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubscribeMultipleChannelRequest(SubscribeMultipleChannelRequest other)
	{
	}

	[Token(Token = "0x60058BE")]
	[Address(RVA = "0xB11810", Offset = "0xB10C10", VA = "0x180B11810", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SubscribeMultipleChannelRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60058C1")]
	[Address(RVA = "0xB119A0", Offset = "0xB10DA0", VA = "0x180B119A0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60058C2")]
	[Address(RVA = "0xB118F0", Offset = "0xB10CF0", VA = "0x180B118F0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SubscribeMultipleChannelRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60058C3")]
	[Address(RVA = "0x943E20", Offset = "0x943220", VA = "0x180943E20", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60058C4")]
	[Address(RVA = "0xB11B30", Offset = "0xB10F30", VA = "0x180B11B30", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60058C5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60058C6")]
	[Address(RVA = "0xB12200", Offset = "0xB11600", VA = "0x180B12200", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60058C7")]
	[Address(RVA = "0xB11730", Offset = "0xB10B30", VA = "0x180B11730", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60058C8")]
	[Address(RVA = "0xB11A90", Offset = "0xB10E90", VA = "0x180B11A90", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SubscribeMultipleChannelRequest other)
	{
	}

	[Token(Token = "0x60058C9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60058CA")]
	[Address(RVA = "0xB120A0", Offset = "0xB114A0", VA = "0x180B120A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
