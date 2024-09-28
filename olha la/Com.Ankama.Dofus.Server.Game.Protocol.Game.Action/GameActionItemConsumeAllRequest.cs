using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Game.Action;

[Token(Token = "0x200055B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GameActionItemConsumeAllRequest : IMessage<GameActionItemConsumeAllRequest>, IMessage, IEquatable<GameActionItemConsumeAllRequest>, IDeepCloneable<GameActionItemConsumeAllRequest>, IBufferMessage
{
	[Token(Token = "0x4001262")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GameActionItemConsumeAllRequest> _parser;

	[Token(Token = "0x4001263")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001264")]
	public const int PlayerIdFieldNumber = 1;

	[Token(Token = "0x4001265")]
	[FieldOffset(Offset = "0x18")]
	private long playerId_;

	[Token(Token = "0x17000C10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GameActionItemConsumeAllRequest> Parser
	{
		[Token(Token = "0x60038BD")]
		[Address(RVA = "0xA1B520", Offset = "0xA1A920", VA = "0x180A1B520")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60038BE")]
		[Address(RVA = "0xA1B470", Offset = "0xA1A870", VA = "0x180A1B470")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60038BF")]
		[Address(RVA = "0xA1B570", Offset = "0xA1A970", VA = "0x180A1B570", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000C13")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PlayerId
	{
		[Token(Token = "0x60038C3")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60038C4")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x60038C0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionItemConsumeAllRequest()
	{
	}

	[Token(Token = "0x60038C1")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionItemConsumeAllRequest(GameActionItemConsumeAllRequest other)
	{
	}

	[Token(Token = "0x60038C2")]
	[Address(RVA = "0xA1B200", Offset = "0xA1A600", VA = "0x180A1B200", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GameActionItemConsumeAllRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60038C5")]
	[Address(RVA = "0xA1B280", Offset = "0xA1A680", VA = "0x180A1B280", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60038C6")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GameActionItemConsumeAllRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60038C7")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60038C8")]
	[Address(RVA = "0xA1B310", Offset = "0xA1A710", VA = "0x180A1B310", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60038C9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60038CA")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60038CB")]
	[Address(RVA = "0xA1B170", Offset = "0xA1A570", VA = "0x180A1B170", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60038CC")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GameActionItemConsumeAllRequest other)
	{
	}

	[Token(Token = "0x60038CD")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60038CE")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
