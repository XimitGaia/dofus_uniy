using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CC2")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceFactsEvent : IMessage<AllianceFactsEvent>, IMessage, IEquatable<AllianceFactsEvent>, IDeepCloneable<AllianceFactsEvent>, IBufferMessage
{
	[Token(Token = "0x4002F09")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceFactsEvent> _parser;

	[Token(Token = "0x4002F0A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002F0B")]
	public const int AllianceInformationFieldNumber = 1;

	[Token(Token = "0x4002F0C")]
	[FieldOffset(Offset = "0x18")]
	private AllianceInformation allianceInformation_;

	[Token(Token = "0x4002F0D")]
	public const int MembersFieldNumber = 2;

	[Token(Token = "0x4002F0E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> _repeated_members_codec;

	[Token(Token = "0x4002F0F")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> members_;

	[Token(Token = "0x4002F10")]
	public const int ControlledSubareaIdsFieldNumber = 3;

	[Token(Token = "0x4002F11")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<int> _repeated_controlledSubareaIds_codec;

	[Token(Token = "0x4002F12")]
	[FieldOffset(Offset = "0x28")]
	private readonly RepeatedField<int> controlledSubareaIds_;

	[Token(Token = "0x4002F13")]
	public const int LeaderIdFieldNumber = 4;

	[Token(Token = "0x4002F14")]
	[FieldOffset(Offset = "0x30")]
	private long leaderId_;

	[Token(Token = "0x4002F15")]
	public const int LeaderNameFieldNumber = 5;

	[Token(Token = "0x4002F16")]
	[FieldOffset(Offset = "0x38")]
	private string leaderName_;

	[Token(Token = "0x17001D67")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceFactsEvent> Parser
	{
		[Token(Token = "0x6008665")]
		[Address(RVA = "0xC8EBC0", Offset = "0xC8DFC0", VA = "0x180C8EBC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D68")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008666")]
		[Address(RVA = "0xC8EB10", Offset = "0xC8DF10", VA = "0x180C8EB10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D69")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008667")]
		[Address(RVA = "0xC8EFB0", Offset = "0xC8E3B0", VA = "0x180C8EFB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D6A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceInformation AllianceInformation
	{
		[Token(Token = "0x600866B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600866C")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001D6B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Com.Ankama.Dofus.Server.Game.Protocol.Common.Character> Members
	{
		[Token(Token = "0x600866D")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D6C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ControlledSubareaIds
	{
		[Token(Token = "0x600866E")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D6D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long LeaderId
	{
		[Token(Token = "0x600866F")]
		[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6008670")]
		[Address(RVA = "0x952BB0", Offset = "0x951FB0", VA = "0x180952BB0")]
		set
		{
		}
	}

	[Token(Token = "0x17001D6E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string LeaderName
	{
		[Token(Token = "0x6008671")]
		[Address(RVA = "0x87D8A0", Offset = "0x87CCA0", VA = "0x18087D8A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008672")]
		[Address(RVA = "0xC8F090", Offset = "0xC8E490", VA = "0x180C8F090")]
		set
		{
		}
	}

	[Token(Token = "0x6008668")]
	[Address(RVA = "0xC8E910", Offset = "0xC8DD10", VA = "0x180C8E910")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFactsEvent()
	{
	}

	[Token(Token = "0x6008669")]
	[Address(RVA = "0xC8EA00", Offset = "0xC8DE00", VA = "0x180C8EA00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFactsEvent(AllianceFactsEvent other)
	{
	}

	[Token(Token = "0x600866A")]
	[Address(RVA = "0xC8E110", Offset = "0xC8D510", VA = "0x180C8E110", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFactsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008673")]
	[Address(RVA = "0xC8E240", Offset = "0xC8D640", VA = "0x180C8E240", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008674")]
	[Address(RVA = "0xC8E380", Offset = "0xC8D780", VA = "0x180C8E380", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceFactsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008675")]
	[Address(RVA = "0xC8E480", Offset = "0xC8D880", VA = "0x180C8E480", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008676")]
	[Address(RVA = "0xC8E6D0", Offset = "0xC8DAD0", VA = "0x180C8E6D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008677")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008678")]
	[Address(RVA = "0xC8EE50", Offset = "0xC8E250", VA = "0x180C8EE50", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008679")]
	[Address(RVA = "0xC8DF90", Offset = "0xC8D390", VA = "0x180C8DF90", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600867A")]
	[Address(RVA = "0xC8E590", Offset = "0xC8D990", VA = "0x180C8E590", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceFactsEvent other)
	{
	}

	[Token(Token = "0x600867B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600867C")]
	[Address(RVA = "0xC8EC10", Offset = "0xC8E010", VA = "0x180C8EC10", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
