using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social;

[Token(Token = "0x2000130")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JoinFriendRequest : IMessage<JoinFriendRequest>, IMessage, IEquatable<JoinFriendRequest>, IDeepCloneable<JoinFriendRequest>, IBufferMessage
{
	[Token(Token = "0x4000417")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JoinFriendRequest> _parser;

	[Token(Token = "0x4000418")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000419")]
	public const int ActorIdFieldNumber = 1;

	[Token(Token = "0x400041A")]
	[FieldOffset(Offset = "0x18")]
	private long actorId_;

	[Token(Token = "0x17000286")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<JoinFriendRequest> Parser
	{
		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0xB679F0", Offset = "0xB66DF0", VA = "0x180B679F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000287")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0xB67940", Offset = "0xB66D40", VA = "0x180B67940")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000288")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0xB67A40", Offset = "0xB66E40", VA = "0x180B67A40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000289")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long ActorId
	{
		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6000BCB")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JoinFriendRequest()
	{
	}

	[Token(Token = "0x6000BCC")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JoinFriendRequest(JoinFriendRequest other)
	{
	}

	[Token(Token = "0x6000BCD")]
	[Address(RVA = "0xB676D0", Offset = "0xB66AD0", VA = "0x180B676D0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JoinFriendRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000BD0")]
	[Address(RVA = "0xB67750", Offset = "0xB66B50", VA = "0x180B67750", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000BD1")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JoinFriendRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000BD2")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000BD3")]
	[Address(RVA = "0xB677E0", Offset = "0xB66BE0", VA = "0x180B677E0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000BD4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000BD5")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000BD6")]
	[Address(RVA = "0xB67640", Offset = "0xB66A40", VA = "0x180B67640", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000BD7")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(JoinFriendRequest other)
	{
	}

	[Token(Token = "0x6000BD8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000BD9")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
