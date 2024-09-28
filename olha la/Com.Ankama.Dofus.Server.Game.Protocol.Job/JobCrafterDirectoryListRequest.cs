using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job;

[Token(Token = "0x2000347")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JobCrafterDirectoryListRequest : IMessage<JobCrafterDirectoryListRequest>, IMessage, IEquatable<JobCrafterDirectoryListRequest>, IDeepCloneable<JobCrafterDirectoryListRequest>, IBufferMessage
{
	[Token(Token = "0x4000B4D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JobCrafterDirectoryListRequest> _parser;

	[Token(Token = "0x4000B4E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000B4F")]
	public const int JobIdFieldNumber = 1;

	[Token(Token = "0x4000B50")]
	[FieldOffset(Offset = "0x18")]
	private int jobId_;

	[Token(Token = "0x17000744")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<JobCrafterDirectoryListRequest> Parser
	{
		[Token(Token = "0x60021E6")]
		[Address(RVA = "0x96DA20", Offset = "0x96CE20", VA = "0x18096DA20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000745")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60021E7")]
		[Address(RVA = "0x96D970", Offset = "0x96CD70", VA = "0x18096D970")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000746")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60021E8")]
		[Address(RVA = "0x96DA70", Offset = "0x96CE70", VA = "0x18096DA70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000747")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int JobId
	{
		[Token(Token = "0x60021EC")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60021ED")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60021E9")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectoryListRequest()
	{
	}

	[Token(Token = "0x60021EA")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectoryListRequest(JobCrafterDirectoryListRequest other)
	{
	}

	[Token(Token = "0x60021EB")]
	[Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobCrafterDirectoryListRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60021EE")]
	[Address(RVA = "0x96D780", Offset = "0x96CB80", VA = "0x18096D780", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60021EF")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JobCrafterDirectoryListRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60021F0")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60021F1")]
	[Address(RVA = "0x96D810", Offset = "0x96CC10", VA = "0x18096D810", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60021F2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60021F3")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60021F4")]
	[Address(RVA = "0x96D670", Offset = "0x96CA70", VA = "0x18096D670", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60021F5")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JobCrafterDirectoryListRequest other)
	{
	}

	[Token(Token = "0x60021F6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60021F7")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
