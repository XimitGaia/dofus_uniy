using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Quest;

[Token(Token = "0x2000193")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuestsFollowedOrderRefreshRequest : IMessage<QuestsFollowedOrderRefreshRequest>, IMessage, IEquatable<QuestsFollowedOrderRefreshRequest>, IDeepCloneable<QuestsFollowedOrderRefreshRequest>, IBufferMessage
{
	[Token(Token = "0x4000553")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<QuestsFollowedOrderRefreshRequest> _parser;

	[Token(Token = "0x4000554")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000555")]
	public const int QuestsFieldNumber = 1;

	[Token(Token = "0x4000556")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_quests_codec;

	[Token(Token = "0x4000557")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> quests_;

	[Token(Token = "0x17000364")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuestsFollowedOrderRefreshRequest> Parser
	{
		[Token(Token = "0x6000FE9")]
		[Address(RVA = "0xC4FF50", Offset = "0xC4F350", VA = "0x180C4FF50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000365")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000FEA")]
		[Address(RVA = "0xC4FEA0", Offset = "0xC4F2A0", VA = "0x180C4FEA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000366")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000FEB")]
		[Address(RVA = "0xC50170", Offset = "0xC4F570", VA = "0x180C50170", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000367")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Quests
	{
		[Token(Token = "0x6000FEF")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000FEC")]
	[Address(RVA = "0xC4FE20", Offset = "0xC4F220", VA = "0x180C4FE20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestsFollowedOrderRefreshRequest()
	{
	}

	[Token(Token = "0x6000FED")]
	[Address(RVA = "0xC4FD90", Offset = "0xC4F190", VA = "0x180C4FD90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestsFollowedOrderRefreshRequest(QuestsFollowedOrderRefreshRequest other)
	{
	}

	[Token(Token = "0x6000FEE")]
	[Address(RVA = "0xC4F950", Offset = "0xC4ED50", VA = "0x180C4F950", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuestsFollowedOrderRefreshRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000FF0")]
	[Address(RVA = "0xC4FAA0", Offset = "0xC4EEA0", VA = "0x180C4FAA0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FF1")]
	[Address(RVA = "0xC4FA10", Offset = "0xC4EE10", VA = "0x180C4FA10", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuestsFollowedOrderRefreshRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FF2")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000FF3")]
	[Address(RVA = "0xC4FC00", Offset = "0xC4F000", VA = "0x180C4FC00", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000FF4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000FF5")]
	[Address(RVA = "0xC500C0", Offset = "0xC4F4C0", VA = "0x180C500C0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000FF6")]
	[Address(RVA = "0xC4F8B0", Offset = "0xC4ECB0", VA = "0x180C4F8B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000FF7")]
	[Address(RVA = "0xC4FB80", Offset = "0xC4EF80", VA = "0x180C4FB80", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuestsFollowedOrderRefreshRequest other)
	{
	}

	[Token(Token = "0x6000FF8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000FF9")]
	[Address(RVA = "0xC4FFA0", Offset = "0xC4F3A0", VA = "0x180C4FFA0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
