using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job;

[Token(Token = "0x2000377")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JobCrafterDirectoryEntry : IMessage<JobCrafterDirectoryEntry>, IMessage, IEquatable<JobCrafterDirectoryEntry>, IDeepCloneable<JobCrafterDirectoryEntry>, IBufferMessage
{
	[Token(Token = "0x4000BE4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JobCrafterDirectoryEntry> _parser;

	[Token(Token = "0x4000BE5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000BE6")]
	public const int PlayerInformationFieldNumber = 1;

	[Token(Token = "0x4000BE7")]
	[FieldOffset(Offset = "0x18")]
	private JobCrafterDirectoryPlayerInformation playerInformation_;

	[Token(Token = "0x4000BE8")]
	public const int JobInformationFieldNumber = 2;

	[Token(Token = "0x4000BE9")]
	[FieldOffset(Offset = "0x20")]
	private JobCrafterDirectoryJobInformation jobInformation_;

	[Token(Token = "0x170007AA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<JobCrafterDirectoryEntry> Parser
	{
		[Token(Token = "0x60023D0")]
		[Address(RVA = "0x96C970", Offset = "0x96BD70", VA = "0x18096C970")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007AB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60023D1")]
		[Address(RVA = "0x96C8C0", Offset = "0x96BCC0", VA = "0x18096C8C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007AC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60023D2")]
		[Address(RVA = "0x96CB90", Offset = "0x96BF90", VA = "0x18096CB90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007AD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobCrafterDirectoryPlayerInformation PlayerInformation
	{
		[Token(Token = "0x60023D6")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60023D7")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x170007AE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobCrafterDirectoryJobInformation JobInformation
	{
		[Token(Token = "0x60023D8")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60023D9")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x60023D3")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobCrafterDirectoryEntry()
	{
	}

	[Token(Token = "0x60023D4")]
	[Address(RVA = "0x96C820", Offset = "0x96BC20", VA = "0x18096C820")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobCrafterDirectoryEntry(JobCrafterDirectoryEntry other)
	{
	}

	[Token(Token = "0x60023D5")]
	[Address(RVA = "0x96C2F0", Offset = "0x96B6F0", VA = "0x18096C2F0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobCrafterDirectoryEntry Clone()
	{
		return null;
	}

	[Token(Token = "0x60023DA")]
	[Address(RVA = "0x96C440", Offset = "0x96B840", VA = "0x18096C440", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60023DB")]
	[Address(RVA = "0x96C3C0", Offset = "0x96B7C0", VA = "0x18096C3C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JobCrafterDirectoryEntry other)
	{
		return default(bool);
	}

	[Token(Token = "0x60023DC")]
	[Address(RVA = "0x96C500", Offset = "0x96B900", VA = "0x18096C500", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60023DD")]
	[Address(RVA = "0x96C6C0", Offset = "0x96BAC0", VA = "0x18096C6C0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60023DE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60023DF")]
	[Address(RVA = "0x96CB10", Offset = "0x96BF10", VA = "0x18096CB10", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60023E0")]
	[Address(RVA = "0x96C230", Offset = "0x96B630", VA = "0x18096C230", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60023E1")]
	[Address(RVA = "0x96C590", Offset = "0x96B990", VA = "0x18096C590", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JobCrafterDirectoryEntry other)
	{
	}

	[Token(Token = "0x60023E2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60023E3")]
	[Address(RVA = "0x96C9C0", Offset = "0x96BDC0", VA = "0x18096C9C0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
