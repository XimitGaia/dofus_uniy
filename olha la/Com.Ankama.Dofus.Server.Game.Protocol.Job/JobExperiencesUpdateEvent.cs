using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job;

[Token(Token = "0x200034F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JobExperiencesUpdateEvent : IMessage<JobExperiencesUpdateEvent>, IMessage, IEquatable<JobExperiencesUpdateEvent>, IDeepCloneable<JobExperiencesUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4000B64")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JobExperiencesUpdateEvent> _parser;

	[Token(Token = "0x4000B65")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000B66")]
	public const int ExperiencesFieldNumber = 1;

	[Token(Token = "0x4000B67")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<JobExperience> _repeated_experiences_codec;

	[Token(Token = "0x4000B68")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<JobExperience> experiences_;

	[Token(Token = "0x17000755")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JobExperiencesUpdateEvent> Parser
	{
		[Token(Token = "0x600223F")]
		[Address(RVA = "0x973390", Offset = "0x972790", VA = "0x180973390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000756")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002240")]
		[Address(RVA = "0x9732E0", Offset = "0x9726E0", VA = "0x1809732E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000757")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002241")]
		[Address(RVA = "0x9735A0", Offset = "0x9729A0", VA = "0x1809735A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000758")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<JobExperience> Experiences
	{
		[Token(Token = "0x6002245")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002242")]
	[Address(RVA = "0x973260", Offset = "0x972660", VA = "0x180973260")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobExperiencesUpdateEvent()
	{
	}

	[Token(Token = "0x6002243")]
	[Address(RVA = "0x9731D0", Offset = "0x9725D0", VA = "0x1809731D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobExperiencesUpdateEvent(JobExperiencesUpdateEvent other)
	{
	}

	[Token(Token = "0x6002244")]
	[Address(RVA = "0x972D20", Offset = "0x972120", VA = "0x180972D20", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobExperiencesUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002246")]
	[Address(RVA = "0x972DE0", Offset = "0x9721E0", VA = "0x180972DE0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002247")]
	[Address(RVA = "0x972EC0", Offset = "0x9722C0", VA = "0x180972EC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JobExperiencesUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002248")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002249")]
	[Address(RVA = "0x972FD0", Offset = "0x9723D0", VA = "0x180972FD0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600224A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600224B")]
	[Address(RVA = "0x9734F0", Offset = "0x9728F0", VA = "0x1809734F0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600224C")]
	[Address(RVA = "0x972C80", Offset = "0x972080", VA = "0x180972C80", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600224D")]
	[Address(RVA = "0x972F50", Offset = "0x972350", VA = "0x180972F50", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(JobExperiencesUpdateEvent other)
	{
	}

	[Token(Token = "0x600224E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600224F")]
	[Address(RVA = "0x9733E0", Offset = "0x9727E0", VA = "0x1809733E0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
