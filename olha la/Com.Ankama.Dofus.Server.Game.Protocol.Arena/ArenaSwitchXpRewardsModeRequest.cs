using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Arena;

[Token(Token = "0x2000BAC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ArenaSwitchXpRewardsModeRequest : IMessage<ArenaSwitchXpRewardsModeRequest>, IMessage, IEquatable<ArenaSwitchXpRewardsModeRequest>, IDeepCloneable<ArenaSwitchXpRewardsModeRequest>, IBufferMessage
{
	[Token(Token = "0x4002B92")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ArenaSwitchXpRewardsModeRequest> _parser;

	[Token(Token = "0x4002B93")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002B94")]
	public const int XpRewardsFieldNumber = 1;

	[Token(Token = "0x4002B95")]
	[FieldOffset(Offset = "0x18")]
	private bool xpRewards_;

	[Token(Token = "0x17001B0A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ArenaSwitchXpRewardsModeRequest> Parser
	{
		[Token(Token = "0x6007ACA")]
		[Address(RVA = "0xC342C0", Offset = "0xC336C0", VA = "0x180C342C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B0B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007ACB")]
		[Address(RVA = "0xC34210", Offset = "0xC33610", VA = "0x180C34210")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B0C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007ACC")]
		[Address(RVA = "0xC34310", Offset = "0xC33710", VA = "0x180C34310", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B0D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool XpRewards
	{
		[Token(Token = "0x6007AD0")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007AD1")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6007ACD")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaSwitchXpRewardsModeRequest()
	{
	}

	[Token(Token = "0x6007ACE")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ArenaSwitchXpRewardsModeRequest(ArenaSwitchXpRewardsModeRequest other)
	{
	}

	[Token(Token = "0x6007ACF")]
	[Address(RVA = "0xC33F00", Offset = "0xC33300", VA = "0x180C33F00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ArenaSwitchXpRewardsModeRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007AD2")]
	[Address(RVA = "0xC33F80", Offset = "0xC33380", VA = "0x180C33F80", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007AD3")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ArenaSwitchXpRewardsModeRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007AD4")]
	[Address(RVA = "0xC34010", Offset = "0xC33410", VA = "0x180C34010", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007AD5")]
	[Address(RVA = "0xC340B0", Offset = "0xC334B0", VA = "0x180C340B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007AD6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007AD7")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007AD8")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007AD9")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ArenaSwitchXpRewardsModeRequest other)
	{
	}

	[Token(Token = "0x6007ADA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007ADB")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
