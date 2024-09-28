using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job;

[Token(Token = "0x2000361")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JobCrafterDirectoryRemoveEvent : IMessage<JobCrafterDirectoryRemoveEvent>, IMessage, IEquatable<JobCrafterDirectoryRemoveEvent>, IDeepCloneable<JobCrafterDirectoryRemoveEvent>, IBufferMessage
{
	[Token(Token = "0x4000B99")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JobCrafterDirectoryRemoveEvent> _parser;

	[Token(Token = "0x4000B9A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000B9B")]
	public const int JobIdFieldNumber = 1;

	[Token(Token = "0x4000B9C")]
	[FieldOffset(Offset = "0x18")]
	private int jobId_;

	[Token(Token = "0x4000B9D")]
	public const int PlayerIdFieldNumber = 2;

	[Token(Token = "0x4000B9E")]
	[FieldOffset(Offset = "0x20")]
	private long playerId_;

	[Token(Token = "0x17000779")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JobCrafterDirectoryRemoveEvent> Parser
	{
		[Token(Token = "0x60022F2")]
		[Address(RVA = "0x96F090", Offset = "0x96E490", VA = "0x18096F090")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700077A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60022F3")]
		[Address(RVA = "0x96EFE0", Offset = "0x96E3E0", VA = "0x18096EFE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700077B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60022F4")]
		[Address(RVA = "0x96F0E0", Offset = "0x96E4E0", VA = "0x18096F0E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700077C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int JobId
	{
		[Token(Token = "0x60022F8")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60022F9")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700077D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long PlayerId
	{
		[Token(Token = "0x60022FA")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60022FB")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x60022F5")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectoryRemoveEvent()
	{
	}

	[Token(Token = "0x60022F6")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectoryRemoveEvent(JobCrafterDirectoryRemoveEvent other)
	{
	}

	[Token(Token = "0x60022F7")]
	[Address(RVA = "0x96ED50", Offset = "0x96E150", VA = "0x18096ED50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectoryRemoveEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60022FC")]
	[Address(RVA = "0x96EDE0", Offset = "0x96E1E0", VA = "0x18096EDE0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60022FD")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JobCrafterDirectoryRemoveEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60022FE")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60022FF")]
	[Address(RVA = "0x96EE80", Offset = "0x96E280", VA = "0x18096EE80", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002300")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002301")]
	[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002302")]
	[Address(RVA = "0x96EC90", Offset = "0x96E090", VA = "0x18096EC90", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002303")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(JobCrafterDirectoryRemoveEvent other)
	{
	}

	[Token(Token = "0x6002304")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002305")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
