using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job;

[Token(Token = "0x200034B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JobDescriptionEvent : IMessage<JobDescriptionEvent>, IMessage, IEquatable<JobDescriptionEvent>, IDeepCloneable<JobDescriptionEvent>, IBufferMessage
{
	[Token(Token = "0x4000B57")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JobDescriptionEvent> _parser;

	[Token(Token = "0x4000B58")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000B59")]
	public const int JobsFieldNumber = 1;

	[Token(Token = "0x4000B5A")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<JobDescription> _repeated_jobs_codec;

	[Token(Token = "0x4000B5B")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<JobDescription> jobs_;

	[Token(Token = "0x1700074C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JobDescriptionEvent> Parser
	{
		[Token(Token = "0x6002212")]
		[Address(RVA = "0x970A30", Offset = "0x96FE30", VA = "0x180970A30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700074D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002213")]
		[Address(RVA = "0x970980", Offset = "0x96FD80", VA = "0x180970980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700074E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002214")]
		[Address(RVA = "0x970C40", Offset = "0x970040", VA = "0x180970C40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700074F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JobDescription> Jobs
	{
		[Token(Token = "0x6002218")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002215")]
	[Address(RVA = "0x970900", Offset = "0x96FD00", VA = "0x180970900")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobDescriptionEvent()
	{
	}

	[Token(Token = "0x6002216")]
	[Address(RVA = "0x970870", Offset = "0x96FC70", VA = "0x180970870")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobDescriptionEvent(JobDescriptionEvent other)
	{
	}

	[Token(Token = "0x6002217")]
	[Address(RVA = "0x9703C0", Offset = "0x96F7C0", VA = "0x1809703C0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobDescriptionEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002219")]
	[Address(RVA = "0x970510", Offset = "0x96F910", VA = "0x180970510", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600221A")]
	[Address(RVA = "0x970480", Offset = "0x96F880", VA = "0x180970480", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JobDescriptionEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600221B")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600221C")]
	[Address(RVA = "0x970670", Offset = "0x96FA70", VA = "0x180970670", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600221D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600221E")]
	[Address(RVA = "0x970B90", Offset = "0x96FF90", VA = "0x180970B90", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600221F")]
	[Address(RVA = "0x970320", Offset = "0x96F720", VA = "0x180970320", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002220")]
	[Address(RVA = "0x9705F0", Offset = "0x96F9F0", VA = "0x1809705F0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JobDescriptionEvent other)
	{
	}

	[Token(Token = "0x6002221")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002222")]
	[Address(RVA = "0x970A80", Offset = "0x96FE80", VA = "0x180970A80", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
