using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay;

[Token(Token = "0x2000164")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerFightFriendlyAnswerRequest : IMessage<PlayerFightFriendlyAnswerRequest>, IMessage, IEquatable<PlayerFightFriendlyAnswerRequest>, IDeepCloneable<PlayerFightFriendlyAnswerRequest>, IBufferMessage
{
	[Token(Token = "0x40004B7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PlayerFightFriendlyAnswerRequest> _parser;

	[Token(Token = "0x40004B8")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40004B9")]
	public const int FightIdFieldNumber = 1;

	[Token(Token = "0x40004BA")]
	[FieldOffset(Offset = "0x18")]
	private int fightId_;

	[Token(Token = "0x40004BB")]
	public const int AcceptFieldNumber = 2;

	[Token(Token = "0x40004BC")]
	[FieldOffset(Offset = "0x1C")]
	private bool accept_;

	[Token(Token = "0x170002F3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PlayerFightFriendlyAnswerRequest> Parser
	{
		[Token(Token = "0x6000DC5")]
		[Address(RVA = "0xC47820", Offset = "0xC46C20", VA = "0x180C47820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000DC6")]
		[Address(RVA = "0xC47770", Offset = "0xC46B70", VA = "0x180C47770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000DC7")]
		[Address(RVA = "0xC47870", Offset = "0xC46C70", VA = "0x180C47870", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002F6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FightId
	{
		[Token(Token = "0x6000DCB")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000DCC")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170002F7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Accept
	{
		[Token(Token = "0x6000DCD")]
		[Address(RVA = "0x8F7940", Offset = "0x8F6D40", VA = "0x1808F7940")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000DCE")]
		[Address(RVA = "0x928D40", Offset = "0x928140", VA = "0x180928D40")]
		set
		{
		}
	}

	[Token(Token = "0x6000DC8")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlayerFightFriendlyAnswerRequest()
	{
	}

	[Token(Token = "0x6000DC9")]
	[Address(RVA = "0x980070", Offset = "0x97F470", VA = "0x180980070")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PlayerFightFriendlyAnswerRequest(PlayerFightFriendlyAnswerRequest other)
	{
	}

	[Token(Token = "0x6000DCA")]
	[Address(RVA = "0xC47430", Offset = "0xC46830", VA = "0x180C47430", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerFightFriendlyAnswerRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000DCF")]
	[Address(RVA = "0xC474C0", Offset = "0xC468C0", VA = "0x180C474C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DD0")]
	[Address(RVA = "0x97FD20", Offset = "0x97F120", VA = "0x18097FD20", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerFightFriendlyAnswerRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000DD1")]
	[Address(RVA = "0xC47550", Offset = "0xC46950", VA = "0x180C47550", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000DD2")]
	[Address(RVA = "0xC47610", Offset = "0xC46A10", VA = "0x180C47610", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000DD3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000DD4")]
	[Address(RVA = "0x980260", Offset = "0x97F660", VA = "0x180980260", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000DD5")]
	[Address(RVA = "0xC473A0", Offset = "0xC467A0", VA = "0x180C473A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000DD6")]
	[Address(RVA = "0x97FEB0", Offset = "0x97F2B0", VA = "0x18097FEB0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PlayerFightFriendlyAnswerRequest other)
	{
	}

	[Token(Token = "0x6000DD7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000DD8")]
	[Address(RVA = "0x9801A0", Offset = "0x97F5A0", VA = "0x1809801A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
