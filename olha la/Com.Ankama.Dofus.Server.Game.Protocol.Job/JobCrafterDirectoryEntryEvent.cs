using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job;

[Token(Token = "0x2000365")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JobCrafterDirectoryEntryEvent : IMessage<JobCrafterDirectoryEntryEvent>, IMessage, IEquatable<JobCrafterDirectoryEntryEvent>, IDeepCloneable<JobCrafterDirectoryEntryEvent>, IBufferMessage
{
	[Token(Token = "0x4000BA5")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JobCrafterDirectoryEntryEvent> _parser;

	[Token(Token = "0x4000BA6")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000BA7")]
	public const int PlayerInformationFieldNumber = 1;

	[Token(Token = "0x4000BA8")]
	[FieldOffset(Offset = "0x18")]
	private JobCrafterDirectoryPlayerInformation playerInformation_;

	[Token(Token = "0x4000BA9")]
	public const int JobsInformationFieldNumber = 2;

	[Token(Token = "0x4000BAA")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<JobCrafterDirectoryJobInformation> _repeated_jobsInformation_codec;

	[Token(Token = "0x4000BAB")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<JobCrafterDirectoryJobInformation> jobsInformation_;

	[Token(Token = "0x4000BAC")]
	public const int LookFieldNumber = 3;

	[Token(Token = "0x4000BAD")]
	[FieldOffset(Offset = "0x28")]
	private EntityLook look_;

	[Token(Token = "0x17000782")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JobCrafterDirectoryEntryEvent> Parser
	{
		[Token(Token = "0x6002320")]
		[Address(RVA = "0x96BE20", Offset = "0x96B220", VA = "0x18096BE20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000783")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002321")]
		[Address(RVA = "0x96BD70", Offset = "0x96B170", VA = "0x18096BD70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000784")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002322")]
		[Address(RVA = "0x96C140", Offset = "0x96B540", VA = "0x18096C140", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000785")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectoryPlayerInformation PlayerInformation
	{
		[Token(Token = "0x6002326")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002327")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000786")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JobCrafterDirectoryJobInformation> JobsInformation
	{
		[Token(Token = "0x6002328")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000787")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityLook Look
	{
		[Token(Token = "0x6002329")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600232A")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x6002323")]
	[Address(RVA = "0x96BCF0", Offset = "0x96B0F0", VA = "0x18096BCF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectoryEntryEvent()
	{
	}

	[Token(Token = "0x6002324")]
	[Address(RVA = "0x96BC00", Offset = "0x96B000", VA = "0x18096BC00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectoryEntryEvent(JobCrafterDirectoryEntryEvent other)
	{
	}

	[Token(Token = "0x6002325")]
	[Address(RVA = "0x96B520", Offset = "0x96A920", VA = "0x18096B520", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobCrafterDirectoryEntryEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600232B")]
	[Address(RVA = "0x96B640", Offset = "0x96AA40", VA = "0x18096B640", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600232C")]
	[Address(RVA = "0x96B740", Offset = "0x96AB40", VA = "0x18096B740", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(JobCrafterDirectoryEntryEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600232D")]
	[Address(RVA = "0x96B800", Offset = "0x96AC00", VA = "0x18096B800", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600232E")]
	[Address(RVA = "0x96BA00", Offset = "0x96AE00", VA = "0x18096BA00", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600232F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002330")]
	[Address(RVA = "0x96C040", Offset = "0x96B440", VA = "0x18096C040", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002331")]
	[Address(RVA = "0x96B410", Offset = "0x96A810", VA = "0x18096B410", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002332")]
	[Address(RVA = "0x96B8B0", Offset = "0x96ACB0", VA = "0x18096B8B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JobCrafterDirectoryEntryEvent other)
	{
	}

	[Token(Token = "0x6002333")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002334")]
	[Address(RVA = "0x96BE70", Offset = "0x96B270", VA = "0x18096BE70", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
