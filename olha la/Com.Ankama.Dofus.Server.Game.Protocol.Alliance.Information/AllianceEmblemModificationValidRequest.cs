using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CA3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceEmblemModificationValidRequest : IMessage<AllianceEmblemModificationValidRequest>, IMessage, IEquatable<AllianceEmblemModificationValidRequest>, IDeepCloneable<AllianceEmblemModificationValidRequest>, IBufferMessage
{
	[Token(Token = "0x4002E94")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceEmblemModificationValidRequest> _parser;

	[Token(Token = "0x4002E95")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E96")]
	public const int AllianceEmblemFieldNumber = 1;

	[Token(Token = "0x4002E97")]
	[FieldOffset(Offset = "0x18")]
	private SocialEmblem allianceEmblem_;

	[Token(Token = "0x17001D1F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceEmblemModificationValidRequest> Parser
	{
		[Token(Token = "0x6008515")]
		[Address(RVA = "0xC8D590", Offset = "0xC8C990", VA = "0x180C8D590")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008516")]
		[Address(RVA = "0xC8D4E0", Offset = "0xC8C8E0", VA = "0x180C8D4E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D21")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008517")]
		[Address(RVA = "0xC8D6E0", Offset = "0xC8CAE0", VA = "0x180C8D6E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D22")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialEmblem AllianceEmblem
	{
		[Token(Token = "0x600851B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600851C")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6008518")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceEmblemModificationValidRequest()
	{
	}

	[Token(Token = "0x6008519")]
	[Address(RVA = "0x9D8CF0", Offset = "0x9D80F0", VA = "0x1809D8CF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceEmblemModificationValidRequest(AllianceEmblemModificationValidRequest other)
	{
	}

	[Token(Token = "0x600851A")]
	[Address(RVA = "0xC8D160", Offset = "0xC8C560", VA = "0x180C8D160", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceEmblemModificationValidRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600851D")]
	[Address(RVA = "0xC8D200", Offset = "0xC8C600", VA = "0x180C8D200", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600851E")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceEmblemModificationValidRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600851F")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008520")]
	[Address(RVA = "0xC8D380", Offset = "0xC8C780", VA = "0x180C8D380", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008521")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008522")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008523")]
	[Address(RVA = "0xC8D0D0", Offset = "0xC8C4D0", VA = "0x180C8D0D0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008524")]
	[Address(RVA = "0xC8D2B0", Offset = "0xC8C6B0", VA = "0x180C8D2B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceEmblemModificationValidRequest other)
	{
	}

	[Token(Token = "0x6008525")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008526")]
	[Address(RVA = "0xC8D5E0", Offset = "0xC8C9E0", VA = "0x180C8D5E0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
