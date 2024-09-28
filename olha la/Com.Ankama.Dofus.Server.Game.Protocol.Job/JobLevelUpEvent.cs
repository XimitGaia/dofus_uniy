using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job;

[Token(Token = "0x200034D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JobLevelUpEvent : IMessage<JobLevelUpEvent>, IMessage, IEquatable<JobLevelUpEvent>, IDeepCloneable<JobLevelUpEvent>, IBufferMessage
{
	[Token(Token = "0x4000B5D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JobLevelUpEvent> _parser;

	[Token(Token = "0x4000B5E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000B5F")]
	public const int NewLevelFieldNumber = 1;

	[Token(Token = "0x4000B60")]
	[FieldOffset(Offset = "0x18")]
	private int newLevel_;

	[Token(Token = "0x4000B61")]
	public const int JobFieldNumber = 2;

	[Token(Token = "0x4000B62")]
	[FieldOffset(Offset = "0x20")]
	private JobDescription job_;

	[Token(Token = "0x17000750")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<JobLevelUpEvent> Parser
	{
		[Token(Token = "0x6002227")]
		[Address(RVA = "0x973DB0", Offset = "0x9731B0", VA = "0x180973DB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000751")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002228")]
		[Address(RVA = "0x973D00", Offset = "0x973100", VA = "0x180973D00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000752")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002229")]
		[Address(RVA = "0x973F20", Offset = "0x973320", VA = "0x180973F20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000753")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int NewLevel
	{
		[Token(Token = "0x600222D")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600222E")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000754")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobDescription Job
	{
		[Token(Token = "0x600222F")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002230")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x600222A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobLevelUpEvent()
	{
	}

	[Token(Token = "0x600222B")]
	[Address(RVA = "0x973BE0", Offset = "0x972FE0", VA = "0x180973BE0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobLevelUpEvent(JobLevelUpEvent other)
	{
	}

	[Token(Token = "0x600222C")]
	[Address(RVA = "0x973740", Offset = "0x972B40", VA = "0x180973740", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobLevelUpEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002231")]
	[Address(RVA = "0x973890", Offset = "0x972C90", VA = "0x180973890", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002232")]
	[Address(RVA = "0x940820", Offset = "0x93FC20", VA = "0x180940820", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JobLevelUpEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002233")]
	[Address(RVA = "0x940940", Offset = "0x93FD40", VA = "0x180940940", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002234")]
	[Address(RVA = "0x973A80", Offset = "0x972E80", VA = "0x180973A80", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002235")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002236")]
	[Address(RVA = "0x940E90", Offset = "0x940290", VA = "0x180940E90", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002237")]
	[Address(RVA = "0x973680", Offset = "0x972A80", VA = "0x180973680", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002238")]
	[Address(RVA = "0x973940", Offset = "0x972D40", VA = "0x180973940", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(JobLevelUpEvent other)
	{
	}

	[Token(Token = "0x6002239")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600223A")]
	[Address(RVA = "0x973E00", Offset = "0x973200", VA = "0x180973E00", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
