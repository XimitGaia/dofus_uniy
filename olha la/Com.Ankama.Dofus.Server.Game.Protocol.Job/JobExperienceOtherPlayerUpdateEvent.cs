using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job;

[Token(Token = "0x2000351")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JobExperienceOtherPlayerUpdateEvent : IMessage<JobExperienceOtherPlayerUpdateEvent>, IMessage, IEquatable<JobExperienceOtherPlayerUpdateEvent>, IDeepCloneable<JobExperienceOtherPlayerUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4000B6A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JobExperienceOtherPlayerUpdateEvent> _parser;

	[Token(Token = "0x4000B6B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000B6C")]
	public const int ExperienceFieldNumber = 1;

	[Token(Token = "0x4000B6D")]
	[FieldOffset(Offset = "0x18")]
	private JobExperience experience_;

	[Token(Token = "0x4000B6E")]
	public const int PlayerIdFieldNumber = 2;

	[Token(Token = "0x4000B6F")]
	[FieldOffset(Offset = "0x20")]
	private long playerId_;

	[Token(Token = "0x17000759")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JobExperienceOtherPlayerUpdateEvent> Parser
	{
		[Token(Token = "0x6002254")]
		[Address(RVA = "0x971FB0", Offset = "0x9713B0", VA = "0x180971FB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700075A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002255")]
		[Address(RVA = "0x971F00", Offset = "0x971300", VA = "0x180971F00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700075B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002256")]
		[Address(RVA = "0x9721A0", Offset = "0x9715A0", VA = "0x1809721A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700075C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobExperience Experience
	{
		[Token(Token = "0x600225A")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600225B")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x1700075D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PlayerId
	{
		[Token(Token = "0x600225C")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600225D")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6002257")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobExperienceOtherPlayerUpdateEvent()
	{
	}

	[Token(Token = "0x6002258")]
	[Address(RVA = "0x971E00", Offset = "0x971200", VA = "0x180971E00")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobExperienceOtherPlayerUpdateEvent(JobExperienceOtherPlayerUpdateEvent other)
	{
	}

	[Token(Token = "0x6002259")]
	[Address(RVA = "0x971870", Offset = "0x970C70", VA = "0x180971870", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobExperienceOtherPlayerUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600225E")]
	[Address(RVA = "0x971A10", Offset = "0x970E10", VA = "0x180971A10", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600225F")]
	[Address(RVA = "0x9719A0", Offset = "0x970DA0", VA = "0x1809719A0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JobExperienceOtherPlayerUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002260")]
	[Address(RVA = "0x971AD0", Offset = "0x970ED0", VA = "0x180971AD0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002261")]
	[Address(RVA = "0x971CA0", Offset = "0x9710A0", VA = "0x180971CA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002262")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002263")]
	[Address(RVA = "0x972120", Offset = "0x971520", VA = "0x180972120", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002264")]
	[Address(RVA = "0x9717B0", Offset = "0x970BB0", VA = "0x1809717B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002265")]
	[Address(RVA = "0x971B60", Offset = "0x970F60", VA = "0x180971B60", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JobExperienceOtherPlayerUpdateEvent other)
	{
	}

	[Token(Token = "0x6002266")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002267")]
	[Address(RVA = "0x972000", Offset = "0x971400", VA = "0x180972000", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
