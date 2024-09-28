using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job;

[Token(Token = "0x200037D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JobCrafterDirectorySettings : IMessage<JobCrafterDirectorySettings>, IMessage, IEquatable<JobCrafterDirectorySettings>, IDeepCloneable<JobCrafterDirectorySettings>, IBufferMessage
{
	[Token(Token = "0x4000C0B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JobCrafterDirectorySettings> _parser;

	[Token(Token = "0x4000C0C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C0D")]
	public const int JobIdFieldNumber = 1;

	[Token(Token = "0x4000C0E")]
	[FieldOffset(Offset = "0x18")]
	private int jobId_;

	[Token(Token = "0x4000C0F")]
	public const int MinLevelFieldNumber = 2;

	[Token(Token = "0x4000C10")]
	[FieldOffset(Offset = "0x1C")]
	private int minLevel_;

	[Token(Token = "0x4000C11")]
	public const int FreeFieldNumber = 3;

	[Token(Token = "0x4000C12")]
	[FieldOffset(Offset = "0x20")]
	private bool free_;

	[Token(Token = "0x170007C2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<JobCrafterDirectorySettings> Parser
	{
		[Token(Token = "0x600242A")]
		[Address(RVA = "0x98A360", Offset = "0x989760", VA = "0x18098A360")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007C3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600242B")]
		[Address(RVA = "0x98A2B0", Offset = "0x9896B0", VA = "0x18098A2B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007C4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600242C")]
		[Address(RVA = "0x98A450", Offset = "0x989850", VA = "0x18098A450", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007C5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int JobId
	{
		[Token(Token = "0x6002430")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002431")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170007C6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MinLevel
	{
		[Token(Token = "0x6002432")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002433")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170007C7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Free
	{
		[Token(Token = "0x6002434")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002435")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x600242D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectorySettings()
	{
	}

	[Token(Token = "0x600242E")]
	[Address(RVA = "0x92C240", Offset = "0x92B640", VA = "0x18092C240")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobCrafterDirectorySettings(JobCrafterDirectorySettings other)
	{
	}

	[Token(Token = "0x600242F")]
	[Address(RVA = "0x989F40", Offset = "0x989340", VA = "0x180989F40", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobCrafterDirectorySettings Clone()
	{
		return null;
	}

	[Token(Token = "0x6002436")]
	[Address(RVA = "0x989FD0", Offset = "0x9893D0", VA = "0x180989FD0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002437")]
	[Address(RVA = "0x92BF50", Offset = "0x92B350", VA = "0x18092BF50", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JobCrafterDirectorySettings other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002438")]
	[Address(RVA = "0x98A070", Offset = "0x989470", VA = "0x18098A070", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002439")]
	[Address(RVA = "0x98A150", Offset = "0x989550", VA = "0x18098A150", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600243A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600243B")]
	[Address(RVA = "0x98A3B0", Offset = "0x9897B0", VA = "0x18098A3B0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600243C")]
	[Address(RVA = "0x989E80", Offset = "0x989280", VA = "0x180989E80", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600243D")]
	[Address(RVA = "0x92C070", Offset = "0x92B470", VA = "0x18092C070", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(JobCrafterDirectorySettings other)
	{
	}

	[Token(Token = "0x600243E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600243F")]
	[Address(RVA = "0x92C3A0", Offset = "0x92B7A0", VA = "0x18092C3A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
