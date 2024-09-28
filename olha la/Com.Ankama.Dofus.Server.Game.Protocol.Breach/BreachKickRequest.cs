using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Breach;

[Token(Token = "0x20008F5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BreachKickRequest : IMessage<BreachKickRequest>, IMessage, IEquatable<BreachKickRequest>, IDeepCloneable<BreachKickRequest>, IBufferMessage
{
	[Token(Token = "0x4001EB3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BreachKickRequest> _parser;

	[Token(Token = "0x4001EB4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001EB5")]
	public const int PlayerIdFieldNumber = 1;

	[Token(Token = "0x4001EB6")]
	[FieldOffset(Offset = "0x18")]
	private long playerId_;

	[Token(Token = "0x17001412")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BreachKickRequest> Parser
	{
		[Token(Token = "0x6005EC5")]
		[Address(RVA = "0xB52470", Offset = "0xB51870", VA = "0x180B52470")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001413")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005EC6")]
		[Address(RVA = "0xB523C0", Offset = "0xB517C0", VA = "0x180B523C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001414")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005EC7")]
		[Address(RVA = "0xB524C0", Offset = "0xB518C0", VA = "0x180B524C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001415")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long PlayerId
	{
		[Token(Token = "0x6005ECB")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005ECC")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6005EC8")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BreachKickRequest()
	{
	}

	[Token(Token = "0x6005EC9")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachKickRequest(BreachKickRequest other)
	{
	}

	[Token(Token = "0x6005ECA")]
	[Address(RVA = "0xB52150", Offset = "0xB51550", VA = "0x180B52150", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BreachKickRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005ECD")]
	[Address(RVA = "0xB521D0", Offset = "0xB515D0", VA = "0x180B521D0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005ECE")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BreachKickRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005ECF")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005ED0")]
	[Address(RVA = "0xB52260", Offset = "0xB51660", VA = "0x180B52260", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005ED1")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005ED2")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005ED3")]
	[Address(RVA = "0xB520C0", Offset = "0xB514C0", VA = "0x180B520C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005ED4")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BreachKickRequest other)
	{
	}

	[Token(Token = "0x6005ED5")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005ED6")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
