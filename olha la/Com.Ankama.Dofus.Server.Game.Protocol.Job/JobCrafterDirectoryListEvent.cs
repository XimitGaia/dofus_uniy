using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job;

[Token(Token = "0x2000358")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JobCrafterDirectoryListEvent : IMessage<JobCrafterDirectoryListEvent>, IMessage, IEquatable<JobCrafterDirectoryListEvent>, IDeepCloneable<JobCrafterDirectoryListEvent>, IBufferMessage
{
	[Token(Token = "0x4000B80")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JobCrafterDirectoryListEvent> _parser;

	[Token(Token = "0x4000B81")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000B82")]
	public const int ListEntriesFieldNumber = 1;

	[Token(Token = "0x4000B83")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<JobCrafterDirectoryEntry> _repeated_listEntries_codec;

	[Token(Token = "0x4000B84")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<JobCrafterDirectoryEntry> listEntries_;

	[Token(Token = "0x17000768")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JobCrafterDirectoryListEvent> Parser
	{
		[Token(Token = "0x600229B")]
		[Address(RVA = "0x96D380", Offset = "0x96C780", VA = "0x18096D380")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000769")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600229C")]
		[Address(RVA = "0x96D2D0", Offset = "0x96C6D0", VA = "0x18096D2D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700076A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600229D")]
		[Address(RVA = "0x96D590", Offset = "0x96C990", VA = "0x18096D590", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700076B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<JobCrafterDirectoryEntry> ListEntries
	{
		[Token(Token = "0x60022A1")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600229E")]
	[Address(RVA = "0x96D1C0", Offset = "0x96C5C0", VA = "0x18096D1C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectoryListEvent()
	{
	}

	[Token(Token = "0x600229F")]
	[Address(RVA = "0x96D240", Offset = "0x96C640", VA = "0x18096D240")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectoryListEvent(JobCrafterDirectoryListEvent other)
	{
	}

	[Token(Token = "0x60022A0")]
	[Address(RVA = "0x96CD10", Offset = "0x96C110", VA = "0x18096CD10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectoryListEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60022A2")]
	[Address(RVA = "0x96CE60", Offset = "0x96C260", VA = "0x18096CE60", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60022A3")]
	[Address(RVA = "0x96CDD0", Offset = "0x96C1D0", VA = "0x18096CDD0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JobCrafterDirectoryListEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60022A4")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60022A5")]
	[Address(RVA = "0x96CFC0", Offset = "0x96C3C0", VA = "0x18096CFC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60022A6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60022A7")]
	[Address(RVA = "0x96D4E0", Offset = "0x96C8E0", VA = "0x18096D4E0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60022A8")]
	[Address(RVA = "0x96CC70", Offset = "0x96C070", VA = "0x18096CC70", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60022A9")]
	[Address(RVA = "0x96CF40", Offset = "0x96C340", VA = "0x18096CF40", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JobCrafterDirectoryListEvent other)
	{
	}

	[Token(Token = "0x60022AA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60022AB")]
	[Address(RVA = "0x96D3D0", Offset = "0x96C7D0", VA = "0x18096D3D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
