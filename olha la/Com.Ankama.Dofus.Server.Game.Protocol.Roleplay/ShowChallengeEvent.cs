using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Roleplay;

[Token(Token = "0x2000178")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ShowChallengeEvent : IMessage<ShowChallengeEvent>, IMessage, IEquatable<ShowChallengeEvent>, IDeepCloneable<ShowChallengeEvent>, IBufferMessage
{
	[Token(Token = "0x40004FF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ShowChallengeEvent> _parser;

	[Token(Token = "0x4000500")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000501")]
	public const int FightInformationFieldNumber = 1;

	[Token(Token = "0x4000502")]
	[FieldOffset(Offset = "0x18")]
	private FightCommonInformation fightInformation_;

	[Token(Token = "0x17000326")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ShowChallengeEvent> Parser
	{
		[Token(Token = "0x6000EB7")]
		[Address(RVA = "0xC54BC0", Offset = "0xC53FC0", VA = "0x180C54BC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000327")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000EB8")]
		[Address(RVA = "0xC54B10", Offset = "0xC53F10", VA = "0x180C54B10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000328")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000EB9")]
		[Address(RVA = "0xC54D10", Offset = "0xC54110", VA = "0x180C54D10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000329")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightCommonInformation FightInformation
	{
		[Token(Token = "0x6000EBD")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000EBE")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6000EBA")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShowChallengeEvent()
	{
	}

	[Token(Token = "0x6000EBB")]
	[Address(RVA = "0xC54AA0", Offset = "0xC53EA0", VA = "0x180C54AA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShowChallengeEvent(ShowChallengeEvent other)
	{
	}

	[Token(Token = "0x6000EBC")]
	[Address(RVA = "0xC54720", Offset = "0xC53B20", VA = "0x180C54720", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShowChallengeEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000EBF")]
	[Address(RVA = "0xC547C0", Offset = "0xC53BC0", VA = "0x180C547C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EC0")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ShowChallengeEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000EC1")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000EC2")]
	[Address(RVA = "0xC54940", Offset = "0xC53D40", VA = "0x180C54940", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000EC3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000EC4")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000EC5")]
	[Address(RVA = "0xC54690", Offset = "0xC53A90", VA = "0x180C54690", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000EC6")]
	[Address(RVA = "0xC54870", Offset = "0xC53C70", VA = "0x180C54870", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ShowChallengeEvent other)
	{
	}

	[Token(Token = "0x6000EC7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000EC8")]
	[Address(RVA = "0xC54C10", Offset = "0xC54010", VA = "0x180C54C10", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
