using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest;

[Token(Token = "0x2000CE3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceFightFinishedEvent : IMessage<AllianceFightFinishedEvent>, IMessage, IEquatable<AllianceFightFinishedEvent>, IDeepCloneable<AllianceFightFinishedEvent>, IBufferMessage
{
	[Token(Token = "0x4002F6C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceFightFinishedEvent> _parser;

	[Token(Token = "0x4002F6D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002F6E")]
	public const int FightInformationFieldNumber = 1;

	[Token(Token = "0x4002F6F")]
	[FieldOffset(Offset = "0x18")]
	private SocialFightInformation fightInformation_;

	[Token(Token = "0x17001DAF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceFightFinishedEvent> Parser
	{
		[Token(Token = "0x60087D1")]
		[Address(RVA = "0xCAB2D0", Offset = "0xCAA6D0", VA = "0x180CAB2D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DB0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60087D2")]
		[Address(RVA = "0xCAB220", Offset = "0xCAA620", VA = "0x180CAB220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DB1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60087D3")]
		[Address(RVA = "0xCAB420", Offset = "0xCAA820", VA = "0x180CAB420", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DB2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialFightInformation FightInformation
	{
		[Token(Token = "0x60087D7")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60087D8")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x60087D4")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFightFinishedEvent()
	{
	}

	[Token(Token = "0x60087D5")]
	[Address(RVA = "0xCAB1B0", Offset = "0xCAA5B0", VA = "0x180CAB1B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFightFinishedEvent(AllianceFightFinishedEvent other)
	{
	}

	[Token(Token = "0x60087D6")]
	[Address(RVA = "0xCAAE30", Offset = "0xCAA230", VA = "0x180CAAE30", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFightFinishedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60087D9")]
	[Address(RVA = "0xCAAED0", Offset = "0xCAA2D0", VA = "0x180CAAED0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60087DA")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceFightFinishedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60087DB")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60087DC")]
	[Address(RVA = "0xCAB050", Offset = "0xCAA450", VA = "0x180CAB050", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60087DD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60087DE")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60087DF")]
	[Address(RVA = "0xCAADA0", Offset = "0xCAA1A0", VA = "0x180CAADA0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60087E0")]
	[Address(RVA = "0xCAAF80", Offset = "0xCAA380", VA = "0x180CAAF80", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceFightFinishedEvent other)
	{
	}

	[Token(Token = "0x60087E1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60087E2")]
	[Address(RVA = "0xCAB320", Offset = "0xCAA720", VA = "0x180CAB320", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
