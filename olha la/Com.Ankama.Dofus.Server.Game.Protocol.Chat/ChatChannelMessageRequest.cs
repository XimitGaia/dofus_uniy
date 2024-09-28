using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Chat;

[Token(Token = "0x2000852")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChatChannelMessageRequest : IMessage<ChatChannelMessageRequest>, IMessage, IEquatable<ChatChannelMessageRequest>, IDeepCloneable<ChatChannelMessageRequest>, IBufferMessage
{
	[Token(Token = "0x4001CBF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ChatChannelMessageRequest> _parser;

	[Token(Token = "0x4001CC0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001CC1")]
	public const int ContentFieldNumber = 1;

	[Token(Token = "0x4001CC2")]
	[FieldOffset(Offset = "0x18")]
	private string content_;

	[Token(Token = "0x4001CC3")]
	public const int ChannelFieldNumber = 2;

	[Token(Token = "0x4001CC4")]
	[FieldOffset(Offset = "0x20")]
	private Channel channel_;

	[Token(Token = "0x4001CC5")]
	public const int ObjectFieldNumber = 3;

	[Token(Token = "0x4001CC6")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<ObjectItemInventory> _repeated_object_codec;

	[Token(Token = "0x4001CC7")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<ObjectItemInventory> object_;

	[Token(Token = "0x170012CF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChatChannelMessageRequest> Parser
	{
		[Token(Token = "0x6005861")]
		[Address(RVA = "0xAFFA90", Offset = "0xAFEE90", VA = "0x180AFFA90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005862")]
		[Address(RVA = "0xAFF9E0", Offset = "0xAFEDE0", VA = "0x180AFF9E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012D1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005863")]
		[Address(RVA = "0xAFFD40", Offset = "0xAFF140", VA = "0x180AFFD40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170012D2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Content
	{
		[Token(Token = "0x6005867")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005868")]
		[Address(RVA = "0xAFFE20", Offset = "0xAFF220", VA = "0x180AFFE20")]
		set
		{
		}
	}

	[Token(Token = "0x170012D3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Channel Channel
	{
		[Token(Token = "0x6005869")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(Channel);
		}
		[Token(Token = "0x600586A")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x170012D4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ObjectItemInventory> Object
	{
		[Token(Token = "0x600586B")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005864")]
	[Address(RVA = "0xAFF940", Offset = "0xAFED40", VA = "0x180AFF940")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ChatChannelMessageRequest()
	{
	}

	[Token(Token = "0x6005865")]
	[Address(RVA = "0xAFF8A0", Offset = "0xAFECA0", VA = "0x180AFF8A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatChannelMessageRequest(ChatChannelMessageRequest other)
	{
	}

	[Token(Token = "0x6005866")]
	[Address(RVA = "0xAFF2E0", Offset = "0xAFE6E0", VA = "0x180AFF2E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChatChannelMessageRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600586C")]
	[Address(RVA = "0xAFF460", Offset = "0xAFE860", VA = "0x180AFF460", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600586D")]
	[Address(RVA = "0xAFF3B0", Offset = "0xAFE7B0", VA = "0x180AFF3B0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ChatChannelMessageRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600586E")]
	[Address(RVA = "0xAFF550", Offset = "0xAFE950", VA = "0x180AFF550", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600586F")]
	[Address(RVA = "0xAFF6A0", Offset = "0xAFEAA0", VA = "0x180AFF6A0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005870")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005871")]
	[Address(RVA = "0xAFFC40", Offset = "0xAFF040", VA = "0x180AFFC40", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005872")]
	[Address(RVA = "0xAFF1C0", Offset = "0xAFE5C0", VA = "0x180AFF1C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005873")]
	[Address(RVA = "0xAFF600", Offset = "0xAFEA00", VA = "0x180AFF600", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ChatChannelMessageRequest other)
	{
	}

	[Token(Token = "0x6005874")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005875")]
	[Address(RVA = "0xAFFAE0", Offset = "0xAFEEE0", VA = "0x180AFFAE0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
