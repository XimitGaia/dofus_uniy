using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Member;

[Token(Token = "0x2000C8A")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceInvitationRequest : IMessage<AllianceInvitationRequest>, IMessage, IEquatable<AllianceInvitationRequest>, IDeepCloneable<AllianceInvitationRequest>, IBufferMessage
{
	[Token(Token = "0x4002E4B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceInvitationRequest> _parser;

	[Token(Token = "0x4002E4C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E4D")]
	public const int CharacterIdFieldNumber = 1;

	[Token(Token = "0x4002E4E")]
	[FieldOffset(Offset = "0x18")]
	private long characterId_;

	[Token(Token = "0x17001CE8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceInvitationRequest> Parser
	{
		[Token(Token = "0x60083FF")]
		[Address(RVA = "0xC94560", Offset = "0xC93960", VA = "0x180C94560")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CE9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008400")]
		[Address(RVA = "0xC944B0", Offset = "0xC938B0", VA = "0x180C944B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CEA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008401")]
		[Address(RVA = "0xC945B0", Offset = "0xC939B0", VA = "0x180C945B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CEB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CharacterId
	{
		[Token(Token = "0x6008405")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6008406")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6008402")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInvitationRequest()
	{
	}

	[Token(Token = "0x6008403")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceInvitationRequest(AllianceInvitationRequest other)
	{
	}

	[Token(Token = "0x6008404")]
	[Address(RVA = "0xC94240", Offset = "0xC93640", VA = "0x180C94240", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInvitationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008407")]
	[Address(RVA = "0xC942C0", Offset = "0xC936C0", VA = "0x180C942C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008408")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceInvitationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008409")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600840A")]
	[Address(RVA = "0xC94350", Offset = "0xC93750", VA = "0x180C94350", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600840B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600840C")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600840D")]
	[Address(RVA = "0xC941B0", Offset = "0xC935B0", VA = "0x180C941B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600840E")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceInvitationRequest other)
	{
	}

	[Token(Token = "0x600840F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008410")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
